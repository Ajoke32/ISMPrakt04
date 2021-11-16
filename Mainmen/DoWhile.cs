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
    public partial class DoWhile : Form
    {
        public DoWhile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(textBoxN.Text, out n))
            { 
                MessageBox.Show("Не корректно введено значення n", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int a = int.Parse(textBoxN.Text);
                int sum = PraktMath.DoW(a);
                labelRes2.Text = $"{sum}";
                labelRes2.Visible = true;
                labelRes1.Visible = true;

            }
        }
    }
}
