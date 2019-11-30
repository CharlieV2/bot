﻿namespace ClassesBot
{
    partial class SettingsControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MSTULink = new System.Windows.Forms.Label();
            this.CreatorLink = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Token = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.VKGroupID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DateText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.patternOutputText = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Faculty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Course = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Timetable bot for students of MSTU\r\nAny course, any specialty.\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 1);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(14, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(14, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Token";
            // 
            // MSTULink
            // 
            this.MSTULink.AutoSize = true;
            this.MSTULink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MSTULink.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSTULink.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MSTULink.Location = new System.Drawing.Point(416, 268);
            this.MSTULink.Name = "MSTULink";
            this.MSTULink.Size = new System.Drawing.Size(127, 21);
            this.MSTULink.TabIndex = 8;
            this.MSTULink.Text = "www.mstu.edu.ru";
            this.MSTULink.Click += new System.EventHandler(this.Link_Click);
            // 
            // CreatorLink
            // 
            this.CreatorLink.AutoSize = true;
            this.CreatorLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreatorLink.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatorLink.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CreatorLink.Location = new System.Drawing.Point(416, 292);
            this.CreatorLink.Name = "CreatorLink";
            this.CreatorLink.Size = new System.Drawing.Size(126, 21);
            this.CreatorLink.TabIndex = 9;
            this.CreatorLink.Text = "vk.com/danyanet";
            this.CreatorLink.Click += new System.EventHandler(this.Link_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(361, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "MSTU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(369, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Help";
            // 
            // Group
            // 
            this.Group.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Group.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.Group.Location = new System.Drawing.Point(99, 39);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(100, 20);
            this.Group.TabIndex = 12;
            this.Group.TabStop = false;
            this.Group.Text = "Text";
            this.Group.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(99, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(99, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 1);
            this.panel4.TabIndex = 13;
            // 
            // Token
            // 
            this.Token.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Token.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.Token.Location = new System.Drawing.Point(99, 218);
            this.Token.Name = "Token";
            this.Token.Size = new System.Drawing.Size(160, 20);
            this.Token.TabIndex = 14;
            this.Token.TabStop = false;
            this.Token.Text = "Text";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(99, 211);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 1);
            this.panel5.TabIndex = 13;
            // 
            // VKGroupID
            // 
            this.VKGroupID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VKGroupID.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.VKGroupID.Location = new System.Drawing.Point(99, 191);
            this.VKGroupID.Name = "VKGroupID";
            this.VKGroupID.Size = new System.Drawing.Size(100, 20);
            this.VKGroupID.TabIndex = 15;
            this.VKGroupID.TabStop = false;
            this.VKGroupID.Text = "Text";
            this.VKGroupID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(14, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Group ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "MSTU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "VK Community";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(99, 150);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 1);
            this.panel6.TabIndex = 13;
            // 
            // DateText
            // 
            this.DateText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateText.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.DateText.Location = new System.Drawing.Point(99, 130);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(100, 20);
            this.DateText.TabIndex = 15;
            this.DateText.TabStop = false;
            this.DateText.Text = "Text";
            this.DateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(14, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Get Day";
            // 
            // Back_Button
            // 
            this.Back_Button.Image = ((System.Drawing.Image)(resources.GetObject("Back_Button.Image")));
            this.Back_Button.Location = new System.Drawing.Point(503, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(30, 30);
            this.Back_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back_Button.TabIndex = 4;
            this.Back_Button.TabStop = false;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            this.Back_Button.MouseEnter += new System.EventHandler(this.Back_Button_Enter);
            this.Back_Button.MouseLeave += new System.EventHandler(this.Back_Button_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClassesBot.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Controls.Add(this.patternOutputText);
            this.panel7.Location = new System.Drawing.Point(420, 119);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(122, 94);
            this.panel7.TabIndex = 19;
            // 
            // patternOutputText
            // 
            this.patternOutputText.BackColor = System.Drawing.Color.White;
            this.patternOutputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patternOutputText.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.patternOutputText.Location = new System.Drawing.Point(1, 1);
            this.patternOutputText.Name = "patternOutputText";
            this.patternOutputText.Size = new System.Drawing.Size(120, 92);
            this.patternOutputText.TabIndex = 22;
            this.patternOutputText.TabStop = false;
            this.patternOutputText.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(331, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 90);
            this.label11.TabIndex = 20;
            this.label11.Text = "0 - Pair number\r\n1 - Subgroup\r\n2 - Subject\r\n3 - Type of pair\r\n4 - Teacher\r\n5 - Ca" +
    "binet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(426, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Do not use % and =";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(99, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 1);
            this.panel3.TabIndex = 16;
            // 
            // Faculty
            // 
            this.Faculty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Faculty.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.Faculty.Location = new System.Drawing.Point(99, 69);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(100, 20);
            this.Faculty.TabIndex = 18;
            this.Faculty.TabStop = false;
            this.Faculty.Text = "Text";
            this.Faculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Faculty";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(99, 118);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 1);
            this.panel8.TabIndex = 16;
            // 
            // Course
            // 
            this.Course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Course.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.Course.Location = new System.Drawing.Point(99, 98);
            this.Course.MaxLength = 1;
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(100, 20);
            this.Course.TabIndex = 18;
            this.Course.TabStop = false;
            this.Course.Text = "Text";
            this.Course.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(14, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 21);
            this.label13.TabIndex = 17;
            this.label13.Text = "Course";
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Faculty);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.VKGroupID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Token);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreatorLink);
            this.Controls.Add(this.MSTULink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(546, 321);
            this.VisibleChanged += new System.EventHandler(this.UpdateForm);
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Back_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MSTULink;
        private System.Windows.Forms.Label CreatorLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Group;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Token;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox VKGroupID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox DateText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox patternOutputText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Faculty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox Course;
        private System.Windows.Forms.Label label13;
    }
}
