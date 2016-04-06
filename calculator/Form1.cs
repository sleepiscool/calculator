using System;
using System.Drawing;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private int _count;
        private double _num, _ans;

        public Form1()
        {
            InitializeComponent();
        }

        public void Disable()
        {
            textBox1.Enabled = false;
            button17.Show();
            button18.Hide();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
        }

        public void Enable()
        {
            textBox1.Enabled = true;
            button18.Show();
            button17.Hide();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            textBox1.ForeColor = Color.Green;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
            textBox1.ForeColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            textBox1.ForeColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            textBox1.ForeColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            textBox1.ForeColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            textBox1.ForeColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            textBox1.ForeColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            textBox1.ForeColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            textBox1.ForeColor = Color.Green;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            textBox1.ForeColor = Color.Green;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            textBox1.ForeColor = Color.Green;
        }

        private void button18_Click(object sender, EventArgs e) // off
        {
            Disable();
        }

        private void button17_Click(object sender, EventArgs e) // on
        {
            Enable();
        }

    }
}