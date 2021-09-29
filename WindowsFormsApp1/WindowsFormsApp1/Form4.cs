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
    public partial class StringForm : Form
    {
        public StringForm()
        {
            InitializeComponent();
        }

        private void resstr_Click(object sender, EventArgs e)
        {
            string str;
            string newstr = "";
            str = textBox1.Text;
            string[] subs = str.Split(' ');
            for (int i = 0; i < subs.Length; i++)
            {
                int ind = 0;
                for (int j = 0; j < subs[i].Length; j++)
                {
                    ind++;
                }
                if (ind % 2 != 0)
                {
                    newstr += subs[i] + " " + subs[i] + " ";
                }
            }
            newstr = newstr.Replace("d", "t");
            newstr = newstr.Replace("D", "T");
            textBox1.Clear();
            textBox1.Text = newstr;
        }
    }
}
