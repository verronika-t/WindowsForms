namespace VSP_46514z_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.buttonBulgarian = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnglish.Image")));
            this.buttonEnglish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnglish.Location = new System.Drawing.Point(50, 54);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(110, 35);
            this.buttonEnglish.TabIndex = 0;
            this.buttonEnglish.Text = "English";
            this.buttonEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEnglish.UseVisualStyleBackColor = true;
            this.buttonEnglish.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBulgarian
            // 
            this.buttonBulgarian.Image = ((System.Drawing.Image)(resources.GetObject("buttonBulgarian.Image")));
            this.buttonBulgarian.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonBulgarian.Location = new System.Drawing.Point(218, 54);
            this.buttonBulgarian.Name = "buttonBulgarian";
            this.buttonBulgarian.Size = new System.Drawing.Size(110, 35);
            this.buttonBulgarian.TabIndex = 1;
            this.buttonBulgarian.Text = "Bulgarian";
            this.buttonBulgarian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBulgarian.UseVisualStyleBackColor = true;
            this.buttonBulgarian.Click += new System.EventHandler(this.buttonBulgarian_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(136, 119);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(110, 35);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 181);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonBulgarian);
            this.Controls.Add(this.buttonEnglish);
            this.Name = "Form1";
            this.Text = "English";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEnglish;
        private Button buttonBulgarian;
        private Button buttonOK;
    }
}