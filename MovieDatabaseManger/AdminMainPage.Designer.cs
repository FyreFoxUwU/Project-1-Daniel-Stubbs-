namespace MovieDatabaseManger
{
    partial class AdminMainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.MoviesButton = new System.Windows.Forms.Button();
            this.SearchMoviesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SHUMoviesLogo
            // 
            this.SHUMoviesLogo.AutoSize = true;
            this.SHUMoviesLogo.BackColor = System.Drawing.SystemColors.Control;
            this.SHUMoviesLogo.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SHUMoviesLogo.ForeColor = System.Drawing.Color.Black;
            this.SHUMoviesLogo.Location = new System.Drawing.Point(318, 20);
            this.SHUMoviesLogo.Name = "SHUMoviesLogo";
            this.SHUMoviesLogo.Size = new System.Drawing.Size(601, 128);
            this.SHUMoviesLogo.TabIndex = 1;
            this.SHUMoviesLogo.Text = "SHU Movies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(517, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Black;
            this.LogOutButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(1056, 20);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(196, 64);
            this.LogOutButton.TabIndex = 17;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // MoviesButton
            // 
            this.MoviesButton.BackColor = System.Drawing.SystemColors.Control;
            this.MoviesButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoviesButton.ForeColor = System.Drawing.Color.Black;
            this.MoviesButton.Location = new System.Drawing.Point(162, 228);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.Size = new System.Drawing.Size(272, 99);
            this.MoviesButton.TabIndex = 18;
            this.MoviesButton.Text = "View Movies";
            this.MoviesButton.UseVisualStyleBackColor = false;
            this.MoviesButton.Click += new System.EventHandler(this.MoviesButton_Click);
            // 
            // SearchMoviesButton
            // 
            this.SearchMoviesButton.BackColor = System.Drawing.SystemColors.Control;
            this.SearchMoviesButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchMoviesButton.ForeColor = System.Drawing.Color.Black;
            this.SearchMoviesButton.Location = new System.Drawing.Point(162, 428);
            this.SearchMoviesButton.Name = "SearchMoviesButton";
            this.SearchMoviesButton.Size = new System.Drawing.Size(272, 99);
            this.SearchMoviesButton.TabIndex = 19;
            this.SearchMoviesButton.Text = "Search Movies";
            this.SearchMoviesButton.UseVisualStyleBackColor = false;
            this.SearchMoviesButton.Click += new System.EventHandler(this.SearchMoviesButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(785, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 99);
            this.button1.TabIndex = 20;
            this.button1.Text = "View Requested Movies";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(785, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 99);
            this.button2.TabIndex = 21;
            this.button2.Text = "Manage Users";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchMoviesButton);
            this.Controls.Add(this.MoviesButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SHUMoviesLogo);
            this.Name = "AdminMainPage";
            this.Text = "AdminMainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SHUMoviesLogo;
        private Label label1;
        private Button LogOutButton;
        private Button MoviesButton;
        private Button SearchMoviesButton;
        private Button button1;
        private Button button2;
    }
}