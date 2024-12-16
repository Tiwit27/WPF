using Microsoft.Win32;
using System.Windows;

namespace WPF_Tutorial_5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            //tworzenie wyskakującego okienka na ekranie z podanym tekstem, tytułem, przyciskiem, oraz obrazkiem które zwraca wybrany przez nas typ
            MessageBoxResult result = MessageBox.Show("Do you agree to use your file?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                //Tworzenie własnego okna wyboru plików
                OpenFileDialog fileDialog = new();
                fileDialog.Filter = "C# Source Files | *.cs";//pozwala wczytać tylko pliki z rozszerzeniem .cs
                                                             //fileDialog.InitialDirectory = "C:\\temp";//Ustawienie domyślnej ścieżki otwierania
                fileDialog.Title = "Please pick a .cs source file(s)...";//tytuł okienka
                fileDialog.Multiselect = true;//pozwala wybrac wiele plików
                bool? success = fileDialog.ShowDialog();
                if (success == true)
                {
                    string path = fileDialog.FileName;//pobiera całą scieżkę do pliku
                    string fileName = fileDialog.SafeFileName;//pobiera tylko nazwę pliku
                    tbInfo.Text = path + "\n";
                    tbInfo.Text += fileName;
                }
                else
                {
                    //nie wybrano pliku
                }
            }
            else
            {
                tbInfo.Text = "Not agreed";
            }


        }
    }
}