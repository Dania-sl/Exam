using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Exam
{
    class dataBase
    {
        static string connectionString = "server=localhost;port=3306;username=root;password=0000;database=exam";

        MySqlConnection connection = new MySqlConnection(connectionString);
        
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                try
                {
                    connection.Open();

                }
                catch 
                {
                    MessageBox.Show("Відсутнє підключення до бази даних");
                }
            
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }



    }

}
