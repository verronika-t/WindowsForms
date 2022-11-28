namespace VSP_46514z_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.textBoxMessage.Text);
        }
    }
}