using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseManger
{
    public partial class UserMainPage : Form
    {
        public UserMainPage()
        {
            InitializeComponent();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var me = new Form1();
            me.Show();
            this.Hide();
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            var me = new UserViewMovies();
            me.Show();
            this.Hide();
        }

        private void ReqMovieButton_Click(object sender, EventArgs e)
        {
            var me = new RequestMovies();
            me.Show();
            this.Hide();
        }

        private void SearchMoviesButton_Click(object sender, EventArgs e)
        {
            var me = new SearchMovies();
            me.Show();
            this.Hide();
        }
    }
}
