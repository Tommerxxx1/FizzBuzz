namespace YourFirstWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            lbl_helloeMessage.Text = "Nice to meet you";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_changeColor_Click(object sender, EventArgs e)
        {
             
        }

        private void btn_changeColor_Click_1(object sender, EventArgs e)
        {
            lbl_helloeMessage.ForeColor = Color.Red;
        }
    }
}