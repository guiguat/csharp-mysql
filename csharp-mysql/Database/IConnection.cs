using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace csharp_mysql.Database
{
    interface IConnection
    {
        MySqlConnection GetConnection();
        void Execute(MySqlConnection conn, string command);
        Connection GetInstance();

    }
}
