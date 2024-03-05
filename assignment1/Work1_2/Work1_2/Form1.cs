namespace Work1_2
{
    public partial class Form1 : Form
    {
        double numberOne,numberTwo,result;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sign == "+") { result = numberOne + numberTwo; }
            else if (sign == "-") { result = numberOne - numberTwo; }
            else if (sign == "*") { result = numberOne * numberTwo; }
            else if (sign == "/") { result = numberOne/ numberTwo; }
            label1.Text = "½á¹ûÊÇ:"+result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numberOne = Double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            numberTwo = Double.Parse(textBox2.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           sign = comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
