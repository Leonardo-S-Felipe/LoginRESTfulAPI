using MySql.Data.MySqlClient;

namespace LoginRESTfulAPI.Engine
{
    public class MySQLConnector
    {
        private const string HOST = "localhost";
        private const string NAME = "login_schema";
        private const string USER = "root";
        private const string PASS = "";

        public MySqlConnection Connection { get; private set; }

        public MySQLConnector()
        {
            Connection = new MySqlConnection(
                $"server={HOST};" +
                $"database={NAME};" +
                $"uid={USER};" +
                $"password={PASS};"
            );
        }

        public void Connect() => Connection.Open();
    }
}
