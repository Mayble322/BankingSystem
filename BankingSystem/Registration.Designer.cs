namespace BankingSystem
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Logtxt = new System.Windows.Forms.TextBox();
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.SurNametxt = new System.Windows.Forms.TextBox();
            this.SecPasstxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(383, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Реєстрація";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логін";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Призвіще";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Повторіть пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пароль";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(102, 138);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(142, 22);
            this.Nametxt.TabIndex = 6;
            // 
            // Logtxt
            // 
            this.Logtxt.Location = new System.Drawing.Point(102, 193);
            this.Logtxt.Name = "Logtxt";
            this.Logtxt.Size = new System.Drawing.Size(142, 22);
            this.Logtxt.TabIndex = 7;
            // 
            // Passtxt
            // 
            this.Passtxt.Location = new System.Drawing.Point(102, 246);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.Size = new System.Drawing.Size(142, 22);
            this.Passtxt.TabIndex = 8;
            // 
            // SurNametxt
            // 
            this.SurNametxt.Location = new System.Drawing.Point(511, 143);
            this.SurNametxt.Name = "SurNametxt";
            this.SurNametxt.Size = new System.Drawing.Size(141, 22);
            this.SurNametxt.TabIndex = 9;
            // 
            // SecPasstxt
            // 
            this.SecPasstxt.Location = new System.Drawing.Point(511, 238);
            this.SecPasstxt.Name = "SecPasstxt";
            this.SecPasstxt.Size = new System.Drawing.Size(141, 22);
            this.SecPasstxt.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 64);
            this.button1.TabIndex = 11;
            this.button1.Text = "Зареєструватись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SecPasstxt);
            this.Controls.Add(this.SurNametxt);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.Logtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Logtxt;
        private System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.TextBox SurNametxt;
        private System.Windows.Forms.TextBox SecPasstxt;
        private System.Windows.Forms.Button button1;
    }
}