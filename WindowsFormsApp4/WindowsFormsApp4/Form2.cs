using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();


            int randomNumber = random.Next(1, 49);
            textBox1.Text = randomNumber.ToString();

            string space = Environment.NewLine;
            fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(fs);
            for (int i = 1; i < 8; i++)
            {
                randomNumber = random.Next(1, 49);
                textBox1.Text = textBox1.Text + space + randomNumber.ToString();




            }

            textOut.WriteLine("Max, " + DateTime.Now.ToShortDateString() + DateTime.Now.ToLongTimeString() + ",  " + textBox1.Text);
            textOut.Close();




        }
    }
}
