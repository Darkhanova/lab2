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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ifform Ifform = new ifform();
            Ifform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forform forform = new forform();
            forform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringForm stringform = new StringForm();
            stringform.Show();


        }

        private void fortask_Click(object sender, EventArgs e)
        {
            forform forform = new forform();
            forform.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
