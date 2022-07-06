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
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var me = new Form1();
            me.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var me = new AdminRequestedMovies();
            me.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var me = new AdminManageUsers();
            me.Show();
            this.Hide();
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            var me = new UserViewMovies();
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
