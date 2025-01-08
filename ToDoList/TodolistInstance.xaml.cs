using System.Windows;
using System.Windows.Controls;

namespace ToDoList
{
    public partial class TodolistInstance : UserControl
    {
        private string titleBind;
        private string textBind;
        private int id;
        public static MainWindow mainWindow;
        private static int counter;

        public string TitleText
        {
            get { return titleBind; }
            set { titleBind = value; }
        }
        public string TextBind
        {
            get { return textBind; }
            set { textBind = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public TodolistInstance()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DB.Delete(id);
        }
    }
}
