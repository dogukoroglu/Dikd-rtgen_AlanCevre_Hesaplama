using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikdörtgen_AlanCevre_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kkenar = Convert.ToInt16(textBox1.Text);
            int ukenar = Convert.ToInt16(textBox2.Text);
            int alan = kkenar * ukenar;
            int cevre = (kkenar + ukenar) * 2;
                
            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();
        }
    }
}
