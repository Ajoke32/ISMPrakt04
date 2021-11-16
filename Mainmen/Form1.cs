using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mainmen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            For01 form = new For01();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            For02cs form = new For02cs();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            For03 form = new For03();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            For04 form = new For04();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form05 form = new Form05();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            While1 form = new While1();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            While2 form = new While2();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            While3 form = new While3();
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DoWhile form = new DoWhile();
            form.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Viet form = new Viet();
            form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            John_Wallis form = new John_Wallis();
            form.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LordBrouncker form = new LordBrouncker();
            form.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Leibniz form = new Leibniz();
            form.Show();
        }
    }
}
