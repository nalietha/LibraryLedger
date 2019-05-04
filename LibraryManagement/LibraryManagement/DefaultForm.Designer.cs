namespace LibraryManagement
{
    partial class DefaultForm
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.pnlCenterPiece = new System.Windows.Forms.Panel();
            this.plExtendedView = new System.Windows.Forms.Panel();
            this.tbISBNDisplay = new System.Windows.Forms.TextBox();
            this.lblISBNDisplay = new System.Windows.Forms.Label();
            this.tbSummaryDisplay = new System.Windows.Forms.TextBox();
            this.lblSummaryDisplay = new System.Windows.Forms.Label();
            this.tbPublisherDisplay = new System.Windows.Forms.TextBox();
            this.lblPublisherDisplay = new System.Windows.Forms.Label();
            this.tbGenreDisplay = new System.Windows.Forms.TextBox();
            this.tbAuthorDisplay = new System.Windows.Forms.TextBox();
            this.tbTitleDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAuthorDisplay = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvBookDisplay = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCenterPiece.SuspendLayout();
            this.plExtendedView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.AcceptsReturn = true;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbSearch.Location = new System.Drawing.Point(721, 14);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(1);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(176, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Search...";
            this.tbSearch.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home Library";
            // 
            // Header
            // 
            this.Header.Controls.Add(this.panel2);
            this.Header.Controls.Add(this.tbSearch);
            this.Header.Controls.Add(this.label1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(1);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(1);
            this.Header.Size = new System.Drawing.Size(898, 70);
            this.Header.TabIndex = 2;
            this.Header.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(706, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 26);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnClearSearch);
            this.panel1.Controls.Add(this.btnSwitch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 479);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 36);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "double click an item name to view details";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(0, 27);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(135, 23);
            this.btnClearSearch.TabIndex = 4;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Visible = false;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(0, 0);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(135, 26);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.Text = "Show Movies";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // pnlCenterPiece
            // 
            this.pnlCenterPiece.AutoSize = true;
            this.pnlCenterPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCenterPiece.Controls.Add(this.plExtendedView);
            this.pnlCenterPiece.Controls.Add(this.lvBookDisplay);
            this.pnlCenterPiece.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterPiece.Location = new System.Drawing.Point(0, 0);
            this.pnlCenterPiece.Margin = new System.Windows.Forms.Padding(1);
            this.pnlCenterPiece.Name = "pnlCenterPiece";
            this.pnlCenterPiece.Size = new System.Drawing.Size(898, 549);
            this.pnlCenterPiece.TabIndex = 3;
            // 
            // plExtendedView
            // 
            this.plExtendedView.BackColor = System.Drawing.Color.White;
            this.plExtendedView.Controls.Add(this.tbISBNDisplay);
            this.plExtendedView.Controls.Add(this.lblISBNDisplay);
            this.plExtendedView.Controls.Add(this.tbSummaryDisplay);
            this.plExtendedView.Controls.Add(this.lblSummaryDisplay);
            this.plExtendedView.Controls.Add(this.tbPublisherDisplay);
            this.plExtendedView.Controls.Add(this.lblPublisherDisplay);
            this.plExtendedView.Controls.Add(this.tbGenreDisplay);
            this.plExtendedView.Controls.Add(this.tbAuthorDisplay);
            this.plExtendedView.Controls.Add(this.tbTitleDisplay);
            this.plExtendedView.Controls.Add(this.label4);
            this.plExtendedView.Controls.Add(this.lblAuthorDisplay);
            this.plExtendedView.Controls.Add(this.lblTitle);
            this.plExtendedView.Controls.Add(this.btnBack);
            this.plExtendedView.Controls.Add(this.pictureBox1);
            this.plExtendedView.Location = new System.Drawing.Point(141, 74);
            this.plExtendedView.Name = "plExtendedView";
            this.plExtendedView.Size = new System.Drawing.Size(609, 425);
            this.plExtendedView.TabIndex = 1;
            this.plExtendedView.Visible = false;
            // 
            // tbISBNDisplay
            // 
            this.tbISBNDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbISBNDisplay.Location = new System.Drawing.Point(7, 217);
            this.tbISBNDisplay.Name = "tbISBNDisplay";
            this.tbISBNDisplay.ReadOnly = true;
            this.tbISBNDisplay.Size = new System.Drawing.Size(205, 13);
            this.tbISBNDisplay.TabIndex = 13;
            // 
            // lblISBNDisplay
            // 
            this.lblISBNDisplay.AutoSize = true;
            this.lblISBNDisplay.Location = new System.Drawing.Point(10, 201);
            this.lblISBNDisplay.Name = "lblISBNDisplay";
            this.lblISBNDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblISBNDisplay.TabIndex = 12;
            this.lblISBNDisplay.Text = "ISBN:";
            // 
            // tbSummaryDisplay
            // 
            this.tbSummaryDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSummaryDisplay.Location = new System.Drawing.Point(10, 264);
            this.tbSummaryDisplay.Multiline = true;
            this.tbSummaryDisplay.Name = "tbSummaryDisplay";
            this.tbSummaryDisplay.ReadOnly = true;
            this.tbSummaryDisplay.Size = new System.Drawing.Size(271, 125);
            this.tbSummaryDisplay.TabIndex = 11;
            this.tbSummaryDisplay.TextChanged += new System.EventHandler(this.tbSummaryDisplay_TextChanged);
            // 
            // lblSummaryDisplay
            // 
            this.lblSummaryDisplay.AutoSize = true;
            this.lblSummaryDisplay.Location = new System.Drawing.Point(7, 248);
            this.lblSummaryDisplay.Name = "lblSummaryDisplay";
            this.lblSummaryDisplay.Size = new System.Drawing.Size(53, 13);
            this.lblSummaryDisplay.TabIndex = 10;
            this.lblSummaryDisplay.Text = "Summary:";
            // 
            // tbPublisherDisplay
            // 
            this.tbPublisherDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPublisherDisplay.Location = new System.Drawing.Point(7, 174);
            this.tbPublisherDisplay.Name = "tbPublisherDisplay";
            this.tbPublisherDisplay.ReadOnly = true;
            this.tbPublisherDisplay.Size = new System.Drawing.Size(205, 13);
            this.tbPublisherDisplay.TabIndex = 9;
            // 
            // lblPublisherDisplay
            // 
            this.lblPublisherDisplay.AutoSize = true;
            this.lblPublisherDisplay.Location = new System.Drawing.Point(7, 158);
            this.lblPublisherDisplay.Name = "lblPublisherDisplay";
            this.lblPublisherDisplay.Size = new System.Drawing.Size(53, 13);
            this.lblPublisherDisplay.TabIndex = 8;
            this.lblPublisherDisplay.Text = "Publisher:";
            // 
            // tbGenreDisplay
            // 
            this.tbGenreDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGenreDisplay.Location = new System.Drawing.Point(9, 133);
            this.tbGenreDisplay.Name = "tbGenreDisplay";
            this.tbGenreDisplay.ReadOnly = true;
            this.tbGenreDisplay.Size = new System.Drawing.Size(205, 13);
            this.tbGenreDisplay.TabIndex = 7;
            // 
            // tbAuthorDisplay
            // 
            this.tbAuthorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAuthorDisplay.Location = new System.Drawing.Point(7, 92);
            this.tbAuthorDisplay.Name = "tbAuthorDisplay";
            this.tbAuthorDisplay.ReadOnly = true;
            this.tbAuthorDisplay.Size = new System.Drawing.Size(208, 13);
            this.tbAuthorDisplay.TabIndex = 6;
            // 
            // tbTitleDisplay
            // 
            this.tbTitleDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitleDisplay.Location = new System.Drawing.Point(7, 49);
            this.tbTitleDisplay.Name = "tbTitleDisplay";
            this.tbTitleDisplay.ReadOnly = true;
            this.tbTitleDisplay.Size = new System.Drawing.Size(208, 13);
            this.tbTitleDisplay.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Genre:";
            // 
            // lblAuthorDisplay
            // 
            this.lblAuthorDisplay.AutoSize = true;
            this.lblAuthorDisplay.Location = new System.Drawing.Point(4, 76);
            this.lblAuthorDisplay.Name = "lblAuthorDisplay";
            this.lblAuthorDisplay.Size = new System.Drawing.Size(41, 13);
            this.lblAuthorDisplay.TabIndex = 3;
            this.lblAuthorDisplay.Text = "Author:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(4, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title: ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(357, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 329);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lvBookDisplay
            // 
            this.lvBookDisplay.Location = new System.Drawing.Point(139, 73);
            this.lvBookDisplay.MultiSelect = false;
            this.lvBookDisplay.Name = "lvBookDisplay";
            this.lvBookDisplay.Size = new System.Drawing.Size(611, 426);
            this.lvBookDisplay.TabIndex = 0;
            this.lvBookDisplay.UseCompatibleStateImageBehavior = false;
            this.lvBookDisplay.View = System.Windows.Forms.View.Details;
            this.lvBookDisplay.DoubleClick += new System.EventHandler(this.lvBookDisplay_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnAddMovie);
            this.panel3.Controls.Add(this.btnAddBook);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(754, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 479);
            this.panel3.TabIndex = 4;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.Black;
            this.btnAddMovie.ForeColor = System.Drawing.Color.White;
            this.btnAddMovie.Location = new System.Drawing.Point(0, 25);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(143, 26);
            this.btnAddMovie.TabIndex = 6;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Black;
            this.btnAddBook.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddBook.Location = new System.Drawing.Point(0, 0);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(143, 26);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(898, 549);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.pnlCenterPiece);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "DefaultForm";
            this.Text = "Home Library";
            this.Load += new System.EventHandler(this.DefaultForm_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCenterPiece.ResumeLayout(false);
            this.plExtendedView.ResumeLayout(false);
            this.plExtendedView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCenterPiece;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ListView lvBookDisplay;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Panel plExtendedView;
        private System.Windows.Forms.Label lblSummaryDisplay;
        private System.Windows.Forms.TextBox tbPublisherDisplay;
        private System.Windows.Forms.Label lblPublisherDisplay;
        private System.Windows.Forms.TextBox tbGenreDisplay;
        private System.Windows.Forms.TextBox tbAuthorDisplay;
        private System.Windows.Forms.TextBox tbTitleDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAuthorDisplay;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbSummaryDisplay;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.TextBox tbISBNDisplay;
        private System.Windows.Forms.Label lblISBNDisplay;
        private System.Windows.Forms.TextBox textBox1;
    }
}

