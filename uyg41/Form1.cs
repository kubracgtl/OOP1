using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int etiketfiyat, indirimorani;
            double indirimlifiyat;
            etiketfiyat = Convert.ToInt32(textBox1.Text);
            indirimorani = Convert.ToInt32(textBox2.Text);
            indirimlifiyat = etiketfiyat - etiketfiyat * indirimorani/0.100;
          
            label3.Text = indirimlifiyat.ToString();

        }

        
      
        
        }
    }
}
