namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(OperandFront.Text);
                double b = Convert.ToDouble(OperandBehind.Text);
                The_Answer.Text = (a + b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("invalid input");
            }
        }

        private void Sub_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(OperandFront.Text);
                double b = Convert.ToDouble(OperandBehind.Text);
                The_Answer.Text = (a - b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("invalid input");
            }
        }

        private void Mul_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(OperandFront.Text);
                double b = Convert.ToDouble(OperandBehind.Text);
                The_Answer.Text = (a * b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("invalid input");
            }
        }

        private void Div_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(OperandFront.Text);
                double b = Convert.ToDouble(OperandBehind.Text);
                The_Answer.Text = (a / b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("invalid input");
            }
        }
    }
}