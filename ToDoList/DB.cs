using MySql.Data.MySqlClient;
using System.Windows.Controls;
using System.Windows.Media;

namespace ToDoList
{
    internal class DB
    {
        public static StackPanel listStackPanel;
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
            catch (Exception)
            {
                return false;
            }
        }
        public static void Load()
        {
            listStackPanel.Children.Clear();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "SELECT * from list";
            var myReader = myCommand.ExecuteReader();
            int counter = 0;
            while (myReader.Read())
            {
                TodolistInstance todolist = new();
                todolist.title.Text = (string)myReader.GetValue(1);
                todolist.text.Text = myReader.GetValue(2).ToString();
                todolist.Id = (int)myReader.GetValue(0);
                if(counter % 2 == 0)
                {
                    var brush = new BrushConverter().ConvertFromString("#91d9bc");
                    todolist.Background = (SolidColorBrush)brush;
                }
                else
                {
                    var brush = new BrushConverter().ConvertFromString("#a3e7cc");
                    todolist.Background = (SolidColorBrush)brush;
                }
                listStackPanel.Children.Add(todolist);
                counter++;
            }
            myReader.Close();
        }
        public static void Add(TextBox titleInput, TextBox textInput)
        {
            if(!conn.IsDisposed)
            {
                MySqlCommand myCommand = new();
                myCommand.Connection = conn;
                myCommand.CommandText = $"INSERT INTO list(title, text) VALUES ('{titleInput.Text}', '{textInput.Text}')";
                myCommand.ExecuteNonQuery();
                titleInput.Clear();
                textInput.Clear();
                Load();
            }
        }
        public static void Delete(int id)
        {
            MySqlCommand myCommand = new();
            myCommand.Connection = conn;
            myCommand.CommandText = $"DELETE FROM list WHERE list.id = {id}";
            myCommand.ExecuteNonQuery();
            Load();
        }
    }
}
