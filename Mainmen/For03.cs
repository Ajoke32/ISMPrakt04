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
    public partial class For03 : Form
    {
        public For03()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelCh_Click(object sender, EventArgs e)
        {
            int k;
            double r;
            if (!double.TryParse(textBoxQ.Text, out r) || !int.TryParse(textBoxN.Text, out k)|| k<0)
            {
                MessageBox.Show("Не корректно введено одне із значень або n<0,\nТакож спробуйте ввести число а через кому, а не через крапку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double a = double.Parse(textBoxQ.Text);
                int b = int.Parse(textBoxN.Text);
                double res = PraktMath.For3(r,k);
                labelresq.Text = $"{res}";
                labelRes.Visible = true;
                labelresq.Visible = true;
            }
        }
    }
}
