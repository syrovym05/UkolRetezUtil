using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RetezUtil;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;

            while (vstup.Contains("  "))
            {
                vstup = vstup.Replace("  "," ");
            }

            string s = Retezec.Smaz(vstup);
            
            listBox1.Items.Add(Retezec.Zobraz(s));
            textBox1.Text = s;
        }

        private void button3_Click(object sender, EventArgs e)
        {          
            try
            {
                Minus x = new Minus(textBox1.Text);
                Minus y = new Minus(textBox2.Text);
                listBox1.Items.Add(x - y);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
 
}