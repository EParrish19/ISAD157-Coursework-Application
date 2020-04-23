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
                }
                    
            }

        }

    }
}
