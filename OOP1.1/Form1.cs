using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NakladniAuto nakladniauto;
        
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nakladniauto.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) == false && String.IsNullOrEmpty(textBox2.Text) == false)
            {
                nakladniauto = new NakladniAuto(textBox1.Text, int.Parse(textBox2.Text));
            }
            else
            {
                MessageBox.Show("Musíš zadat SPZ a nosnost!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text) == false)
            {
                nakladniauto.NalozNaklad(int.Parse(textBox3.Text));
            }
            else
            {
                MessageBox.Show("Musíš zadat náklad!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text) == false)
            {
                nakladniauto.VylozNaklad(int.Parse(textBox3.Text));
            }
            else
            {
                MessageBox.Show("Musíš zadat náklad!");
            }
        }
    }
}
