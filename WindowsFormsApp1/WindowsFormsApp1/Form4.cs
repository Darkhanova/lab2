using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StringForm : Form
    {
        private string _path1 = @"C:\Users\ДНС\source\repos\WindowsFormsApp1\save6.txt";
        private StreamReader sr;

        public StringForm()
        {
            InitializeComponent();
            sr = new StreamReader(_path1);
            if (File.Exists(_path1))
            {
                string temp = sr.ReadLine();
                sr.Close();
                textBox1.Text = temp;
            }
        }

        public void resstr_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(_path1);
            sw.WriteLine(textBox1.Text);
            sw.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
