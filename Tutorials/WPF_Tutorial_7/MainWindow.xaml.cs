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

namespace WPF_Tutorial_7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(txtEntry.Text))
            {
                lvEntries.Items.Add(txtEntry.Text);
                txtEntry.Clear();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(lvEntries.SelectedItems.Count > 0)
            {
                
                var items = lvEntries.SelectedItems;
                MessageBoxResult result = MessageBox.Show($"Jesteś pewny że chcesz usunąć {WriteItems(items)}?", "Jesteś pewny?", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    for(int i = items.Count - 1; i >= 0; i--)
                    {
                        lvEntries.Items.Remove(items[i]);
                    }
                }
            }
        }

        private string WriteItems(System.Collections.IList items)
        {
            var result = "";
            foreach(var item in items)
            {
                result += item.ToString() + ", ";
            }
            result = result.Remove(result.Length - 2,1);
            return result;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}