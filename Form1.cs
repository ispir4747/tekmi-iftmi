using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekmi_çiftmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say1, kalan;
            say1=Convert.ToInt32(textBox1.Text);
            kalan = say1 % 2;
            if(kalan == 1)
            {
                label1.Text = "sayı cift";

            }
            else
            {
                label1.Text = "sayı tek";
            }
        }
    }
}
