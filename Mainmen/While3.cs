using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prakt04Math;
namespace Mainmen
{
    public partial class While3 : Form
    {
        public While3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            double r,c;
            if (!double.TryParse(textBoxP.Text, out r) || r<0)
            {
                MessageBox.Show("Не корректно введено одне із значень або a>b", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double a = double.Parse(textBoxP.Text);
                double res = PraktMath.While3(a,out c);
                label3.Text = $"{res}";
                label5.Text = $"{c}";
                label3.Visible = true;
                label5.Visible = true;
                labelK.Visible = true;
                labelSum.Visible = true;

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
