﻿using System;
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
    public partial class UserViewMovies : Form
    {
        public UserViewMovies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var me = new UserMainPage();
            me.Show();
            this.Hide();
        }

    }
}