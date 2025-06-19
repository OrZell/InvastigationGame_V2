using MySql.Data.MySqlClient;
using InvastigationGame_V2.SQL;
using InvastigationGame_V2.Models.Player;

namespace InvastigationGame_V2.DAL
{
    public class PlayerDAL
    {
        public SQLServer SQL;

        public PlayerDAL(SQLServer sql)
        {
            this.SQL = sql;
        }

        public void AddPlayer(Player player)
        {
            try
            {
                MySqlConnection connection = this.SQL.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO players (" +
                                                    "name," +
                                                    "level) " +
                                                    "VALUES (" +
                                                    "@name," +
                                                    "@level)", connection);
                cmd.Parameters.AddWithValue(@"name", player.Name);
                cmd.Parameters.AddWithValue(@"level", player.Level);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.SQL.CloseConnection();
            }
        }

        public void UpdatePlayerLevel(Player player)
        {
            try
            {
                MySqlConnection connection = this.SQL.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE players " +
                                                    "SET level = @level " +
                                                    "WHERE name = @name", connection);
                cmd.Parameters.AddWithValue(@"name", player.Name);
                cmd.Parameters.AddWithValue(@"level", player.Level);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.SQL.CloseConnection();
            }
        }

        public Player FindPlayerByName(string name)
        {
            MySqlDataReader reader = null;
            Player player = null;

            try
            {
                MySqlConnection connection = this.SQL.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * " +
                                                    "FROM players " +
                                                    "WHERE name = @name", connection);
                cmd.Parameters.AddWithValue(@"name", name);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Name = reader.GetString("name");
                    int Level = reader.GetInt16("level");
                    player = new Player(Name, Level);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.SQL.CloseConnection();
            }
            return player;
        }
    }
}
