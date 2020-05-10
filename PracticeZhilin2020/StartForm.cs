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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user_login = "Guest",user_password="123";
            DB dB = new DB();

            DataTable datatable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_l AND `password` = @u_p", dB.getConnection());
           
            command.Parameters.Add("@u_l", MySqlDbType.VarChar).Value = user_login;
            command.Parameters.Add("@u_p", MySqlDbType.VarChar).Value = user_password;

            adapter.SelectCommand = command;
            adapter.Fill(datatable);

            if (datatable.Rows.Count > 0)
            {
                HeadForm headForm = new HeadForm(user_login);
                headForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!");

            }
        }
    }
    }

