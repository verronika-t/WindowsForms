namespace VSP_46514z_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "English";
        }

        private void buttonBulgarian_Click(object sender, EventArgs e)
        {
            this.Text = "Български";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}