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
    public partial class AdminManageUsers : Form
    {
        public static int curuserid;
        public AdminManageUsers()
        {
            InitializeComponent();
        }


        private void SearchUserBTN_Click(object sender, EventArgs e)
        {
            var conn = new SqliteConnection("Data Source=MovieDatabase.db; Pooling=False");
            conn.Open();

            string SearchUser = "SELECT * FROM Users WHERE User_Name = '" + SearchUserBox.Text + "' LIMIT 1";
            using var cmd = new SqliteCommand(SearchUser, conn);

            using SqliteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                curuserid = rdr.GetInt32(0);
                UserNameBox.Text = rdr.GetString(1);
                if (rdr.GetInt32(3) == 0)
                {
                    BannedBox.SelectedIndex = BannedBox.FindStringExact("No");
                }

                else if (rdr.GetInt32(3) == 1)
                {
                    BannedBox.SelectedIndex = BannedBox.FindStringExact("Yes");
                }

                if (rdr.GetInt32(4) == 0)
                {
                    RankBox.SelectedIndex = RankBox.FindStringExact("User");
                }

                else if (rdr.GetInt32(4) == 1)
                {
                    RankBox.SelectedIndex = RankBox.FindStringExact("Admin");
                }
            }
        }

        private void UserSaveChangesBTN_Click(object sender, EventArgs e)
        {
            var conn = new SqliteConnection("Data Source=MovieDatabase.db; Pooling=False");
            conn.Open();

            var command = conn.CreateCommand();
            command.CommandText = @"UPDATE Users SET User_Name = @User_Name, User_Banned = @User_Banned, User_Rank = @User_Rank WHERE User_ID = " + curuserid;
            command.Parameters.AddWithValue("@User_Name", UserNameBox.Text);
            command.Parameters.AddWithValue("@User_Banned", BannedBox.SelectedIndex);
            command.Parameters.AddWithValue("@User_Rank", RankBox.SelectedIndex);

            command.Prepare();
            command.ExecuteNonQuery();

            DialogResult res = MessageBox.Show("User Saved!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            var me = new AdminMainPage();
            me.Show();
            this.Hide();
        }
    }
}
