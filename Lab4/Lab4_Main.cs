using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4_Main : Form
    {
        public Lab4_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab4_Bai1 lab4_Bai1 = new Lab4_Bai1();
            lab4_Bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab4_bai2 lab4_Bai2 = new Lab4_bai2();
            lab4_Bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab4_Bai3 lab4_Bai3 = new Lab4_Bai3();
            lab4_Bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab4_Bai4 lab4_Bai4 = new Lab4_Bai4();
            lab4_Bai4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab4_Bai6 lab4_Bai6 = new Lab4_Bai6();
            lab4_Bai6.Show();
        }
    }
}
