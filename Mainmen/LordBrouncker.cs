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
    public partial class LordBrouncker : Form
    {
        public LordBrouncker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            if (!int.TryParse(textBoxIT.Text, out r))
            {
                MessageBox.Show("Не корректно введено значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int b = 0;
                int a = int.Parse(textBoxIT.Text);
                double res = PraktMath.Lord(b, a);
                label3.Text = $"{res}";
                label3.Visible = true;
                label2.Visible = true;

            }
        }

        private void LordBrouncker_Load(object sender, EventArgs e)
        {

        }
    }
}
