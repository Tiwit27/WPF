using MySql.Data.MySqlClient;
using System.Windows.Controls;

namespace ToDoList
{
    internal class DB
    {
        static MySqlConnection conn;
        const string connectionData = "server=localhost;uid=root;pwd=;database=todolist";
        public static bool Connect()
        {
            try
            {
                conn = new MySqlConnection(connectionData);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static void Command(StackPanel listStackPanel)
        {
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "SELECT * from list";
            var myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                TextBlock textbox = new();
                textbox.Text = myReader.GetValue(1).ToString();
                listStackPanel.Children.Add(textbox);
            }
            myReader.Close();
        }
        public static void Add(TextBox textBox, StackPanel listStackPanel)
        {
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = $"INSERT INTO list(title) VALUES ('{textBox.Text}')";
            myCommand.ExecuteNonQuery();
            textBox.Clear();
            Reload(listStackPanel);
        }
        public static void Reload(StackPanel listStackPanel)
        {
            listStackPanel.Children.Clear();
            Command(listStackPanel);
        }
    }
}
