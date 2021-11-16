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
    public partial class For01 : Form
    {
        public For01()
        {
            InitializeComponent();
        }

        private void For01_Load(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelB_Click(object sender, EventArgs e)
        {

        }

        private void labelA_Click(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int r, k;
            if (!int.TryParse(textBoxA.Text, out r) || !int.TryParse(textBoxB.Text, out k) || r < k)
            {
                MessageBox.Show("Не корректно введено одне із значень або a>b", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);
                double res = PraktMath.For1(b,a);
                labelRes.Text = $"{res}";
                labelRes.Visible = true;
                labelResult.Visible = true;
            }
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
