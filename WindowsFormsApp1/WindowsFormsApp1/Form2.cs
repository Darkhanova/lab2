using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ifform : Form
    {
        public ifform()
        {
            InitializeComponent();
        }

        private void start1_Click(object sender, EventArgs e)
        {
            string a, b, c;
            int res;
            a = this.inA.Text;
            b = this.inB.Text;
            c = this.inC.Text;
            int A = Convert.ToInt32(a);
            int B = Convert.ToInt32(b);
            int C = Convert.ToInt32(c);
            if (A < B || A < C)
            {
                if (B < C)
                {
                    res = A * B;
                    MessageBox.Show("мин. произведение = " + res);
                }
                else
                {
                    res = A * C;
                    MessageBox.Show("мин. произведение = " + res);
                }
            }
            else
            {
                res = B * C;
                MessageBox.Show("мин. произведение = " + res);
            }
        }
    }
}
