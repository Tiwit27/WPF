using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace ToDoList
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            DB.Connect();
            DB.Command(listStackPanel);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(input.Text))
            {
                DB.Add(input, listStackPanel);
            }
        }
    }
}