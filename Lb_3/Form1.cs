using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Create c = new txt_cr();
            FileEx product = c.CreateFile(textBox1.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Create c = new rtf_cr();
            FileEx product = c.CreateFile(textBox1.Text);
        }
    }
}
