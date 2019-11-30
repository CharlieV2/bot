namespace ClassesBot
{
    partial class StartForm
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
            this.SendAll = new System.Windows.Forms.Button();
            this.NewPreset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreatorLink = new System.Windows.Forms.Label();
            this.MSTULink = new System.Windows.Forms.Label();
            this.PresetsList = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SendAll
            // 
            this.SendAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.SendAll.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.SendAll.FlatAppearance.BorderSize = 0;
            this.SendAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendAll.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendAll.ForeColor = System.Drawing.Color.White;
            this.SendAll.Location = new System.Drawing.Point(101, 286);
            this.SendAll.Name = "SendAll";
            this.SendAll.Size = new System.Drawing.Size(92, 30);
            this.SendAll.TabIndex = 1;
            this.SendAll.TabStop = false;
            this.SendAll.Text = "Send all";
            this.SendAll.UseVisualStyleBackColor = false;
            // 
            // NewPreset
            // 
            this.NewPreset.BackColor = System.Drawing.Color.RoyalBlue;
            this.NewPreset.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.NewPreset.FlatAppearance.BorderSize = 0;
            this.NewPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPreset.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPreset.ForeColor = System.Drawing.Color.White;
            this.NewPreset.Image = global::ClassesBot.Properties.Resources.plus_14;
            this.NewPreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewPreset.Location = new System.Drawing.Point(3, 286);
            this.NewPreset.Name = "NewPreset";
            this.NewPreset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewPreset.Size = new System.Drawing.Size(92, 30);
            this.NewPreset.TabIndex = 2;
            this.NewPreset.TabStop = false;
            this.NewPreset.Text = "   New";
            this.NewPreset.UseVisualStyleBackColor = false;
            this.NewPreset.Click += new System.EventHandler(this.NewPreset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClassesBot.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(496, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(368, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Help";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(360, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "MSTU";
            // 
            // CreatorLink
            // 
            this.CreatorLink.AutoSize = true;
            this.CreatorLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreatorLink.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatorLink.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CreatorLink.Location = new System.Drawing.Point(415, 294);
            this.CreatorLink.Name = "CreatorLink";
            this.CreatorLink.Size = new System.Drawing.Size(126, 21);
            this.CreatorLink.TabIndex = 13;
            this.CreatorLink.Text = "vk.com/danyanet";
            this.CreatorLink.Click += new System.EventHandler(this.Link_Click);
            // 
            // MSTULink
            // 
            this.MSTULink.AutoSize = true;
            this.MSTULink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MSTULink.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSTULink.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MSTULink.Location = new System.Drawing.Point(415, 270);
            this.MSTULink.Name = "MSTULink";
            this.MSTULink.Size = new System.Drawing.Size(127, 21);
            this.MSTULink.TabIndex = 12;
            this.MSTULink.Text = "www.mstu.edu.ru";
            this.MSTULink.Click += new System.EventHandler(this.Link_Click);
            // 
            // PresetsList
            // 
            this.PresetsList.BackColor = System.Drawing.Color.White;
            this.PresetsList.Location = new System.Drawing.Point(3, 4);
            this.PresetsList.Name = "PresetsList";
            this.PresetsList.Size = new System.Drawing.Size(289, 278);
            this.PresetsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(338, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "MSTU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(338, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Help";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PresetsList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreatorLink);
            this.Controls.Add(this.MSTULink);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NewPreset);
            this.Controls.Add(this.SendAll);
            this.Name = "StartForm";
            this.Size = new System.Drawing.Size(546, 321);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SendAll;
        private System.Windows.Forms.Button NewPreset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CreatorLink;
        private System.Windows.Forms.Label MSTULink;
        private System.Windows.Forms.FlowLayoutPanel PresetsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
