using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMDbApiLib;
using Microsoft.Data.Sqlite;

namespace MovieDatabaseManger
{
    public partial class AdminRequestedMovies : Form
    {
        public static string reqposterurl;
        public static int reqid;
        public AdminRequestedMovies()
        {
            InitializeComponent();
        }
        private void updateRequestedMovies()
        {
            var conn = new SqliteConnection("Data Source=MovieDatabase.db; Pooling=False");
            conn.Open();

            string ReqMovies = "SELECT * FROM ReqMovie ORDER BY ReqMovie_ID LIMIT 1";
            using var cmd = new SqliteCommand(ReqMovies, conn);

            using SqliteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                reqid = rdr.GetInt32(0);
                RMID.Text = "Movie ID: " + rdr.GetInt32(0).ToString();
                ARName.Text = rdr.GetString(1);
                ARDate.Text = rdr.GetString(2);
                ARDesc.Text = rdr.GetString(3);

                reqposterurl = rdr.GetString(4);
                ARPoster.LoadAsync(rdr.GetString(4));
                ARPoster.SizeMode = PictureBoxSizeMode.StretchImage;

                ARStars.Text = rdr.GetString(5);
                ARDir.Text = rdr.GetString(6);
                ARRating.Text = rdr.GetString(7);
                ARAge.Text = rdr.GetString(8);
                IMDBTextBox.Text = rdr.GetString(9);
                ARUserBox.Text = rdr.GetString(10);

            }
        }
        private void AdminRequestedMovies_Load(object sender, EventArgs e)
        {
            updateRequestedMovies();
        }

        private void DeleteMovieBTN_Click(object sender, EventArgs e)
        {
            var conn = new SqliteConnection("Data Source=MovieDatabase.db; Pooling=False");
            conn.Open();

            var delcommand = conn.CreateCommand();
            delcommand.CommandText = @"DELETE FROM ReqMovie WHERE ReqMovie_ID =" + reqid;
            delcommand.Prepare();
            delcommand.ExecuteNonQuery();
            conn.Close();
            updateRequestedMovies();
        }

        private void AddMovieBTN_Click(object sender, EventArgs e)
        {
            var conn = new SqliteConnection("Data Source=MovieDatabase.db; Pooling=False");
            conn.Open();

            var command = conn.CreateCommand();
            command.CommandText = @"INSERT INTO Movies(Movie_Name, Movie_Description, Movie_RelDate, Movie_Poster, Movie_Stars, Movie_Dir, Movie_Rating, Movie_AgeRating, Movie_IMDB) VALUES(@Movie_Name, @Movie_Description, @Movie_RelDate, @Movie_Poster, @Movie_Stars, @Movie_Dir, @Movie_Rating, @Movie_AgeRating, @Movie_IMDB)";
            command.Parameters.AddWithValue("@Movie_Name", ARName.Text);
            command.Parameters.AddWithValue("@Movie_Description", ARDesc.Text);
            command.Parameters.AddWithValue("@Movie_RelDate", ARDate.Text);
            command.Parameters.AddWithValue("@Movie_Poster", reqposterurl);
            command.Parameters.AddWithValue("@Movie_Stars", ARStars.Text);
            command.Parameters.AddWithValue("@Movie_Dir", ARDir.Text);
            command.Parameters.AddWithValue("@Movie_Rating", ARRating.Text);
            command.Parameters.AddWithValue("@Movie_AgeRating", ARAge.Text);
            command.Parameters.AddWithValue("@Movie_IMDB", IMDBTextBox.Text);

            command.Prepare();
            command.ExecuteNonQuery();

            var delcommand = conn.CreateCommand();
            delcommand.CommandText = @"DELETE FROM ReqMovie WHERE ReqMovie_ID =" + reqid;
            delcommand.Prepare();
            delcommand.ExecuteNonQuery();
            conn.Close();
            updateRequestedMovies();
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            var me = new AdminMainPage();
            me.Show();
            this.Hide();
        }
    }
}
