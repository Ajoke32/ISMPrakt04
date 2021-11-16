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
    public partial class While2 : Form
    {
        public While2()
        {
            InitializeComponent();
        }

        private void buttonres_Click(object sender, EventArgs e)
        {
            int s;
            if (!int.TryParse(textBoxN.Text, out s) || s < 1)
            {
                MessageBox.Show("Не корректно введено n або n<1", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = int.Parse(textBoxN.Text);
                double res = PraktMath.While2(s);
                labelres2.Text = $"{res}";
                labelres2.Visible = true;
                labelres.Visible = true;
            }
        }
    }
}
