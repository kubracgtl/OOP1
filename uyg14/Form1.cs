using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 0, sayi2 = 0, sonuc;



            sonuc = (sayi1 + sayi2) * 2 + 5;
            
            MessageBox.Show("işlem sonucunuz"+ sonuc.ToString());
        }
    }
}
