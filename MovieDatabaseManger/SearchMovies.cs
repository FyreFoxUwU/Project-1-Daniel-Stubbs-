using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace MovieDatabaseManger
{
    public partial class SearchMovies : Form
    {
        public SearchMovies()
        {
            InitializeComponent();
        }

        private void SearchUserBTN_Click(object sender, EventArgs e)
        {
            var conn = new SqliteConnection("Data Source=MovieDatabase.db; Pooling=False");
            conn.Open();

            string Movies = "SELECT * FROM Movies WHERE Movie_Name LIKE '%" + SearchUserBox.Text + "%' LIMIT 1";
            using var cmd = new SqliteCommand(Movies, conn);

            using SqliteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                MovieName.Text = rdr.GetString(1);
                MovieDesc.Text = rdr.GetString(2);
                MovieDate.Text = rdr.GetString(3);


                MoviePoster.LoadAsync(rdr.GetString(4));
                MoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;

                MovieStars.Text = rdr.GetString(5);
                MovieDir.Text = rdr.GetString(6);
                MovieRating.Text = rdr.GetString(7);

                string[] AgeRating = { "U", "PG", "12A", "12", "15", "18" };
                MovieAgeBox.Text = AgeRating[rdr.GetInt32(8)];
                MovieIMDB.Text = rdr.GetString(9);

            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var me = new UserMainPage();
            me.Show();
            this.Hide();
        }
    }
}
