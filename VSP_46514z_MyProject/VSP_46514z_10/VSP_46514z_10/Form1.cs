namespace VSP_46514z_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.monthCalendar1.MinDate = DateTime
                .Today;
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {

            this.textBoxResultDate.Text = "Вие избрахте дата: " + this.monthCalendar1.SelectionRange.Start.ToString();
        }

        private void buttonPlace_Click(object sender, EventArgs e)
        {
            this.textBoxResultPlace.Text = "Вие избрахте място: " + this.textBoxPlace.Text;
        }
    }
}