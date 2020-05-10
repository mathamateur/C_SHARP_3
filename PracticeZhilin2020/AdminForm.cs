using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeZhilin2020
{
    public partial class AdminForm : Form
    {
        string user_group;
        public AdminForm(string user_login)
        {
            InitializeComponent();

            DB db = new DB();
            DataTable datatable = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_l", db.getConnection());
            command.Parameters.Add("@u_l", MySqlDbType.VarChar).Value = user_login;
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                user_group = reader["User_group"].ToString();
            }
            reader.Close();
            db.closeConnection();
            if (user_group != "head_admin")
            {
                AddTeamAdmin.Enabled = false;
                AddTeamAdmin.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            RegistrationForm registrationForm = new RegistrationForm(flag);
            registrationForm.Show();
            Hide();
        }
    }
}
