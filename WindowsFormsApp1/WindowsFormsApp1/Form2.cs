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
        private string _path1 = @"C:\Users\ДНС\source\repos\WindowsFormsApp1\save1.txt";
        private string _path2 = @"C:\Users\ДНС\source\repos\WindowsFormsApp1\save2.txt";
        private string _path3 = @"C:\Users\ДНС\source\repos\WindowsFormsApp1\save3.txt";
        private StreamReader sr;
        public ifform()
        {
            InitializeComponent();
            sr = new StreamReader(_path1);
            if (File.Exists(_path1))
            {
                string temp = sr.ReadLine();
                sr.Close();
                inA.Text = temp;
            }
            sr = new StreamReader(_path2);
            if (File.Exists(_path2))
            {
                string temp = sr.ReadLine();
                sr.Close();
                inB.Text = temp;
            }
            sr = new StreamReader(_path3);
            if (File.Exists(_path3))
            {
                string temp = sr.ReadLine();
                sr.Close();
                inC.Text = temp;
            }
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
                    label2.Text = Convert.ToString(res);
                }
                else
                {
                    res = A * C;
                    label2.Text = Convert.ToString(res);
                }
            }
            else
            {
                res = B * C;
                label2.Text = Convert.ToString(res);
            }
        }
              private void ifform_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void inA_TextChanged(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(_path1);
            sw.WriteLine(inA.Text);
            sw.Close();
        }

        private void inB_TextChanged(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(_path2);
            sw.WriteLine(inB.Text);
            sw.Close();
        }

        private void inC_TextChanged(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(_path3);
            sw.WriteLine(inC.Text);
            sw.Close();
        }
    }
}  


