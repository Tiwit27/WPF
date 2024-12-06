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

namespace Kalkulator.View.userControls
{
    public partial class NumberButton : UserControl
    {
        private MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        public string NumberText { get; set; }
        public string BackgroundColor { get; set; } = "#DDDDDD";
        public enum Method
        {
            Button_Click,
            Make_Calkulation,
            Calculate,
            Clear,
            DelLast,
            Dot
        }
        public Method MethodChoose { get; set; } = Method.Button_Click;
        public NumberButton()
        {
            InitializeComponent();
            DataContext = this;
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (MethodChoose)
            {
                case Method.Button_Click:
                    mainWindow.Button_Click(sender, e);
                    break;
                case Method.Make_Calkulation:
                    mainWindow.MakeCalkulation(sender, e);
                    break;
                case Method.Calculate:
                    mainWindow.Calculate(sender, e);
                    break;
                case Method.Clear:
                    mainWindow.Clear(sender, e);
                    break;
                case Method.DelLast:
                    mainWindow.DelLast(sender, e);
                    break;
                case Method.Dot:
                    mainWindow.Dot(sender, e);
                    break;
            }
        }
    }
}
