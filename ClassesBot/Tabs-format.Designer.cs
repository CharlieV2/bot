namespace ClassesBot
{
    partial class Tabs_format
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.patternOutputText = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DateText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(27, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Do not use % and =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(157, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 90);
            this.label11.TabIndex = 26;
            this.label11.Text = "0 - Pair number\r\n1 - Subgroup\r\n2 - Subject\r\n3 - Type of pair\r\n4 - Teacher\r\n5 - Ca" +
    "binet";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Controls.Add(this.patternOutputText);
            this.panel7.Location = new System.Drawing.Point(29, 82);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(122, 94);
            this.panel7.TabIndex = 25;
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(110, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 1);
            this.panel6.TabIndex = 22;
            // 
            // DateText
            // 
            this.DateText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateText.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.DateText.Location = new System.Drawing.Point(110, 14);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(100, 20);
            this.DateText.TabIndex = 24;
            this.DateText.TabStop = false;
            this.DateText.Text = "Text";
            this.DateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(25, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "Get Day";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Output format";
            // 
            // Tabs_format
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.DateText);
            this.Controls.Add(this.label10);
            this.Name = "Tabs_format";
            this.Size = new System.Drawing.Size(546, 206);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox patternOutputText;
        public System.Windows.Forms.TextBox DateText;
    }
}
