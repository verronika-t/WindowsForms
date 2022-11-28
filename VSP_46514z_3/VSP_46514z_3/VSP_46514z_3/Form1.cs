namespace VSP_46514z_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeLinkLabel();
        }

        internal System.Windows.Forms.LinkLabel LinkLabelExample;

        string[] keywords;
        string[] url_addresses;

        private void InitializeLinkLabel()
        {
            this.LinkLabelExample = new System.Windows.Forms.LinkLabel();
            this.LinkLabelExample.Links.Clear();

            this.LinkLabelExample.Location = new System.Drawing.Point(200, 30);
            this.LinkLabelExample.Name = "ExampleLinks";

            this.LinkLabelExample.Size = new System.Drawing.Size(180, 30);
            this.LinkLabelExample.AutoSize = true;

            this.LinkLabelExample.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            string textString = "Главна уеб страница на УниБИТ.\n" +
                "Подстраница за новини.";

            this.LinkLabelExample.Text = textString;

            this.LinkLabelExample.LinkColor = System.Drawing.Color.Blue;

            this.LinkLabelExample.ActiveLinkColor = System.Drawing.Color.Red;

            this.LinkLabelExample.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel_linkClicked);

            keywords = new string[] { "уеб страница", "новини" };

            foreach (string keyword in keywords)
            {
                this.LinkLabelExample.Links.Add(textString.IndexOf(keyword), keyword.Length);

            }

            url_addresses = new string[] { "www.unibit.bg", "www.unibit.bg/news" };

            this.Controls.Add(this.LinkLabelExample);

        }

        private void LinkLabel_linkClicked(object sender,
                     LinkLabelLinkClickedEventArgs e)
        {
            string url = "";

            switch (LinkLabelExample.Links.IndexOf(e.Link))
            {
                case 0:
                    url = url_addresses[0];
                    break;
                case 1:
                    url = url_addresses[1];
                    break;
            }

            e.Link.Visited = true;

            System.Diagnostics.Process.Start(url);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}