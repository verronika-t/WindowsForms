namespace VSP_46514z_6
{
    public partial class Form1 : Form

    {
        const string MyFile = "Text.rtf";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBold_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.richTextBoxText.SelectionFont;

            if (oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style & FontStyle.Bold);
            } else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            }

            this.richTextBoxText.SelectionFont = newFont;
            this.richTextBoxText.Focus();
        }

        private void buttonUnderline_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.richTextBoxText.SelectionFont;

            if (oldFont.Underline)
            {
                newFont = new Font(oldFont, oldFont.Style & FontStyle.Underline);
            } else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }

            this.richTextBoxText.SelectionFont = newFont;
            this.richTextBoxText.Focus();
        }

        private void buttonItalic_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            oldFont = this.richTextBoxText.SelectionFont;

            if (oldFont.Italic)
            {
                newFont = new Font(oldFont, oldFont.Style & FontStyle.Italic);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }

            this.richTextBoxText.SelectionFont = newFont;
            this.richTextBoxText.Focus();
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            if (this.richTextBoxText.SelectionAlignment == HorizontalAlignment.Center)
            {
                this.richTextBoxText.SelectionAlignment = HorizontalAlignment.Left;
            } else
            {
                this.richTextBoxText.SelectionAlignment = HorizontalAlignment.Center;
                this.richTextBoxText.Focus();
            }
        }

        private void textBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int MinSize = 8;

            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            } else if (e.KeyChar == 13) {
                TextBox txt = (TextBox)sender;
                if (Convert.ToInt16(txt.Text) < MinSize)
                {
                    txt.Text = Convert.ToString(MinSize);
                }
                ApplyTextSize(txt.Text);
                e.Handled = true;
                this.richTextBoxText.Focus();
            }
        }

        private void ApplyTextSize(string textSize)
        {
            float newSize = Convert.ToSingle(textSize);
            FontFamily currentFontFamily;
            Font newFont;

            currentFontFamily = this.richTextBoxText.SelectionFont.FontFamily;
            newFont = new Font(currentFontFamily, newSize);
            this.richTextBoxText.SelectionFont = newFont;
        }

        private void richTextBoxText_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxText.LoadFile(MyFile);
                MessageBox.Show("Файлът " + MyFile + " е зареден успешно.");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Не е намерен файлът " + MyFile);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxText.SaveFile(MyFile);
                MessageBox.Show("Файлът " + MyFile + " е съхраен успешно.");
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}