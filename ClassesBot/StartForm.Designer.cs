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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PresetsList = new System.Windows.Forms.FlowLayoutPanel();
            this.SendAll = new System.Windows.Forms.Button();
            this.NewPreset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.PresetsList);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 315);
            this.panel1.TabIndex = 0;
            // 
            // PresetsList
            // 
            this.PresetsList.BackColor = System.Drawing.Color.White;
            this.PresetsList.Location = new System.Drawing.Point(1, 1);
            this.PresetsList.Name = "PresetsList";
            this.PresetsList.Size = new System.Drawing.Size(332, 313);
            this.PresetsList.TabIndex = 0;
            // 
            // SendAll
            // 
            this.SendAll.BackColor = System.Drawing.Color.RoyalBlue;
            this.SendAll.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.SendAll.FlatAppearance.BorderSize = 0;
            this.SendAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendAll.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendAll.ForeColor = System.Drawing.Color.White;
            this.SendAll.Location = new System.Drawing.Point(454, 288);
            this.SendAll.Name = "SendAll";
            this.SendAll.Size = new System.Drawing.Size(89, 30);
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
            this.NewPreset.Location = new System.Drawing.Point(343, 288);
            this.NewPreset.Name = "NewPreset";
            this.NewPreset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewPreset.Size = new System.Drawing.Size(92, 30);
            this.NewPreset.TabIndex = 2;
            this.NewPreset.TabStop = false;
            this.NewPreset.Text = "   New";
            this.NewPreset.UseVisualStyleBackColor = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NewPreset);
            this.Controls.Add(this.SendAll);
            this.Controls.Add(this.panel1);
            this.Name = "StartForm";
            this.Size = new System.Drawing.Size(546, 321);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel PresetsList;
        private System.Windows.Forms.Button SendAll;
        private System.Windows.Forms.Button NewPreset;
    }
}
