﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_bdEntities dbe = new banking_bdEntities();
            if (usrtxt.Text != string.Empty || passtxt.Text != string.Empty)
            {
                var user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(usrtxt.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(passtxt.Text))
                    {
                        Menu e1 = new Menu();
                        e1.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("Невірний логін або пароль");
                    }
                }
            }
            else
            {
                MessageBox.Show("Будьласка введіть пароль і логін");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            newAccount newacc = new newAccount();
            newacc.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

