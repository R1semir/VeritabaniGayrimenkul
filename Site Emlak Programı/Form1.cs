using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Site_Emlak_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "panelgiriş12345")
            {
                Form2 emlakkayit = new Form2();
                emlakkayit.Show();
                this.Hide();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
