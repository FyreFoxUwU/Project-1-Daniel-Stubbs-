namespace MovieDatabaseManger
{
    partial class AdminManageUsers
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
            this.AdminPageLabel = new System.Windows.Forms.Label();
            this.SearchUserBox = new System.Windows.Forms.TextBox();
            this.SearchUserBTN = new System.Windows.Forms.Button();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.UNLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BannedBox = new System.Windows.Forms.ComboBox();
            this.RankBox = new System.Windows.Forms.ComboBox();
            this.UserSaveChangesBTN = new System.Windows.Forms.Button();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SHUMoviesLogo
            // 
            this.SHUMoviesLogo.AutoSize = true;
            this.SHUMoviesLogo.BackColor = System.Drawing.SystemColors.Control;
            this.SHUMoviesLogo.Font = new System.Drawing.Font("Segoe UI", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SHUMoviesLogo.ForeColor = System.Drawing.Color.Black;
            this.SHUMoviesLogo.Location = new System.Drawing.Point(-3, -12);
            this.SHUMoviesLogo.Name = "SHUMoviesLogo";
            this.SHUMoviesLogo.Size = new System.Drawing.Size(470, 100);
            this.SHUMoviesLogo.TabIndex = 7;
            this.SHUMoviesLogo.Text = "SHU Movies";
            // 
            // AdminPageLabel
            // 
            this.AdminPageLabel.AutoSize = true;
            this.AdminPageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AdminPageLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point);
            this.AdminPageLabel.ForeColor = System.Drawing.Color.Black;
            this.AdminPageLabel.Location = new System.Drawing.Point(134, 65);
            this.AdminPageLabel.Name = "AdminPageLabel";
            this.AdminPageLabel.Size = new System.Drawing.Size(183, 40);
            this.AdminPageLabel.TabIndex = 8;
            this.AdminPageLabel.Text = "Admin Page";
            // 
            // SearchUserBox
            // 
            this.SearchUserBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchUserBox.Location = new System.Drawing.Point(29, 300);
            this.SearchUserBox.Name = "SearchUserBox";
            this.SearchUserBox.Size = new System.Drawing.Size(424, 44);
            this.SearchUserBox.TabIndex = 58;
            // 
            // SearchUserBTN
            // 
            this.SearchUserBTN.BackColor = System.Drawing.SystemColors.Control;
            this.SearchUserBTN.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchUserBTN.ForeColor = System.Drawing.Color.Black;
            this.SearchUserBTN.Location = new System.Drawing.Point(94, 363);
            this.SearchUserBTN.Name = "SearchUserBTN";
            this.SearchUserBTN.Size = new System.Drawing.Size(239, 74);
            this.SearchUserBTN.TabIndex = 59;
            this.SearchUserBTN.Text = "Search User";
            this.SearchUserBTN.UseVisualStyleBackColor = false;
            this.SearchUserBTN.Click += new System.EventHandler(this.SearchUserBTN_Click);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameBox.Location = new System.Drawing.Point(759, 184);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(324, 44);
            this.UserNameBox.TabIndex = 60;
            // 
            // UNLabel
            // 
            this.UNLabel.AutoSize = true;
            this.UNLabel.BackColor = System.Drawing.Color.Transparent;
            this.UNLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UNLabel.ForeColor = System.Drawing.Color.Black;
            this.UNLabel.Location = new System.Drawing.Point(566, 186);
            this.UNLabel.Name = "UNLabel";
            this.UNLabel.Size = new System.Drawing.Size(187, 42);
            this.UNLabel.TabIndex = 61;
            this.UNLabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(566, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 42);
            this.label1.TabIndex = 63;
            this.label1.Text = "User Banned";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(566, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 42);
            this.label2.TabIndex = 64;
            this.label2.Text = "User Rank";
            // 
            // BannedBox
            // 
            this.BannedBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BannedBox.FormattingEnabled = true;
            this.BannedBox.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.BannedBox.Location = new System.Drawing.Point(843, 285);
            this.BannedBox.Name = "BannedBox";
            this.BannedBox.Size = new System.Drawing.Size(240, 44);
            this.BannedBox.TabIndex = 65;
            // 
            // RankBox
            // 
            this.RankBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RankBox.FormattingEnabled = true;
            this.RankBox.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.RankBox.Location = new System.Drawing.Point(843, 361);
            this.RankBox.Name = "RankBox";
            this.RankBox.Size = new System.Drawing.Size(240, 44);
            this.RankBox.TabIndex = 66;
            // 
            // UserSaveChangesBTN
            // 
            this.UserSaveChangesBTN.BackColor = System.Drawing.SystemColors.Control;
            this.UserSaveChangesBTN.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserSaveChangesBTN.ForeColor = System.Drawing.Color.Black;
            this.UserSaveChangesBTN.Location = new System.Drawing.Point(705, 482);
            this.UserSaveChangesBTN.Name = "UserSaveChangesBTN";
            this.UserSaveChangesBTN.Size = new System.Drawing.Size(239, 74);
            this.UserSaveChangesBTN.TabIndex = 67;
            this.UserSaveChangesBTN.Text = "Save Changes";
            this.UserSaveChangesBTN.UseVisualStyleBackColor = false;
            this.UserSaveChangesBTN.Click += new System.EventHandler(this.UserSaveChangesBTN_Click);
            // 
            // HomeBTN
            // 
            this.HomeBTN.BackColor = System.Drawing.SystemColors.Control;
            this.HomeBTN.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeBTN.ForeColor = System.Drawing.Color.Black;
            this.HomeBTN.Location = new System.Drawing.Point(1013, 12);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(239, 74);
            this.HomeBTN.TabIndex = 68;
            this.HomeBTN.Text = "Home";
            this.HomeBTN.UseVisualStyleBackColor = false;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // AdminManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.HomeBTN);
            this.Controls.Add(this.UserSaveChangesBTN);
            this.Controls.Add(this.RankBox);
            this.Controls.Add(this.BannedBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UNLabel);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.SearchUserBTN);
            this.Controls.Add(this.SearchUserBox);
            this.Controls.Add(this.AdminPageLabel);
            this.Controls.Add(this.SHUMoviesLogo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AdminManageUsers";
            this.Text = "AdminManageUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SHUMoviesLogo;
        private Label AdminPageLabel;
        private TextBox SearchUserBox;
        private Button SearchUserBTN;
        private TextBox UserNameBox;
        private Label UNLabel;
        private Label label1;
        private Label label2;
        private ComboBox BannedBox;
        private ComboBox RankBox;
        private Button UserSaveChangesBTN;
        private Button HomeBTN;
    }
}