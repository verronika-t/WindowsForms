using System.ComponentModel;

namespace VSP_46514z_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.buttonOK.Enabled = false;

            this.textBoxAddress.Tag = false;
            this.textBoxAge.Tag = false;
            this.textBoxName.Tag = false;

            this.textBoxName.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBoxAddress.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBoxAge.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string output;

            output = "Име: " + this.textBoxName.Text + "\r\n";
            output += "Адрес: " + this.textBoxAddress.Text + "\r\n";
            output += "Професия: " + (string)(this.checkBoxProgrammer.Checked ? "Програмист" : "Не е програмист") + "\r\n";
            output += "Пол: " + (string)(this.radioButtonMale.Checked ? "Мъж" : "Жена") + "\r\n";
            output += "Възраст: " + this.textBoxAge.Text + "\r\n";

            this.textBoxOutput.Text = output;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string output;

            output = "Помощна информация: \r\n\r\n";
            output += "Име = Вашето име\r\n";
            output += "Адрес = Вашиат адрес\r\n";
            output += "Програмист = Маркирайте полето, ако сте програмист\r\n";
            output += "Пол = Маркирайте своя пол\r\n";
            output += "Възраст = Вашата възраст";

            this.textBoxOutput.Text = output;
        }

        private void ValidateOK()
        {
            this.buttonOK.Enabled =
                ((bool)(this.textBoxAddress.Tag)
                && (bool)(this.textBoxAge.Tag)
                && (bool)(this.textBoxName.Tag));
        }

        private void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }

            ValidateOK();
         

        }


        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
           
            else
            {
                tb.Tag = true;
                tb.BackColor = SystemColors.Window;
            }

            ValidateOK();
        }
    }
}