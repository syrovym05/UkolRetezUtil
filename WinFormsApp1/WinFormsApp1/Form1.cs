using RetezUtil;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;

            while (vstup.Contains("  "))
            {
                vstup = vstup.Replace("  ", " ");
            }

            string s = Retezec.Smaz(vstup);
            foreach()
            label1.Text = (s);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}