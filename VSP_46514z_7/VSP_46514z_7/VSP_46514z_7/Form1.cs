namespace VSP_46514z_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.checkedListBox1.Items.Add(this.textBox1.Text);
            this.textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.checkedListBox1.CheckedItems.Count > 0)
            {
                this.listBox1.Items.Clear();

                foreach (string item in this.checkedListBox1.CheckedItems)
                    this.listBox1.Items.Add(item.ToString());

                for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                    this.checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}