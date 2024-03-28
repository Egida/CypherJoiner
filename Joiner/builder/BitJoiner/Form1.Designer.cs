namespace BitJoiner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.minimaze_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.file1_box = new System.Windows.Forms.TextBox();
            this.buildDropper_Btn = new System.Windows.Forms.Button();
            this.file2_box = new System.Windows.Forms.TextBox();
            this.file1_btn = new System.Windows.Forms.Button();
            this.file2_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gitBtn = new System.Windows.Forms.PictureBox();
            this.infoBtn = new System.Windows.Forms.PictureBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputPayload_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.joinFile2_box = new System.Windows.Forms.TextBox();
            this.joinFile1_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectIcon_btn = new System.Windows.Forms.Button();
            this.iconFile_box = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFile_box)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.minimaze_btn);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 20);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "{ MAIN } - [ Cypher Joiner ]";
            // 
            // minimaze_btn
            // 
            this.minimaze_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimaze_btn.Image = global::BitJoiner.Properties.Resources.Horizontal_Line;
            this.minimaze_btn.Location = new System.Drawing.Point(661, 0);
            this.minimaze_btn.Name = "minimaze_btn";
            this.minimaze_btn.Size = new System.Drawing.Size(25, 18);
            this.minimaze_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimaze_btn.TabIndex = 3;
            this.minimaze_btn.TabStop = false;
            this.minimaze_btn.Click += new System.EventHandler(this.minimaze_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = global::BitJoiner.Properties.Resources.Close;
            this.close_btn.Location = new System.Drawing.Point(683, -4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(28, 26);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_btn.TabIndex = 2;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // file1_box
            // 
            this.file1_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.file1_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.file1_box.Font = new System.Drawing.Font("Consolas", 8.55F, System.Drawing.FontStyle.Bold);
            this.file1_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.file1_box.Location = new System.Drawing.Point(12, 79);
            this.file1_box.Multiline = true;
            this.file1_box.Name = "file1_box";
            this.file1_box.Size = new System.Drawing.Size(376, 22);
            this.file1_box.TabIndex = 4;
            // 
            // buildDropper_Btn
            // 
            this.buildDropper_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.buildDropper_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildDropper_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buildDropper_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildDropper_Btn.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold);
            this.buildDropper_Btn.ForeColor = System.Drawing.Color.White;
            this.buildDropper_Btn.Image = global::BitJoiner.Properties.Resources.Settings;
            this.buildDropper_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buildDropper_Btn.Location = new System.Drawing.Point(109, 142);
            this.buildDropper_Btn.Name = "buildDropper_Btn";
            this.buildDropper_Btn.Size = new System.Drawing.Size(217, 45);
            this.buildDropper_Btn.TabIndex = 6;
            this.buildDropper_Btn.Text = "CREATE DROPPER";
            this.buildDropper_Btn.UseVisualStyleBackColor = false;
            this.buildDropper_Btn.Click += new System.EventHandler(this.buildDropper_Btn_Click);
            // 
            // file2_box
            // 
            this.file2_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.file2_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.file2_box.Font = new System.Drawing.Font("Consolas", 8.55F, System.Drawing.FontStyle.Bold);
            this.file2_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.file2_box.Location = new System.Drawing.Point(12, 110);
            this.file2_box.Multiline = true;
            this.file2_box.Name = "file2_box";
            this.file2_box.Size = new System.Drawing.Size(376, 22);
            this.file2_box.TabIndex = 7;
            // 
            // file1_btn
            // 
            this.file1_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.file1_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.file1_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.file1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.file1_btn.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold);
            this.file1_btn.ForeColor = System.Drawing.Color.White;
            this.file1_btn.Location = new System.Drawing.Point(394, 77);
            this.file1_btn.Name = "file1_btn";
            this.file1_btn.Size = new System.Drawing.Size(30, 22);
            this.file1_btn.TabIndex = 8;
            this.file1_btn.Text = "...";
            this.file1_btn.UseVisualStyleBackColor = false;
            this.file1_btn.Click += new System.EventHandler(this.file1_btn_Click);
            // 
            // file2_btn
            // 
            this.file2_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.file2_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.file2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.file2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.file2_btn.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold);
            this.file2_btn.ForeColor = System.Drawing.Color.White;
            this.file2_btn.Location = new System.Drawing.Point(394, 110);
            this.file2_btn.Name = "file2_btn";
            this.file2_btn.Size = new System.Drawing.Size(30, 22);
            this.file2_btn.TabIndex = 9;
            this.file2_btn.Text = "...";
            this.file2_btn.UseVisualStyleBackColor = false;
            this.file2_btn.Click += new System.EventHandler(this.file2_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Consolas", 7.75F, System.Drawing.FontStyle.Bold);
            this.statusLabel.ForeColor = System.Drawing.Color.LightGreen;
            this.statusLabel.Location = new System.Drawing.Point(4, 183);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(93, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "CYPHER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(168, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "-JOINER v1.0";
            // 
            // gitBtn
            // 
            this.gitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gitBtn.Image = ((System.Drawing.Image)(resources.GetObject("gitBtn.Image")));
            this.gitBtn.Location = new System.Drawing.Point(368, 168);
            this.gitBtn.Name = "gitBtn";
            this.gitBtn.Size = new System.Drawing.Size(28, 26);
            this.gitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gitBtn.TabIndex = 12;
            this.gitBtn.TabStop = false;
            this.gitBtn.Click += new System.EventHandler(this.gitBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBtn.Image = global::BitJoiner.Properties.Resources.Info;
            this.infoBtn.Location = new System.Drawing.Point(402, 168);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(28, 26);
            this.infoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoBtn.TabIndex = 10;
            this.infoBtn.TabStop = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // logoBox
            // 
            this.logoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoBox.Image = global::BitJoiner.Properties.Resources.logo;
            this.logoBox.Location = new System.Drawing.Point(9, 27);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(88, 39);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            this.logoBox.Click += new System.EventHandler(this.logoBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputPayload_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.joinFile2_box);
            this.groupBox1.Controls.Add(this.joinFile1_box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.selectIcon_btn);
            this.groupBox1.Controls.Add(this.iconFile_box);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(439, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 164);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payload Settings";
            // 
            // outputPayload_name
            // 
            this.outputPayload_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.outputPayload_name.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Bold);
            this.outputPayload_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(248)))));
            this.outputPayload_name.Location = new System.Drawing.Point(133, 137);
            this.outputPayload_name.Multiline = true;
            this.outputPayload_name.Name = "outputPayload_name";
            this.outputPayload_name.Size = new System.Drawing.Size(121, 18);
            this.outputPayload_name.TabIndex = 20;
            this.outputPayload_name.Text = "Bind.exe";
            this.outputPayload_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "PAYLOAD-FILENAME:";
            // 
            // joinFile2_box
            // 
            this.joinFile2_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.joinFile2_box.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Bold);
            this.joinFile2_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(248)))));
            this.joinFile2_box.Location = new System.Drawing.Point(156, 110);
            this.joinFile2_box.Multiline = true;
            this.joinFile2_box.Name = "joinFile2_box";
            this.joinFile2_box.Size = new System.Drawing.Size(98, 19);
            this.joinFile2_box.TabIndex = 18;
            this.joinFile2_box.Text = "MotherRussia.exe";
            this.joinFile2_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // joinFile1_box
            // 
            this.joinFile1_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.joinFile1_box.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Bold);
            this.joinFile1_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(248)))));
            this.joinFile1_box.Location = new System.Drawing.Point(156, 86);
            this.joinFile1_box.Multiline = true;
            this.joinFile1_box.Name = "joinFile1_box";
            this.joinFile1_box.Size = new System.Drawing.Size(98, 18);
            this.joinFile1_box.TabIndex = 17;
            this.joinFile1_box.Text = "Stepasha.exe";
            this.joinFile1_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "OUTPUT-FILENAME [2]: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "OUTPUT-FILENAME [1]: ";
            // 
            // selectIcon_btn
            // 
            this.selectIcon_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.selectIcon_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectIcon_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.selectIcon_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectIcon_btn.Font = new System.Drawing.Font("Consolas", 6.75F, System.Drawing.FontStyle.Bold);
            this.selectIcon_btn.ForeColor = System.Drawing.Color.White;
            this.selectIcon_btn.Location = new System.Drawing.Point(13, 54);
            this.selectIcon_btn.Name = "selectIcon_btn";
            this.selectIcon_btn.Size = new System.Drawing.Size(57, 21);
            this.selectIcon_btn.TabIndex = 15;
            this.selectIcon_btn.Text = "select";
            this.selectIcon_btn.UseVisualStyleBackColor = false;
            this.selectIcon_btn.Click += new System.EventHandler(this.selectIcon_btn_Click);
            // 
            // iconFile_box
            // 
            this.iconFile_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconFile_box.Location = new System.Drawing.Point(85, 28);
            this.iconFile_box.Name = "iconFile_box";
            this.iconFile_box.Size = new System.Drawing.Size(50, 46);
            this.iconFile_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconFile_box.TabIndex = 3;
            this.iconFile_box.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "ICON:";
            // 
            // iconOpenDialog
            // 
            this.iconOpenDialog.FileName = "iconFile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(709, 198);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gitBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.file2_btn);
            this.Controls.Add(this.file1_btn);
            this.Controls.Add(this.file2_box);
            this.Controls.Add(this.buildDropper_Btn);
            this.Controls.Add(this.file1_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CYPHER-JOINER -  [ MAIN ] ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimaze_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFile_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.PictureBox minimaze_btn;
        private System.Windows.Forms.TextBox file1_box;
        private System.Windows.Forms.Button buildDropper_Btn;
        private System.Windows.Forms.TextBox file2_box;
        private System.Windows.Forms.Button file1_btn;
        private System.Windows.Forms.Button file2_btn;
        private System.Windows.Forms.PictureBox infoBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox gitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox joinFile2_box;
        private System.Windows.Forms.TextBox joinFile1_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button selectIcon_btn;
        private System.Windows.Forms.PictureBox iconFile_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox outputPayload_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog iconOpenDialog;
    }
}

