using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygs40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double turkcedogru, matdogru;
            double turkceyanlis, matyanlis;
            double turkcenet, matnet;
            turkcedogru = Convert.ToDouble(textBox1.Text);
            turkceyanlis = Convert.ToDouble(textBox4.Text);
            turkcenet =(turkcedogru-(turkceyanlis/4)) ;
            textBox6.Text = turkcenet.ToString();
            matdogru = Convert.ToDouble(textBox2.Text);
            matyanlis = Convert.ToDouble(textBox3.Text);
            matnet = (matdogru - (matyanlis / 4));
            textBox5.Text = matnet.ToString();


        }
    }
}
