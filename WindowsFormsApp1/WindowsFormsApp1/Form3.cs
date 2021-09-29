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

    public partial class forform : Form
    {

        private object masout_TextChanged;

        public forform()
        {
            InitializeComponent();
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
                MessageBox.Show("Длина массива не соответсвует введенному!");
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
                MessageBox.Show("Длина массива не соответсвует введенному!");
                return;
            }
            for (int i = 0; i < length1; i++)
            {
                nums[i] = int.Parse(sNums[i]);
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
            MessageBox.Show("2 минимальных = " + min + " " + min2 + "\n 2 максимальных = " + max + " " + max2);
            
        }
    }
}
