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
    public partial class RequestMovies : Form
    {
        public static string posterurl;
        public RequestMovies()
        {
            InitializeComponent();
        }

        
        private async void IMDBSearchBTN_Click(object sender, EventArgs e)
        {
            string IMDBLink = IMDBSearchBox.Text;

            string[] IMDBLinkSplit = IMDBLink.Split('/');

            var apiLib = new ApiLib("k_74l37n7e");

            try
            {
                var IMDBResult = await apiLib.TitleAsync(IMDBLinkSplit[4]);

                MovieNameBox.Text = IMDBResult.Title;
                MovieReleaseBox.Text = IMDBResult.ReleaseDate;
                MovieDescBox.Text = IMDBResult.Plot;
                StarsTextBox.Text = IMDBResult.Stars;
                DirectorsTextBox.Text = IMDBResult.Directors;
                RatingTextBox.Text = IMDBResult.IMDbRating;

                AgeRatingDrop.SelectedIndex = AgeRatingDrop.FindStringExact(IMDBResult.ContentRating);

                posterurl = IMDBResult.Image;
                MoviePosterBox.LoadAsync(IMDBResult.Image);
                MoviePosterBox.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            catch
            {
                DialogResult res = MessageBox.Show("Please enter a valid IMDB link. i.e https://www.imdb.com/title/tt2948356/ ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        public string linuser { get; set; }
        private void RequestMovieButton_Click(object sender, EventArgs e)
        {
            var me = new UserMainPage();
            me.Show();
            this.Hide();
        }

    } 
}
