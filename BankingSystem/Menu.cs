using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void змінитиПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ChangePassword chengPass = new ChangePassword();
            chengPass.MdiParent = this;
            chengPass.Show();
        }

        private void вихідToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void створитиКартуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCard createCard = new CreateCard();
            createCard.MdiParent = this;
            createCard.Show();
        }

        private void транзакціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions trans = new Transactions();
            trans.MdiParent = this;
            trans.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        
    }
}
