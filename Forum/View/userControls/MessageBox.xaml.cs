using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Forum.View.userControls
{
    public partial class MessageBox : UserControl
    {
        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        public MessageBox()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(userNameTextBox.Text) && !String.IsNullOrEmpty(messageTextBox.Text))
            {
                ForumMessageInstance instance = new ForumMessageInstance();
                instance.UserName = userNameTextBox.Text;
                instance.Message = messageTextBox.Text;
                mainWindow.listStackPanel.Children.Add(instance);
                userNameTextBox.Text = String.Empty;
                messageTextBox.Text = String.Empty;
            }
        }

        private void userNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!String.IsNullOrEmpty(userNameTextBox.Text))
            {
                userNamePlaceholder.Visibility = Visibility.Hidden;
            }
            else
            {
                userNamePlaceholder.Visibility = Visibility.Visible;
            }
        }

        private void messageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(messageTextBox.Text))
            {
                messagePlaceholder.Visibility = Visibility.Hidden;
            }
            else
            {
                messagePlaceholder.Visibility = Visibility.Visible;
            }
        }
    }
}
