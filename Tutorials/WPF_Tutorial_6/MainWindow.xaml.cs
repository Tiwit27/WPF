using System.Windows;
using WinForms = System.Windows.Forms;

namespace WPF_Tutorial_6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            WinForms.FolderBrowserDialog dialog = new();
            dialog.InitialDirectory = "C:\\Users\\lojek\\Desktop\\Programowanie";
            WinForms.DialogResult result = dialog.ShowDialog();

            if(result == WinForms.DialogResult.OK)
            {
                string folder = dialog.SelectedPath;
            }
        }
    }
}