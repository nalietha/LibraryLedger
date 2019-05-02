namespace LibraryManagement
{
    partial class BookEnter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCoverImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSummary = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title *";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(56, 12);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(1);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(145, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Publisher";
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(56, 59);
            this.tbISBN.Margin = new System.Windows.Forms.Padding(1);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(145, 20);
            this.tbISBN.TabIndex = 5;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(56, 34);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(1);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(145, 20);
            this.tbAuthor.TabIndex = 5;
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(56, 82);
            this.tbPublisher.Margin = new System.Windows.Forms.Padding(1);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(145, 20);
            this.tbPublisher.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(327, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 268);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCoverImage
            // 
            this.btnCoverImage.Location = new System.Drawing.Point(327, 300);
            this.btnCoverImage.Margin = new System.Windows.Forms.Padding(1);
            this.btnCoverImage.Name = "btnCoverImage";
            this.btnCoverImage.Size = new System.Drawing.Size(104, 26);
            this.btnCoverImage.TabIndex = 8;
            this.btnCoverImage.Text = "Import Cover Image";
            this.btnCoverImage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Summary";
            // 
            // tbSummary
            // 
            this.tbSummary.Location = new System.Drawing.Point(56, 137);
            this.tbSummary.Margin = new System.Windows.Forms.Padding(1);
            this.tbSummary.Multiline = true;
            this.tbSummary.Name = "tbSummary";
            this.tbSummary.Size = new System.Drawing.Size(265, 146);
            this.tbSummary.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(187, 300);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 27);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(256, 300);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 27);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "* Required";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Genre";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "Action and adventure\t",
            "Alternate history\t",
            "Anthology\t",
            "Art",
            "Autobiography",
            "Biography",
            "Book review",
            "Chick lit\t",
            "Children\'s\t",
            "Comic book\t",
            "Coming-of-age\t",
            "Cookbook",
            "Crime\t",
            "Diary",
            "Dictionary",
            "Drama\t",
            "Encyclopedia",
            "Fairytale\t",
            "Fantasy\tHistory",
            "Graphic novel\t",
            "Guide",
            "Health",
            "Historical fiction\t",
            "Horror\t",
            "Journal",
            "Math",
            "Memoir",
            "Mystery\tPrayer",
            "Paranormal romance\t",
            "Picture book\t",
            "Poetry\t",
            "Political thriller\t",
            "Religion, spirituality, and new age",
            "Review",
            "Romance\t",
            "Satire\t",
            "Science",
            "Science fiction\t",
            "Self help",
            "Short story\t",
            "Suspense\t",
            "Textbook",
            "Thriller\t",
            "Travel",
            "True crime",
            "Young adult"});
            this.cbGenre.Location = new System.Drawing.Point(56, 109);
            this.cbGenre.Margin = new System.Windows.Forms.Padding(1);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(145, 21);
            this.cbGenre.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Quick Populate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookEnter
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(557, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbSummary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCoverImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookEnter";
            this.Text = "BookEnter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookEnter_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCoverImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSummary;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Button button1;
    }
}