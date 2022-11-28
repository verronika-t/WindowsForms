namespace VSP_46514z_10
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxPickDate = new System.Windows.Forms.TextBox();
            this.buttonDate = new System.Windows.Forms.Button();
            this.textBoxPickPlace = new System.Windows.Forms.TextBox();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.buttonPlace = new System.Windows.Forms.Button();
            this.textBoxResultPlace = new System.Windows.Forms.TextBox();
            this.textBoxResultDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(28, 77);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2022, 11, 18, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(502, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 239);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPickDate
            // 
            this.textBoxPickDate.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBoxPickDate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPickDate.Location = new System.Drawing.Point(28, 30);
            this.textBoxPickDate.Name = "textBoxPickDate";
            this.textBoxPickDate.ReadOnly = true;
            this.textBoxPickDate.Size = new System.Drawing.Size(389, 35);
            this.textBoxPickDate.TabIndex = 2;
            this.textBoxPickDate.Text = "Задаване дата за работна среща:";
            // 
            // buttonDate
            // 
            this.buttonDate.Location = new System.Drawing.Point(28, 251);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(124, 56);
            this.buttonDate.TabIndex = 3;
            this.buttonDate.Text = "Избери";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // textBoxPickPlace
            // 
            this.textBoxPickPlace.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBoxPickPlace.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPickPlace.Location = new System.Drawing.Point(28, 313);
            this.textBoxPickPlace.Name = "textBoxPickPlace";
            this.textBoxPickPlace.ReadOnly = true;
            this.textBoxPickPlace.Size = new System.Drawing.Size(389, 35);
            this.textBoxPickPlace.TabIndex = 4;
            this.textBoxPickPlace.Text = "Задаване място на срещата:";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(28, 366);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(220, 23);
            this.textBoxPlace.TabIndex = 5;
            this.textBoxPlace.Text = "Моля въведи...";
            // 
            // buttonPlace
            // 
            this.buttonPlace.Location = new System.Drawing.Point(28, 395);
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.Size = new System.Drawing.Size(138, 51);
            this.buttonPlace.TabIndex = 6;
            this.buttonPlace.Text = "Избери";
            this.buttonPlace.UseVisualStyleBackColor = true;
            this.buttonPlace.Click += new System.EventHandler(this.buttonPlace_Click);
            // 
            // textBoxResultPlace
            // 
            this.textBoxResultPlace.Location = new System.Drawing.Point(502, 366);
            this.textBoxResultPlace.Name = "textBoxResultPlace";
            this.textBoxResultPlace.ReadOnly = true;
            this.textBoxResultPlace.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxResultPlace.Size = new System.Drawing.Size(216, 23);
            this.textBoxResultPlace.TabIndex = 7;
            // 
            // textBoxResultDate
            // 
            this.textBoxResultDate.Location = new System.Drawing.Point(502, 92);
            this.textBoxResultDate.Name = "textBoxResultDate";
            this.textBoxResultDate.Size = new System.Drawing.Size(216, 23);
            this.textBoxResultDate.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.textBoxResultDate);
            this.Controls.Add(this.textBoxResultPlace);
            this.Controls.Add(this.buttonPlace);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.textBoxPickPlace);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.textBoxPickDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.MaximumSize = new System.Drawing.Size(816, 512);
            this.MinimumSize = new System.Drawing.Size(816, 512);
            this.Name = "Form1";
            this.Text = "Работна среща";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private PictureBox pictureBox1;
        private TextBox textBoxPickDate;
        private Button buttonDate;
        private TextBox textBoxPickPlace;
        private TextBox textBoxPlace;
        private Button buttonPlace;
        private TextBox textBoxResultPlace;
        private TextBox textBoxResultDate;
    }
}