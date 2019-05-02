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
            this.btnSwitch = new System.Windows.Forms.Button();
            this.pnlCenterPiece = new System.Windows.Forms.Panel();
            this.lvBookDisplay = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.plExtendedView = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCenterPiece.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnSwitch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 429);
            this.panel1.TabIndex = 0;
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
            this.pnlCenterPiece.Size = new System.Drawing.Size(898, 499);
            this.pnlCenterPiece.TabIndex = 3;
            // 
            // lvBookDisplay
            // 
            this.lvBookDisplay.Location = new System.Drawing.Point(139, 73);
            this.lvBookDisplay.Name = "lvBookDisplay";
            this.lvBookDisplay.Size = new System.Drawing.Size(611, 426);
            this.lvBookDisplay.TabIndex = 0;
            this.lvBookDisplay.UseCompatibleStateImageBehavior = false;
            this.lvBookDisplay.View = System.Windows.Forms.View.Details;
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
            this.panel3.Size = new System.Drawing.Size(144, 429);
            this.panel3.TabIndex = 4;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.Black;
            this.btnAddMovie.ForeColor = System.Drawing.Color.WhiteSmoke;
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
            // plExtendedView
            // 
            this.plExtendedView.Location = new System.Drawing.Point(141, 74);
            this.plExtendedView.Name = "plExtendedView";
            this.plExtendedView.Size = new System.Drawing.Size(609, 425);
            this.plExtendedView.TabIndex = 1;
            this.plExtendedView.Visible = false;
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(898, 499);
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
            this.pnlCenterPiece.ResumeLayout(false);
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
    }
}

