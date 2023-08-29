using System.Linq.Expressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double text1 = 0;
        char operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void twobut_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operation == '+')
            {
                textBox1.Text = Convert.ToString(text1 + Convert.ToDouble(textBox1.Text));
            }
            else if (operation == '-')
            {
                textBox1.Text = Convert.ToString(text1 - Convert.ToDouble(textBox1.Text));
            }

            else if (operation == 'x')
            {
                textBox1.Text = Convert.ToString(text1 * Convert.ToDouble(textBox1.Text));
            }
            else if (operation == '/')
            {
                textBox1.Text = Convert.ToString(text1 / Convert.ToDouble(textBox1.Text));
            }


            operation = ' ';

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void zerobut_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void eightbut_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void onebut_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void threebut_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void fourbut_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void fivebut_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void sixbut_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void sevenbut_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void ninebut_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void dotbut_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void divbut_Click(object sender, EventArgs e)
        {
            text1 = Convert.ToDouble(textBox1.Text);
            operation = '/';

            textBox1.Clear();
        }

        private void mulbut_Click(object sender, EventArgs e)
        {
            text1 = Convert.ToDouble(textBox1.Text);
            operation = 'x';

            textBox1.Clear();
        }

        private void minusbut_Click(object sender, EventArgs e)
        {
            text1 = Convert.ToDouble(textBox1.Text);
            operation = '-';

            textBox1.Clear();
        }

        private void plusbut_Click(object sender, EventArgs e)
        {

            text1 = Convert.ToDouble(textBox1.Text);
            operation = '+';

            textBox1.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            operation = ' ';
            text1 = 0;

        }
    }
}