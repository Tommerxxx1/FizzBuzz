namespace AnotherFirstWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HelloTextBox_Click(object sender, EventArgs e)
        {
            HelloTextBox.Text = "Hello";
        }
    }
}