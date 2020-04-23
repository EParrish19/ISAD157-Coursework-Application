using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ISAD157_Coursework_Application
{
    class Connection
    {
        //Variables used to set up connection to SQL server
        internal const string user_name = "ISAD157_EParrish";
        internal const string SQLServer = "proj-mysql.uopnet.plymouth.ac.uk";
        internal const string Database = "isad157_eparrish";
        internal const string Password = "ISAD157_22225283";
        internal const string SSL = "none";
    }
}
