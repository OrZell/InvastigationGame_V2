using MySql.Data.MySqlClient;

namespace InvastigationGame_V2.SQL
{
    public class SQLServer
    {
        private string MySQLServer = "Server=localhost;Database=invastigation_game_v2;User=root;Password=''";
        public MySqlConnection connection = null;

        public SQLServer()
        {

        }

        public MySqlConnection OpenConnection()
        {
            if (this.connection == null)
            {
                this.connection = new MySqlConnection(MySQLServer);
            }

            if (this.connection.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    this.connection.Open();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return this.connection;
        }

        public void CloseConnection()
        {
            if (this.connection != null && this.connection.State == System.Data.ConnectionState.Open)
            {
                this.connection.Close();
            }
        }
    }
}
