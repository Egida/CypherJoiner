using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;


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
    public partial class About : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public About()
        {
            InitializeComponent();
            label4.Font = new Font(label4.Font, FontStyle.Underline);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void gitBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }
    }
}
