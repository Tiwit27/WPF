using System.Windows;
using System.Windows.Controls;

namespace Kalkulator
{
    public partial class MainWindow : Window
    {
        decimal[] memory = new decimal[2];
        Sign memorySign = Sign.nothing;
        bool isResult = false;
        bool clear = false;
        enum Sign
        {
            nothing,
            plus,
            minus,
            multiplication,
            division
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if(isResult)
            {
                textVisual.Text = "0";
            }
            if(textVisual.Text.Length < 9 || clear)
            {
                Button button = (Button)sender;
                if(textVisual.Text == "0" || clear)
                {
                    textVisual.Text = "";
                    clear = false;
                }
                textVisual.AppendText(button.Content.ToString());
            }
            isResult = false;
        }
        private void MakeCalkulation(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            char Sign = button.Content.ToString()[0];
            if (textVisual.Text[textVisual.Text.Length - 1] == ',')
            {
                textVisual.Text = textVisual.Text.Remove(textVisual.Text.Length - 1);
            }
            if (!String.IsNullOrEmpty(textVisual.Text))
            {
                memory[0] = decimal.Parse(textVisual.Text);
            }
            switch (Sign)
            {
                case '+':
                    if(!String.IsNullOrEmpty(textVisual.Text))
                    {
                        memorySign = MainWindow.Sign.plus;
                    }
                    break;
                case '-':
                    if (!String.IsNullOrEmpty(textVisual.Text))
                    {
                        memorySign = MainWindow.Sign.minus;
                    }
                    break;
                case 'x':
                    if (!String.IsNullOrEmpty(textVisual.Text))
                    {
                        memorySign = MainWindow.Sign.multiplication;
                    }
                    break;
                case '÷':
                    if (!String.IsNullOrEmpty(textVisual.Text))
                    {
                        memorySign = MainWindow.Sign.division;
                    }
                    break;
            }
            clear = true;
        }
        private void Calculate(object sender, RoutedEventArgs e)
        {
            if (textVisual.Text[textVisual.Text.Length - 1] == ',')
            {
                textVisual.Text = textVisual.Text.Remove(textVisual.Text.Length - 1);
            }
            if (!String.IsNullOrEmpty(textVisual.Text))
            {
                memory[1] = decimal.Parse(textVisual.Text);
                textVisual.Text = "0";
            }
            decimal result;
            switch(memorySign)
            {
                case Sign.plus:
                    result = (memory[0] + memory[1]);
                    if(result % 1 == 0)
                    {
                        textVisual.Text = ((int)result).ToString();
                    }
                    else
                    {
                        textVisual.Text = result.ToString();
                    }
                    break;
                case Sign.minus:
                    result = (memory[0] - memory[1]);
                    if (result % 1 == 0)
                    {
                        textVisual.Text = ((int)result).ToString();
                    }
                    else
                    {
                        textVisual.Text = result.ToString();
                    }
                    break;
                case Sign.multiplication:
                    result = (memory[0] * memory[1]);
                    if (result % 1 == 0)
                    {
                        textVisual.Text = ((int)result).ToString();
                    }
                    else
                    {
                        textVisual.Text = result.ToString();
                    }
                    break;
                case Sign.division:
                    if (memory[1] != 0)
                    {
                        result = (memory[0] / memory[1]);
                        if (result % 1 == 0)
                        {
                            textVisual.Text = ((int)result).ToString();
                        }
                        else
                        {
                            textVisual.Text = result.ToString();
                        }
                    }
                    else
                    {
                        textVisual.Text = "ERROR";
                    }
                    break;
                default:
                    break;
            }
            if(textVisual.Text.Length > 11)
            {
                textVisual.Text = "TOO BIG";
            }
            memory[0] = 0;
            memory[1] = 0;
            isResult = true;
            memorySign = Sign.nothing;
        }
        private void Clear(object sender, RoutedEventArgs e)
        {
            memory[0] = 0;
            memory[1] = 0;
            isResult = false;
            textVisual.Text = "0";
        }
        private void DelLast(object sender, RoutedEventArgs e)
        {
            if(textVisual.Text.Length > 1)
            {
                textVisual.Text = textVisual.Text.Remove(textVisual.Text.Length - 1);
            }
            else if(textVisual.Text.Length == 1 && textVisual.Text[0] != '0')
            {
                textVisual.Text = "0";
            }
        }
        private void Dot(object sender, RoutedEventArgs e)
        {
            if (isResult || clear)
            {
                textVisual.Text = "0";
            }
            if (!textVisual.Text.Contains(','))
            {
                textVisual.AppendText(",");
            }
            isResult = false;
            clear = false;
        }
    }
}