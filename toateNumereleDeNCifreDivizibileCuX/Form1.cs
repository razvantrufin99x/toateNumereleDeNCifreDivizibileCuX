using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace toateNumereleDeNCifreDivizibileCuX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //gasit toate nr divizibile cu n din 4 cifre
        private void button1_Click(object sender, EventArgs e)
        {

            int n, i;
            n = int.Parse(textBox2.Text);
            textBox1.Text += "\r\n";
            if (1000 % n == 0)
            {
                for (i = 1000 / n; i <= 9999 / n; i++)
                {
                    textBox1.Text += (i * n).ToString();
                    textBox1.Text += "\r\n";
                    this.Refresh();
                }
            }
            else
            {
                for (i = 1000 / n + 1; i <= 9999 / n; i++)
                {
                    textBox1.Text += (i * n).ToString();
                    textBox1.Text += "\r\n";
                    this.Refresh();
                }
            }
        }
      
    }
}
