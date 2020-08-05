using MySql.Data.MySqlClient;
using System;

namespace csharp_mysql.Database
{
    class Db : IDb
    {
        private Db() { }

        private static string _Server = "143.106.241.3";
        private static string _Port = "3306";
        private static string _UserId = "cl19126";
        private static string _Database = "cl19126";
        private static string _Password = "cl*10102003";

        private string _connectionString = $"server={_Server};port={_Port};UserID={_UserId};" +
            $"database={_Database};password={_Password}";

        private static Db _instance;

        private MySqlConnection _conn;

        public void Execute(MySqlConnection conn, string command)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(command, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static Db GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Db();
            }
            return _instance;
        }

        public MySqlConnection GetConnection()
        {
            if(_conn == null)
            {
                _conn = new MySqlConnection(this._connectionString);
            }
            return _conn;
        }
    }
}
