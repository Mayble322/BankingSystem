namespace BankingSystem
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новийКористувачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиКартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транзакціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.іншеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новийКористувачToolStripMenuItem,
            this.іншеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новийКористувачToolStripMenuItem
            // 
            this.новийКористувачToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.змінитиПарольToolStripMenuItem,
            this.створитиКартуToolStripMenuItem,
            this.транзакціїToolStripMenuItem});
            this.новийКористувачToolStripMenuItem.Name = "новийКористувачToolStripMenuItem";
            this.новийКористувачToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.новийКористувачToolStripMenuItem.Text = "Користувач";
            // 
            // змінитиПарольToolStripMenuItem
            // 
            this.змінитиПарольToolStripMenuItem.Name = "змінитиПарольToolStripMenuItem";
            this.змінитиПарольToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.змінитиПарольToolStripMenuItem.Text = "Змінити пароль";
            // 
            // створитиКартуToolStripMenuItem
            // 
            this.створитиКартуToolStripMenuItem.Name = "створитиКартуToolStripMenuItem";
            this.створитиКартуToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.створитиКартуToolStripMenuItem.Text = "Створити карту";
            this.створитиКартуToolStripMenuItem.Click += new System.EventHandler(this.створитиКартуToolStripMenuItem_Click);
            // 
            // транзакціїToolStripMenuItem
            // 
            this.транзакціїToolStripMenuItem.Name = "транзакціїToolStripMenuItem";
            this.транзакціїToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.транзакціїToolStripMenuItem.Text = "Транзакції";
            this.транзакціїToolStripMenuItem.Click += new System.EventHandler(this.транзакціїToolStripMenuItem_Click);
            // 
            // іншеToolStripMenuItem
            // 
            this.іншеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem,
            this.вихідToolStripMenuItem1});
            this.іншеToolStripMenuItem.Name = "іншеToolStripMenuItem";
            this.іншеToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.іншеToolStripMenuItem.Text = "Інше";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.вихідToolStripMenuItem.Text = "Змінити акаунт";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem1
            // 
            this.вихідToolStripMenuItem1.Name = "вихідToolStripMenuItem1";
            this.вихідToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.вихідToolStripMenuItem1.Text = "Вихід";
            this.вихідToolStripMenuItem1.Click += new System.EventHandler(this.вихідToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новийКористувачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem іншеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem змінитиПарольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиКартуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транзакціїToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}