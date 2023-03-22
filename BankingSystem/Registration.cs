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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

        }
        banking_bdEntities bank_bd;


        private void button1_Click(object sender, EventArgs e)
        {
            bank_bd = new banking_bdEntities();
            
            if (Logtxt.Text != string.Empty || Passtxt.Text != string.Empty || SecPasstxt.Text!= string.Empty|| Nametxt.Text != string.Empty || SurNametxt.Text 
                != string.Empty)
            {
               
            }
        }
    }
}
