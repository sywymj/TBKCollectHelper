namespace TBKCollectTool
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;

    public class DBHelperServer
    {
        private static MySqlConnection connection;

        public static int ExecuteCommand(string safeSql)
        {
            int result = new MySqlCommand(safeSql, Connection).ExecuteNonQuery();
            Connection.Close();
            return result;
        }

        public static int ExecuteCommand(string sql, params MySqlParameter[] values)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            int i = cmd.ExecuteNonQuery();
            Connection.Close();
            return i;
        }

        public static DataTable GetDataSet(string safeSql)
        {
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(safeSql, Connection);
            new MySqlDataAdapter(cmd).Fill(ds);
            DataTable dt = ds.Tables[0];
            Connection.Close();
            return dt;
        }

        public static DataTable GetDataSet(string sql, params MySqlParameter[] values)
        {
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = ds.Tables[0];
            Connection.Close();
            return dt;
        }

        public static MySqlDataReader GetReader(string safeSql)
        {
            MySqlDataReader reader = new MySqlCommand(safeSql, Connection).ExecuteReader();
            Connection.Close();
            return reader;
        }

        public static MySqlDataReader GetReader(string sql, params MySqlParameter[] values)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            MySqlDataReader reader = cmd.ExecuteReader();
            Connection.Close();
            return reader;
        }

        public static int GetScalar(string safeSql)
        {
            int result = Convert.ToInt32(new MySqlCommand(safeSql, Connection).ExecuteScalar());
            Connection.Close();
            return result;
        }

        public static int GetScalar(string sql, params MySqlParameter[] values)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            Connection.Close();
            return result;
        }

        public static string ServerAdd { get; set; }
        public static string ServerPort { get; set; }
        public static string UserID { get; set; }
        public static string Password { get; set; }
        public static string DataBase { get; set; }
        public static string ProductTableName { get; set; }

        public static MySqlConnection Connection
        {
            get
            {
                string _connStr = string.Format(@"server={0};Port={4};user id={1};password={2};database={3};CharSet=utf8;Allow Zero Datetime=True;", ServerAdd, UserID, Password, DataBase,ServerPort);
                //MySqlConnection myConn = new MySqlConnection("");
                connection = new MySqlConnection(_connStr);
                connection.Open();
                return connection;
            }
        }
    }
}

