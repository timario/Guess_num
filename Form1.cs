using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Guess_the_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int rnd_num;
        int count;       
        private void Form1_Shown(object sender, EventArgs e)
        {
            Random num = new Random();
            rnd_num = num.Next(1, 100);
           // rnd_num = 50;
          //  textBox2.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            int check_num = int.Parse(text);
            count++;
            if (check_num < rnd_num)
            {
                textBox3.Visible = true;
                textBox3.Text = "more";
            }
            else if (check_num > rnd_num)
            {
                textBox3.Text = "less";
            }
            else
            {
                textBox2.Enabled = true;
                textBox3.Text = "equals";
                textBox2.Text = count.ToString();
                Form2 new_form = new Form2();
                new_form.Show();
            }
            textBox2.Text = count.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            Random num = new Random();
            rnd_num = num.Next(1, 100);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Visible = false;
        }
    }

}
