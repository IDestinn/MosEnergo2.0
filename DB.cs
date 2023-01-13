using MySql.Data.MySqlClient;

namespace MosEnergo2._0
{
    // Класс для подключения и отключения от БД
    internal class DB
    {
        readonly MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;charset=utf8;database=energo");
        
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();               
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
