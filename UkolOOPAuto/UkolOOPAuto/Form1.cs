using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkolOOPAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Auto auto1;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                auto1 = new Auto(textBox1.Text, (double)numericUpDown1.Value, (int)numericUpDown2.Value);
                panel2.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Chyba");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto1.Rozjed();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            auto1.Zastav(rnd.Next(1,100));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auto1.ToString());
        }
    }
}
