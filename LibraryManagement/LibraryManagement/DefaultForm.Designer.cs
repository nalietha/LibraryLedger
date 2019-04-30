﻿namespace LibraryManagement
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
            this.pnlCategoryAdd = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCenterPiece = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCategoryAdd.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.AcceptsReturn = true;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbSearch.Location = new System.Drawing.Point(669, 14);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(176, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Search...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
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
            this.Header.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Header.Size = new System.Drawing.Size(846, 70);
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
            this.panel1.Controls.Add(this.pnlCategoryAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 388);
            this.panel1.TabIndex = 0;
            // 
            // pnlCategoryAdd
            // 
            this.pnlCategoryAdd.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnlCategoryAdd.Controls.Add(this.label5);
            this.pnlCategoryAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCategoryAdd.Location = new System.Drawing.Point(0, 1);
            this.pnlCategoryAdd.Name = "pnlCategoryAdd";
            this.pnlCategoryAdd.Size = new System.Drawing.Size(135, 25);
            this.pnlCategoryAdd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Add Category";
            // 
            // pnlCenterPiece
            // 
            this.pnlCenterPiece.AutoSize = true;
            this.pnlCenterPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCenterPiece.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterPiece.Location = new System.Drawing.Point(0, 0);
            this.pnlCenterPiece.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlCenterPiece.Name = "pnlCenterPiece";
            this.pnlCenterPiece.Size = new System.Drawing.Size(846, 458);
            this.pnlCenterPiece.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnAddMovie);
            this.panel3.Controls.Add(this.btnAddBook);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(702, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 388);
            this.panel3.TabIndex = 4;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.Black;
            this.btnAddMovie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddMovie.Location = new System.Drawing.Point(0, 25);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.ClientSize = new System.Drawing.Size(846, 458);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.pnlCenterPiece);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "DefaultForm";
            this.Text = "HomeLibrary";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlCategoryAdd.ResumeLayout(false);
            this.pnlCategoryAdd.PerformLayout();
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
        private System.Windows.Forms.Panel pnlCategoryAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnAddBook;
    }
}

