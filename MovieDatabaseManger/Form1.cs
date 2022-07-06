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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {

            var m = new UserMainPage();
            m.Show();
            this.Hide();
        }
 

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var m = new AdminMainPage();
            m.Show();
            this.Hide();
        }
    }
}