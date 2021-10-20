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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxResults.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            FirNm = Double.Parse(textBoxResults.Text);
            operation = b.Text;
            textBoxResults.Text = "";
        }
    }
}
