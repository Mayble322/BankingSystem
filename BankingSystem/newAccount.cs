using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BankingSystem
{
    public partial class newAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal nomber;
        banking_bdEntities bank_bd;
       
       


 
        public newAccount()
        {
            InitializeComponent();
            loadedate();
            loadaccount();
          
        }

        

        private void loadaccount()
        {
            bank_bd = new banking_bdEntities();
            var item = bank_bd.userAccount.ToArray();
            nomber = item.LastOrDefault().Account_No + 1;
        }

        private void loadedate()
        {
            datelbl.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maleRadio.Checked)
            {
                gender = "чоловіча";
            }
            else if (femaleRadio.Checked)
            {
                gender = "жіноча";
            }
            else if (otherRadio.Checked)
            {
                gender = "інше";
            }
            if (maleRadio.Checked)
            {
                m_status = "одружений";
            }
            else if (UnmerriedRadio.Checked)
            {
               m_status = "не одружений";
            }
            bank_bd = new banking_bdEntities();
            userAccount acc = new userAccount();
            acc.Name = nametxt.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.PhoneNomber = phonetxt.Text;
            acc.Address = addtxt.Text;
            acc.Gender = gender;
            acc.Maritial_status = m_status;
            acc.Mother_Name = mothertxt.Text;
            acc.Father_Name = fathertxt.Text;
            acc.Balance = Convert.ToDecimal(balansetxt.Text);
            acc.Date = datelbl.Text;
            bank_bd.userAccount.Add(acc);
            bank_bd.SaveChanges();
            MessageBox.Show("Файл збережено");

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void newAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
