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
    public partial class Form05 : Form
    {
        public Form05()
        {
            InitializeComponent();
        }

        private void buttonres_Click(object sender, EventArgs e)
        {
            int s;
            if (!int.TryParse(textBoxN.Text, out s) || s < 0)
            {
                MessageBox.Show("Не корректно введено n або n<0", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = int.Parse(textBoxN.Text);
                double res = PraktMath.For5(s);
                labelres2.Text = $"{res}";
                labelres2.Visible = true;
                labelres.Visible = true;
            }
        }
    }
}
