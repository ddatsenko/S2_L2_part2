using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Opacity < 1f)
            {
                this.Opacity = 1f;
            }
            else
            {
                this.Opacity = 0.7f;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            { 
                this.BackColor = Color.Blue;
            }
            else
            { 
                this.BackColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Продам гараж 0635349693");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
            if (checkBox1.Checked == true)
            {
                button1_Click(sender, e);
            }
            if (checkBox2.Checked == true)
            {
                button2_Click (sender, e);
            }
            if (checkBox3.Checked == true)
            {
                button3_Click (sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
