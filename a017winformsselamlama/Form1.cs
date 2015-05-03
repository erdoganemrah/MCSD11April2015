using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a017WinformsSelamlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelamla_Click(object sender, EventArgs e)
        {
            string Isim = textBox1.Text;
            string Selam = "Merhaba " + Isim + "!";
            MessageBox.Show(Selam);
        }
    }
}
