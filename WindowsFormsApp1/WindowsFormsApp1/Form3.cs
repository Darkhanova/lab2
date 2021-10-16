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

    public partial class forform : Form
    {
        private string _path1 = @"C:\Users\ДНС\source\repos\WindowsFormsApp1\save4.txt";
        private string _path2 = @"C:\Users\ДНС\source\repos\WindowsFormsApp1\save5.txt";
        private StreamReader sr;
        private object masout_TextChanged;

        public forform()
        {
            InitializeComponent();
            sr = new StreamReader(_path1);
            if (File.Exists(_path1))
            {
                string temp = sr.ReadLine();
                sr.Close();
                length.Text = temp;
            }
            sr = new StreamReader(_path2);
            if (File.Exists(_path1))
            {
                string temp = sr.ReadLine();
                sr.Close();
                resule.Text = temp;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butrand_Click(object sender, EventArgs e)
        {
            resule.Clear();
            string length;
            length = this.length.Text;
            int length1 = Convert.ToInt32(length);
            int[] array1D = new int[length1];
            Random rand = new Random();
            for (int i = 0; i < length1; i++)
            {
                array1D[i] = rand.Next(-50, 100);
            }
            for (int i = 0; i < length1; i++)
            {
                if (i != length1 - 1)
                    resule.Text += array1D[i].ToString() + " ";
                else
                    resule.Text += array1D[i].ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resule.Clear();
        }

        private void butmanual_Click(object sender, EventArgs e)
        {
            string length = this.length.Text;
            int length1 = Convert.ToInt32(length);
            string[] sNums = resule.Text.Split(' ');
            if (length1 > sNums.Length || length1 < sNums.Length)
            {
                MessageBox.Show("Длина массива не соответствует введенному!");
                return;
            }
            
    
        }

        private void restaskfor_Click(object sender, EventArgs e)
        {

            string length = this.length.Text;
            int length1 = Convert.ToInt32(length);
            string[] sNums = resule.Text.Split(' ');
            int[] nums = new int[length1];
            if (length1 > sNums.Length || length1 < sNums.Length)
            {
                MessageBox.Show("Длина массива не соответствует введенному!");
                return;
            }
            for (int i = 0; i < length1; i++)
            {
                nums[i] = int.Parse(sNums[i]);
            }

            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length1; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        MessageBox.Show("Ошибка, присутствуют одинаковые числа!");
                        return;
                    }
                }
            }
            int min = 100;
            int max = -100;
            int min2 = 100;
            int max2 = -100;
            for (int i = 0; i < length1; i++)
            {
                if (nums[i] < min)
                    min = nums[i];
                if (nums[i] > max)
                    max = nums[i];
            }
            for (int i = 0; i < length1; i++)
            {
                if (nums[i] < min2)
                    if (nums[i] != min)
                        min2 = nums[i];
                if (nums[i] > max2)
                    if (nums[i] != max)
                        max2 = nums[i];
            }
            label4.Text = Convert.ToString(max) + ", " + Convert.ToString(max2);
            label5.Text = Convert.ToString(min) + ", " + Convert.ToString(min2);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void length_TextChanged(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(_path1);
            sw.WriteLine(length.Text);
            sw.Close();
        }

        private void resule_TextChanged(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(_path2);
            sw.WriteLine(resule.Text);
            sw.Close();
        }

        private void forform_Load(object sender, EventArgs e)
        {

        }
    }
}
