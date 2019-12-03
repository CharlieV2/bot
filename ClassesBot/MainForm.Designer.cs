namespace ClassesBot
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Members_Text = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Settings_Button = new System.Windows.Forms.PictureBox();
            this.Start_but = new System.Windows.Forms.PictureBox();
            this.Download_but = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Message_Text = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_but)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Download_but)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Members";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.Members_Text);
            this.panel1.Location = new System.Drawing.Point(16, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 264);
            this.panel1.TabIndex = 2;
            // 
            // Members_Text
            // 
            this.Members_Text.BackColor = System.Drawing.Color.White;
            this.Members_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Members_Text.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Members_Text.Location = new System.Drawing.Point(1, 1);
            this.Members_Text.Name = "Members_Text";
            this.Members_Text.Size = new System.Drawing.Size(150, 262);
            this.Members_Text.TabIndex = 9;
            this.Members_Text.TabStop = false;
            this.Members_Text.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(180, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message";
            // 
            // Settings_Button
            // 
            this.Settings_Button.Image = global::ClassesBot.Properties.Resources.Settings_Default;
            this.Settings_Button.Location = new System.Drawing.Point(503, 12);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Size = new System.Drawing.Size(30, 30);
            this.Settings_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Settings_Button.TabIndex = 2;
            this.Settings_Button.TabStop = false;
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Click);
            this.Settings_Button.MouseEnter += new System.EventHandler(this.Setting_Enter);
            this.Settings_Button.MouseLeave += new System.EventHandler(this.Setting_Leave);
            // 
            // Start_but
            // 
            this.Start_but.Image = global::ClassesBot.Properties.Resources.Start_default;
            this.Start_but.Location = new System.Drawing.Point(494, 138);
            this.Start_but.Name = "Start_but";
            this.Start_but.Size = new System.Drawing.Size(44, 75);
            this.Start_but.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Start_but.TabIndex = 5;
            this.Start_but.TabStop = false;
            this.Start_but.Click += new System.EventHandler(this.Start_but_Click);
            this.Start_but.MouseEnter += new System.EventHandler(this.Start_Enter);
            this.Start_but.MouseLeave += new System.EventHandler(this.Start_Leave);
            // 
            // Download_but
            // 
            this.Download_but.Image = global::ClassesBot.Properties.Resources.DownloadData_Default;
            this.Download_but.Location = new System.Drawing.Point(495, 274);
            this.Download_but.Name = "Download_but";
            this.Download_but.Size = new System.Drawing.Size(44, 35);
            this.Download_but.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Download_but.TabIndex = 6;
            this.Download_but.TabStop = false;
            this.Download_but.Click += new System.EventHandler(this.Download_but_Click);
            this.Download_but.MouseEnter += new System.EventHandler(this.Download_Enter);
            this.Download_but.MouseLeave += new System.EventHandler(this.Download_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.Message_Text);
            this.panel2.Location = new System.Drawing.Point(183, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 264);
            this.panel2.TabIndex = 3;
            // 
            // Message_Text
            // 
            this.Message_Text.BackColor = System.Drawing.Color.White;
            this.Message_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Message_Text.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Message_Text.Location = new System.Drawing.Point(1, 1);
            this.Message_Text.Name = "Message_Text";
            this.Message_Text.Size = new System.Drawing.Size(304, 262);
            this.Message_Text.TabIndex = 8;
            this.Message_Text.TabStop = false;
            this.Message_Text.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 321);
            this.Controls.Add(this.Download_but);
            this.Controls.Add(this.Start_but);
            this.Controls.Add(this.Settings_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(561, 360);
            this.MinimumSize = new System.Drawing.Size(561, 360);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Settings_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_but)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Download_but)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Settings_Button;
        private System.Windows.Forms.PictureBox Start_but;
        private System.Windows.Forms.PictureBox Download_but;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox Members_Text;
        private System.Windows.Forms.RichTextBox Message_Text;
    }
}

