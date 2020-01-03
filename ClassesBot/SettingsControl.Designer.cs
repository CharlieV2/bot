namespace ClassesBot
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
            this.MstuLink = new System.Windows.Forms.Label();
            this.CreatorLink = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustomTabControl = new System.Windows.Forms.Panel();
            this.MstuTab = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VkTab = new System.Windows.Forms.Button();
            this.FormatTab = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // MstuLink
            // 
            this.MstuLink.AutoSize = true;
            this.MstuLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MstuLink.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MstuLink.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MstuLink.Location = new System.Drawing.Point(416, 268);
            this.MstuLink.Name = "MstuLink";
            this.MstuLink.Size = new System.Drawing.Size(127, 21);
            this.MstuLink.TabIndex = 8;
            this.MstuLink.Text = "www.mstu.edu.ru";
            this.MstuLink.Click += new System.EventHandler(this.Link_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(136)))), ((int)(((byte)(236)))));
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 1);
            this.panel2.TabIndex = 12;
            // 
            // CustomTabControl
            // 
            this.CustomTabControl.Location = new System.Drawing.Point(0, 52);
            this.CustomTabControl.Name = "CustomTabControl";
            this.CustomTabControl.Size = new System.Drawing.Size(546, 204);
            this.CustomTabControl.TabIndex = 13;
            // 
            // MstuTab
            // 
            this.MstuTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.MstuTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.MstuTab.FlatAppearance.BorderSize = 0;
            this.MstuTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MstuTab.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MstuTab.Location = new System.Drawing.Point(8, 17);
            this.MstuTab.Name = "MstuTab";
            this.MstuTab.Size = new System.Drawing.Size(75, 34);
            this.MstuTab.TabIndex = 14;
            this.MstuTab.TabStop = false;
            this.MstuTab.Text = "MSTU";
            this.MstuTab.UseVisualStyleBackColor = false;
            this.MstuTab.Click += new System.EventHandler(this.MstuTab_Click);
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
            // VkTab
            // 
            this.VkTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.VkTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.VkTab.FlatAppearance.BorderSize = 0;
            this.VkTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VkTab.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VkTab.Location = new System.Drawing.Point(81, 17);
            this.VkTab.Name = "VkTab";
            this.VkTab.Size = new System.Drawing.Size(75, 34);
            this.VkTab.TabIndex = 15;
            this.VkTab.TabStop = false;
            this.VkTab.Text = "Vk set";
            this.VkTab.UseVisualStyleBackColor = false;
            this.VkTab.Click += new System.EventHandler(this.VkTab_Click);
            // 
            // FormatTab
            // 
            this.FormatTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.FormatTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.FormatTab.FlatAppearance.BorderSize = 0;
            this.FormatTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormatTab.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormatTab.Location = new System.Drawing.Point(156, 17);
            this.FormatTab.Name = "FormatTab";
            this.FormatTab.Size = new System.Drawing.Size(75, 34);
            this.FormatTab.TabIndex = 16;
            this.FormatTab.TabStop = false;
            this.FormatTab.Text = "Format";
            this.FormatTab.UseVisualStyleBackColor = false;
            this.FormatTab.Click += new System.EventHandler(this.FormatTab_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MstuTab);
            this.Controls.Add(this.VkTab);
            this.Controls.Add(this.FormatTab);
            this.Controls.Add(this.CustomTabControl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreatorLink);
            this.Controls.Add(this.MstuLink);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(546, 321);
            this.VisibleChanged += new System.EventHandler(this.UpdateForm);
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Back_Button;
        private System.Windows.Forms.Label MstuLink;
        private System.Windows.Forms.Label CreatorLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CustomTabControl;
        private System.Windows.Forms.Button MstuTab;
        private System.Windows.Forms.Button VkTab;
        private System.Windows.Forms.Button FormatTab;
    }
}
