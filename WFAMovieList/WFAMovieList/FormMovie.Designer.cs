namespace WFAMovieList
{
    partial class FormMovie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxOffice = new System.Windows.Forms.TextBox();
            this.txtImdb = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.dgvMovieDetails = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cmbGenre);
            this.panel1.Controls.Add(this.dtpReleaseDate);
            this.panel1.Controls.Add(this.txtBoxOffice);
            this.panel1.Controls.Add(this.txtImdb);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.txtMovieId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnShowDetails);
            this.panel1.Controls.Add(this.dgvMovieDetails);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 643);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(517, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 54);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "action",
            "comedy",
            "drama",
            "thriller",
            "history",
            "adventure"});
            this.cmbGenre.Location = new System.Drawing.Point(191, 163);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(210, 28);
            this.cmbGenre.TabIndex = 19;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.CustomFormat = "yyyy-MM-dd";
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReleaseDate.Location = new System.Drawing.Point(191, 132);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(210, 26);
            this.dtpReleaseDate.TabIndex = 18;
            // 
            // txtBoxOffice
            // 
            this.txtBoxOffice.Location = new System.Drawing.Point(191, 99);
            this.txtBoxOffice.Name = "txtBoxOffice";
            this.txtBoxOffice.Size = new System.Drawing.Size(210, 26);
            this.txtBoxOffice.TabIndex = 15;
            // 
            // txtImdb
            // 
            this.txtImdb.Location = new System.Drawing.Point(191, 67);
            this.txtImdb.Name = "txtImdb";
            this.txtImdb.Size = new System.Drawing.Size(210, 26);
            this.txtImdb.TabIndex = 14;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(191, 35);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(210, 26);
            this.txtTitle.TabIndex = 13;
            // 
            // txtMovieId
            // 
            this.txtMovieId.Location = new System.Drawing.Point(191, 3);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(210, 26);
            this.txtMovieId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(32, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(32, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Release Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(32, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Box Office";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(32, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "IMDB Rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Movie Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Movie ID";
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(474, 260);
            this.txtAutoSearch.Multiline = true;
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(210, 38);
            this.txtAutoSearch.TabIndex = 4;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(239, 260);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 266);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 38);
            this.txtSearch.TabIndex = 2;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(818, 260);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(159, 38);
            this.btnShowDetails.TabIndex = 1;
            this.btnShowDetails.Text = "Show Details>>";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // dgvMovieDetails
            // 
            this.dgvMovieDetails.AllowUserToAddRows = false;
            this.dgvMovieDetails.AllowUserToDeleteRows = false;
            this.dgvMovieDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.id,
            this.imdb,
            this.income,
            this.releasedate,
            this.genre});
            this.dgvMovieDetails.Location = new System.Drawing.Point(3, 304);
            this.dgvMovieDetails.Name = "dgvMovieDetails";
            this.dgvMovieDetails.ReadOnly = true;
            this.dgvMovieDetails.RowHeadersWidth = 62;
            this.dgvMovieDetails.RowTemplate.Height = 28;
            this.dgvMovieDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovieDetails.Size = new System.Drawing.Size(986, 336);
            this.dgvMovieDetails.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(517, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 54);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Movie Title";
            this.title.MinimumWidth = 8;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Movie ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // imdb
            // 
            this.imdb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imdb.DataPropertyName = "imdb";
            this.imdb.HeaderText = "IMDB";
            this.imdb.MinimumWidth = 8;
            this.imdb.Name = "imdb";
            this.imdb.ReadOnly = true;
            // 
            // income
            // 
            this.income.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.income.DataPropertyName = "income";
            this.income.HeaderText = "Box Office";
            this.income.MinimumWidth = 8;
            this.income.Name = "income";
            this.income.ReadOnly = true;
            // 
            // releasedate
            // 
            this.releasedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.releasedate.DataPropertyName = "releasedate";
            this.releasedate.HeaderText = "Release Date";
            this.releasedate.MinimumWidth = 8;
            this.releasedate.Name = "releasedate";
            this.releasedate.ReadOnly = true;
            // 
            // genre
            // 
            this.genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genre.DataPropertyName = "genre";
            this.genre.HeaderText = "Genre";
            this.genre.MinimumWidth = 8;
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            // 
            // FormMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 666);
            this.Controls.Add(this.panel1);
            this.Name = "FormMovie";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMovieDetails;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.TextBox txtBoxOffice;
        private System.Windows.Forms.TextBox txtImdb;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn income;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
    }
}

