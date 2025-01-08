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
            TodolistInstance.mainWindow = this;
            DB.listStackPanel = listStackPanel;
            if(DB.Connect())
            {
                DB.Load();
            }
            else
            {
                var error = new TextBox();
                error.Text = "Error: Database is not connected";
                listStackPanel.Children.Add(error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(TitleInput.Text))
            {
                DB.Add(TitleInput, textInput);
            }
        }
    }
}