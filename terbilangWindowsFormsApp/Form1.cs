using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using terbilangLibrary;

namespace terbilangWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Terbilang ter = new Terbilang();
            var hasil = ter.TerbilangIndonesia(int.Parse(textBox1.Text));
            textBox2.Text = hasil.ToString(); 
        }
    }
}
