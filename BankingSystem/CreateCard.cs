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
    public partial class CreateCard : Form
    {
        public CreateCard()
        {
            InitializeComponent();
        }
        
        public DateTime term { get; private set; }
        public long money { get; private set; }
        public string number { get; private set; }
        public string PIN { get; private set; }
        




        public static List<CreateCard> cards = new List<CreateCard>();


        static string CardNumberGenerator()
        {
            bool unique = false;
            string res = "";
            Random random = new Random();
            while (unique == false)
            {
                unique = true;
                for (int i = 1; i <= 16; i++)
                {
                    res += random.Next(0, 10);
                    if (i % 4 == 0 && i != 16)
                    {
                        res += " ";
                    }
                }
                foreach (CreateCard c in cards)
                {
                    if (c.number == res)
                    {
                        unique = false;
                    }
                }
            }
            return res;
        }


        static string CardPINGenerator()
        {
            bool unique = false;
            string res = "";
            Random random = new Random();
            while (unique == false)
            {
                unique = true;
                for (int i = 1; i <= 4; i++)
                {
                    res += random.Next(0, 10);
                }
                foreach (CreateCard c in cards)
                {
                    if (c.PIN == res)
                    {
                        unique = false;
                    }
                }
            }
            return res;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
