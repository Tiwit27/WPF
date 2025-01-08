using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Tutorial_14.View;
namespace WPF_Tutorial_14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            var normalWindow = new NormalWindow();
            normalWindow.Show();
        }

        private void btnModal_Click(object sender, RoutedEventArgs e)
        {
            var modalWindow = new ModalWindow(this);
            Opacity = 0.4;
            modalWindow.ShowDialog();
            Opacity = 1;
            if(modalWindow.Success)
            {
                txtInput.Text = modalWindow.Input;
            }
        }
    }
}