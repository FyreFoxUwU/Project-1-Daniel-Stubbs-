namespace MovieDatabaseManger
{
    partial class SearchMovies
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
            this.SHUMoviesLogo = new System.Windows.Forms.Label();
            this.SearchUserBox = new System.Windows.Forms.TextBox();
            this.SearchUserBTN = new System.Windows.Forms.Button();
            this.MovieName = new System.Windows.Forms.TextBox();
            this.MovieDate = new System.Windows.Forms.TextBox();
            this.MovieNameLabel = new System.Windows.Forms.Label();
            this.MovieGenreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MovieDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.StarsLabel = new System.Windows.Forms.Label();
            this.MovieStars = new System.Windows.Forms.TextBox();
            this.DirectorsLabel = new System.Windows.Forms.Label();
            this.MovieDir = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.MovieRating = new System.Windows.Forms.TextBox();
            this.AgeRatingLabel = new System.Windows.Forms.Label();
            this.IMDBLinkLabel = new System.Windows.Forms.Label();
            this.MovieIMDB = new System.Windows.Forms.TextBox();
            this.WatchBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MovieAgeBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // SHUMoviesLogo
            // 
            this.SHUMoviesLogo.AutoSize = true;
            this.SHUMoviesLogo.BackColor = System.Drawing.SystemColors.Control;
            this.SHUMoviesLogo.Font = new System.Drawing.Font("Segoe UI", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SHUMoviesLogo.ForeColor = System.Drawing.Color.Black;
            this.SHUMoviesLogo.Location = new System.Drawing.Point(12, 9);
            this.SHUMoviesLogo.Name = "SHUMoviesLogo";
            this.SHUMoviesLogo.Size = new System.Drawing.Size(470, 100);
            this.SHUMoviesLogo.TabIndex = 4;
            this.SHUMoviesLogo.Text = "SHU Movies";
            // 
            // SearchUserBox
            // 
            this.SearchUserBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchUserBox.Location = new System.Drawing.Point(34, 125);
            this.SearchUserBox.Name = "SearchUserBox";
            this.SearchUserBox.Size = new System.Drawing.Size(424, 44);
            this.SearchUserBox.TabIndex = 59;
            // 
            // SearchUserBTN
            // 
            this.SearchUserBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SearchUserBTN.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchUserBTN.ForeColor = System.Drawing.Color.Black;
            this.SearchUserBTN.Location = new System.Drawing.Point(49, 189);
            this.SearchUserBTN.Name = "SearchUserBTN";
            this.SearchUserBTN.Size = new System.Drawing.Size(239, 74);
            this.SearchUserBTN.TabIndex = 60;
            this.SearchUserBTN.Text = "Search Movie";
            this.SearchUserBTN.UseVisualStyleBackColor = false;
            this.SearchUserBTN.Click += new System.EventHandler(this.SearchUserBTN_Click);
            // 
            // MovieName
            // 
            this.MovieName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieName.Location = new System.Drawing.Point(797, 74);
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            this.MovieName.Size = new System.Drawing.Size(452, 44);
            this.MovieName.TabIndex = 102;
            // 
            // MovieDate
            // 
            this.MovieDate.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieDate.Location = new System.Drawing.Point(797, 305);
            this.MovieDate.Name = "MovieDate";
            this.MovieDate.ReadOnly = true;
            this.MovieDate.Size = new System.Drawing.Size(452, 44);
            this.MovieDate.TabIndex = 103;
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MovieNameLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieNameLabel.ForeColor = System.Drawing.Color.Black;
            this.MovieNameLabel.Location = new System.Drawing.Point(569, 74);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(222, 42);
            this.MovieNameLabel.TabIndex = 104;
            this.MovieNameLabel.Text = "Movie Name";
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MovieGenreLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieGenreLabel.ForeColor = System.Drawing.Color.Black;
            this.MovieGenreLabel.Location = new System.Drawing.Point(544, 303);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(237, 42);
            this.MovieGenreLabel.TabIndex = 105;
            this.MovieGenreLabel.Text = "Release Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(590, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 42);
            this.label3.TabIndex = 106;
            this.label3.Text = "Description";
            // 
            // MovieDesc
            // 
            this.MovieDesc.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieDesc.Location = new System.Drawing.Point(797, 141);
            this.MovieDesc.Multiline = true;
            this.MovieDesc.Name = "MovieDesc";
            this.MovieDesc.ReadOnly = true;
            this.MovieDesc.Size = new System.Drawing.Size(452, 139);
            this.MovieDesc.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(368, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 42);
            this.label2.TabIndex = 108;
            this.label2.Text = "Poster";
            // 
            // MoviePoster
            // 
            this.MoviePoster.Location = new System.Drawing.Point(317, 280);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(221, 337);
            this.MoviePoster.TabIndex = 116;
            this.MoviePoster.TabStop = false;
            // 
            // StarsLabel
            // 
            this.StarsLabel.AutoSize = true;
            this.StarsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.StarsLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StarsLabel.ForeColor = System.Drawing.Color.Black;
            this.StarsLabel.Location = new System.Drawing.Point(678, 374);
            this.StarsLabel.Name = "StarsLabel";
            this.StarsLabel.Size = new System.Drawing.Size(103, 42);
            this.StarsLabel.TabIndex = 109;
            this.StarsLabel.Text = "Stars";
            // 
            // MovieStars
            // 
            this.MovieStars.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieStars.Location = new System.Drawing.Point(797, 376);
            this.MovieStars.Name = "MovieStars";
            this.MovieStars.ReadOnly = true;
            this.MovieStars.Size = new System.Drawing.Size(452, 44);
            this.MovieStars.TabIndex = 110;
            // 
            // DirectorsLabel
            // 
            this.DirectorsLabel.AutoSize = true;
            this.DirectorsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DirectorsLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DirectorsLabel.ForeColor = System.Drawing.Color.Black;
            this.DirectorsLabel.Location = new System.Drawing.Point(617, 455);
            this.DirectorsLabel.Name = "DirectorsLabel";
            this.DirectorsLabel.Size = new System.Drawing.Size(164, 42);
            this.DirectorsLabel.TabIndex = 111;
            this.DirectorsLabel.Text = "Directors";
            // 
            // MovieDir
            // 
            this.MovieDir.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieDir.Location = new System.Drawing.Point(797, 455);
            this.MovieDir.Name = "MovieDir";
            this.MovieDir.ReadOnly = true;
            this.MovieDir.Size = new System.Drawing.Size(452, 44);
            this.MovieDir.TabIndex = 112;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.RatingLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RatingLabel.ForeColor = System.Drawing.Color.Black;
            this.RatingLabel.Location = new System.Drawing.Point(667, 516);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(124, 42);
            this.RatingLabel.TabIndex = 113;
            this.RatingLabel.Text = "Rating";
            // 
            // MovieRating
            // 
            this.MovieRating.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieRating.Location = new System.Drawing.Point(797, 518);
            this.MovieRating.Name = "MovieRating";
            this.MovieRating.ReadOnly = true;
            this.MovieRating.Size = new System.Drawing.Size(72, 44);
            this.MovieRating.TabIndex = 114;
            // 
            // AgeRatingLabel
            // 
            this.AgeRatingLabel.AutoSize = true;
            this.AgeRatingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AgeRatingLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeRatingLabel.ForeColor = System.Drawing.Color.Black;
            this.AgeRatingLabel.Location = new System.Drawing.Point(885, 520);
            this.AgeRatingLabel.Name = "AgeRatingLabel";
            this.AgeRatingLabel.Size = new System.Drawing.Size(200, 42);
            this.AgeRatingLabel.TabIndex = 115;
            this.AgeRatingLabel.Text = "Age Rating";
            // 
            // IMDBLinkLabel
            // 
            this.IMDBLinkLabel.AutoSize = true;
            this.IMDBLinkLabel.BackColor = System.Drawing.SystemColors.Control;
            this.IMDBLinkLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IMDBLinkLabel.ForeColor = System.Drawing.Color.Black;
            this.IMDBLinkLabel.Location = new System.Drawing.Point(603, 594);
            this.IMDBLinkLabel.Name = "IMDBLinkLabel";
            this.IMDBLinkLabel.Size = new System.Drawing.Size(188, 42);
            this.IMDBLinkLabel.TabIndex = 117;
            this.IMDBLinkLabel.Text = "IMDB Link";
            // 
            // MovieIMDB
            // 
            this.MovieIMDB.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieIMDB.Location = new System.Drawing.Point(797, 592);
            this.MovieIMDB.Name = "MovieIMDB";
            this.MovieIMDB.ReadOnly = true;
            this.MovieIMDB.Size = new System.Drawing.Size(452, 44);
            this.MovieIMDB.TabIndex = 118;
            // 
            // WatchBTN
            // 
            this.WatchBTN.BackColor = System.Drawing.SystemColors.Control;
            this.WatchBTN.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WatchBTN.ForeColor = System.Drawing.Color.Black;
            this.WatchBTN.Location = new System.Drawing.Point(49, 455);
            this.WatchBTN.Name = "WatchBTN";
            this.WatchBTN.Size = new System.Drawing.Size(239, 74);
            this.WatchBTN.TabIndex = 119;
            this.WatchBTN.Text = "Watch Now";
            this.WatchBTN.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(49, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 74);
            this.button1.TabIndex = 121;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MovieAgeBox
            // 
            this.MovieAgeBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieAgeBox.Location = new System.Drawing.Point(1091, 518);
            this.MovieAgeBox.Name = "MovieAgeBox";
            this.MovieAgeBox.ReadOnly = true;
            this.MovieAgeBox.Size = new System.Drawing.Size(158, 44);
            this.MovieAgeBox.TabIndex = 122;
            // 
            // SearchMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MovieAgeBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WatchBTN);
            this.Controls.Add(this.MovieIMDB);
            this.Controls.Add(this.IMDBLinkLabel);
            this.Controls.Add(this.AgeRatingLabel);
            this.Controls.Add(this.MovieRating);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.MovieDir);
            this.Controls.Add(this.DirectorsLabel);
            this.Controls.Add(this.MovieStars);
            this.Controls.Add(this.StarsLabel);
            this.Controls.Add(this.MoviePoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MovieDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MovieGenreLabel);
            this.Controls.Add(this.MovieNameLabel);
            this.Controls.Add(this.MovieDate);
            this.Controls.Add(this.MovieName);
            this.Controls.Add(this.SearchUserBTN);
            this.Controls.Add(this.SearchUserBox);
            this.Controls.Add(this.SHUMoviesLogo);
            this.Name = "SearchMovies";
            this.Text = "SearchMovies";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SHUMoviesLogo;
        private TextBox SearchUserBox;
        private Button SearchUserBTN;
        private TextBox MovieName;
        private TextBox MovieDate;
        private Label MovieNameLabel;
        private Label MovieGenreLabel;
        private Label label3;
        private TextBox MovieDesc;
        private Label label2;
        private PictureBox MoviePoster;
        private Label StarsLabel;
        private TextBox MovieStars;
        private Label DirectorsLabel;
        private TextBox MovieDir;
        private Label RatingLabel;
        private TextBox MovieRating;
        private Label AgeRatingLabel;
        private Label IMDBLinkLabel;
        private TextBox MovieIMDB;
        private Button WatchBTN;
        private Button button1;
        private TextBox MovieAgeBox;
    }
}