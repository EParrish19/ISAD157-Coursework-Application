using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ISAD157_Coursework_Application
{
    public partial class Database_Form : Form
    {
        public Database_Form()
        {
            InitializeComponent();
        }

        private void Cbox_Data_Choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbox_Data_Choice.SelectedIndex == 0)
            {
                //If Users is selected in the combo box

                //String to use for connecting to Database
                string connectionString = "SERVER=" + Connection.SQLServer + ";" +
                    "DATABASE=" + Connection.Database + ";" + "UID=" +
                    Connection.user_name + ";" + "PASSWORD=" +
                    Connection.Password + ";" + "SslMode=" +
                    Connection.SSL + ";";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM isad157_eparrish.facebook_users";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UserData = new DataTable();
                    sqlDA.Fill(UserData);

                    DataGrid_QueryResult.DataSource = UserData;
                    connection.Close();
                }

            }
            else if (Cbox_Data_Choice.SelectedIndex == 1)
            {
                //If Friendships is selected in the combo box

                //String to use for connecting to Database
                string connectionString = "SERVER=" + Connection.SQLServer + ";" +
                    "DATABASE=" + Connection.Database + ";" + "UID=" +
                    Connection.user_name + ";" + "PASSWORD=" +
                    Connection.Password + ";" + "SslMode=" +
                    Connection.SSL + ";";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM isad157_eparrish.facebook_friendships";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UserData = new DataTable();
                    sqlDA.Fill(UserData);

                    DataGrid_QueryResult.DataSource = UserData;
                    connection.Close();
                }

            }
            else if (Cbox_Data_Choice.SelectedIndex == 2)
            {
                //If Work is selected in the combo box

                //String to use for connecting to Database
                string connectionString = "SERVER=" + Connection.SQLServer + ";" +
                    "DATABASE=" + Connection.Database + ";" + "UID=" +
                    Connection.user_name + ";" + "PASSWORD=" +
                    Connection.Password + ";" + "SslMode=" +
                    Connection.SSL + ";";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM isad157_eparrish.facebook_work";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UserData = new DataTable();
                    sqlDA.Fill(UserData);

                    DataGrid_QueryResult.DataSource = UserData;
                    connection.Close();
                }

            }
            else if (Cbox_Data_Choice.SelectedIndex == 3)
            {
                //If Education is selected in the combo box

                //String to use for connecting to Database
                string connectionString = "SERVER=" + Connection.SQLServer + ";" +
                    "DATABASE=" + Connection.Database + ";" + "UID=" +
                    Connection.user_name + ";" + "PASSWORD=" +
                    Connection.Password + ";" + "SslMode=" +
                    Connection.SSL + ";";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM isad157_eparrish.facebook_education";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UserData = new DataTable();
                    sqlDA.Fill(UserData);

                    DataGrid_QueryResult.DataSource = UserData;
                    connection.Close();
                }


            }
            else if (Cbox_Data_Choice.SelectedIndex == 4)
            {
                //If Messages is selected in the combo box

                //String to use for connecting to Database
                string connectionString = "SERVER=" + Connection.SQLServer + ";" +
                    "DATABASE=" + Connection.Database + ";" + "UID=" +
                    Connection.user_name + ";" + "PASSWORD=" +
                    Connection.Password + ";" + "SslMode=" +
                    Connection.SSL + ";";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM isad157_eparrish.facebook_messages";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UserData = new DataTable();
                    sqlDA.Fill(UserData);

                    DataGrid_QueryResult.DataSource = UserData;
                    connection.Close();
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (Cbox_Data_Choice.SelectedIndex == 0)
            {
                //If Users is selected in the combo box

                //String to use for connecting to Database
                string connectionString = "SERVER=" + Connection.SQLServer + ";" +
                    "DATABASE=" + Connection.Database + ";" + "UID=" +
                    Connection.user_name + ";" + "PASSWORD=" +
                    Connection.Password + ";" + "SslMode=" +
                    Connection.SSL + ";";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM isad157_eparrish.facebook_users Where isad157_eparrish.facebook_users.UserID = '" + TxtBoxFilter.Text + "'";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UserData = new DataTable();
                    sqlDA.Fill(UserData);

                    DataGrid_QueryResult.DataSource = UserData;
                    connection.Close();
                }

            }
            else if (Cbox_Data_Choice.SelectedIndex == 1)
            {
                //If Friendships is selected in the combo box

                //String to use for connecting to Database
                string connectionString = "SERVER=" + Connection.SQLServer + ";" +
                    "DATABASE=" + Connection.Database + ";" + "UID=" +
                    Connection.user_name + ";" + "PASSWORD=" +
                    Connection.Password + ";" + "SslMode=" +
                    Connection.SSL + ";";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM isad157_eparrish.facebook_friendships WHERE isad157_eparrish.facebook_friendships.FirstUserID = '" + TxtBoxFilter.Text + "' OR isad157_eparrish.facebook_friendships.SecondUserID = '" +
                        TxtBoxFilter.Text + "'";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UserData = new DataTable();
                    sqlDA.Fill(UserData);

                    DataGrid_QueryResult.DataSource = UserData;
                    connection.Close();
                }

            }
            else if (Cbox_Data_Choice.SelectedIndex == 2)
            {
                //If Work is selected in the combo box

                //String to use for connecting to Database
                string connectionString = "SERVER=" + Connection.SQLServer + ";" +
                    "DATABASE=" + Connection.Database + ";" + "UID=" +
                    Connection.user_name + ";" + "PASSWORD=" +
                    Connection.Password + ";" + "SslMode=" +
                    Connection.SSL + ";";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM isad157_eparrish.facebook_work WHERE isad157_eparrish.facebook_work.UserID = '" + TxtBoxFilter.Text + "'";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UserData = new DataTable();
                    sqlDA.Fill(UserData);

                    DataGrid_QueryResult.DataSource = UserData;
                    connection.Close();
                }

            }
            else if (Cbox_Data_Choice.SelectedIndex == 3)
            {
                //If Education is selected in the combo box

                //String to use for connecting to Database
                string connectionString = "SERVER=" + Connection.SQLServer + ";" +
                    "DATABASE=" + Connection.Database + ";" + "UID=" +
                    Connection.user_name + ";" + "PASSWORD=" +
                    Connection.Password + ";" + "SslMode=" +
                    Connection.SSL + ";";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM isad157_eparrish.facebook_education WHERE isad157_eparrish.facebook_education.UserID = '" + TxtBoxFilter.Text + "'";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UserData = new DataTable();
                    sqlDA.Fill(UserData);

                    DataGrid_QueryResult.DataSource = UserData;
                    connection.Close();
                }


            }
            else if (Cbox_Data_Choice.SelectedIndex == 4)
            {
                //If Messages is selected in the combo box

                //String to use for connecting to Database
                string connectionString = "SERVER=" + Connection.SQLServer + ";" +
                    "DATABASE=" + Connection.Database + ";" + "UID=" +
                    Connection.user_name + ";" + "PASSWORD=" +
                    Connection.Password + ";" + "SslMode=" +
                    Connection.SSL + ";";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM isad157_eparrish.facebook_messages WHERE isad157_eparrish.facebook_messages.FirstUserID = '" + TxtBoxFilter.Text + "' " + "OR isad157_eparrish.facebook_messages.SecondUserID = '" + 
                        TxtBoxFilter.Text + "'";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UserData = new DataTable();
                    sqlDA.Fill(UserData);

                    DataGrid_QueryResult.DataSource = UserData;
                    connection.Close();
                }
            }
        }
    }
}
