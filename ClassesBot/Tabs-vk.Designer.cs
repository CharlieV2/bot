namespace ClassesBot
{
    partial class Tabs_vk
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.VKGroupID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Token = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(110, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 1);
            this.panel5.TabIndex = 17;
            // 
            // VKGroupID
            // 
            this.VKGroupID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VKGroupID.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.VKGroupID.Location = new System.Drawing.Point(110, 27);
            this.VKGroupID.Name = "VKGroupID";
            this.VKGroupID.Size = new System.Drawing.Size(100, 20);
            this.VKGroupID.TabIndex = 21;
            this.VKGroupID.TabStop = false;
            this.VKGroupID.Text = "Text";
            this.VKGroupID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(110, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 1);
            this.panel4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(25, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Group ID";
            // 
            // Token
            // 
            this.Token.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Token.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.Token.Location = new System.Drawing.Point(110, 64);
            this.Token.Name = "Token";
            this.Token.Size = new System.Drawing.Size(148, 20);
            this.Token.TabIndex = 20;
            this.Token.TabStop = false;
            this.Token.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(25, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Token";
            // 
            // Tabs_vk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.VKGroupID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Token);
            this.Controls.Add(this.label4);
            this.Name = "Tabs_vk";
            this.Size = new System.Drawing.Size(546, 206);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox VKGroupID;
        public System.Windows.Forms.TextBox Token;
    }
}
