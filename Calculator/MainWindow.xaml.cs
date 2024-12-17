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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static string text = "";

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            text = text + "0";
            textBox_display.Text = text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text = text + "1";
            textBox_display.Text = text;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text = text + "2";
            textBox_display.Text = text;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            text = text + "3";
            textBox_display.Text = text;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            text = text + "4";
            textBox_display.Text = text;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            text = text + "5";
            textBox_display.Text = text;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            text = text + "6";
            textBox_display.Text = text;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            text = text + "7";
            textBox_display.Text = text;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            text = text + "8";
            textBox_display.Text = text;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            text = text + "9";
            textBox_display.Text = text;
        }

        private void Button_Click_equal(object sender, RoutedEventArgs e)
        {
            if (text != "")
            {

                char[] operatorChars =  { '/', '*', '-', '+' };                
                var valueLst = text.Split(operatorChars);
                var newValueLst = new List<double>();

                foreach (string v in valueLst)
                {
                    //TODO: fix iot so it takes care of calculation rules
                    //TODO: fix it so it updates the list if it gets modified,
                    //right now it would give the correct result as each thing is taken into accoutn seperately with no relation to each other
                    if (v == "+")
                    {
                        addNumbers(valueLst, newValueLst, v);
                    }
                    if (v == "-")
                    {
                        subtractNumbers(valueLst, newValueLst, v);
                    }
                    if (v == "/")
                    {
                        divideNumbers(valueLst, newValueLst, v);
                    }
                    if (v == "*")
                    {
                        multiplyNumbers(valueLst, newValueLst, v);
                    }

                }
                
            }

        }

        private void Button_Click_decimal(object sender, RoutedEventArgs e)
        {
            text = text + ".";
            textBox_display.Text = text;
        }

        private void Button_Click_divide(object sender, RoutedEventArgs e)
        {
            text = text + "/";
            textBox_display.Text = text;
        }

        private void Button_Click_multiply(object sender, RoutedEventArgs e)
        {
            text = text + "*";
            textBox_display.Text = text;
        }
       

        private void Button_Click_subtract(object sender, RoutedEventArgs e)
        {
            text = text + "-";
            textBox_display.Text = text;
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {

            text = text + "+";
            textBox_display.Text = text;
        }


        //Calculation operations

        private static void addNumbers(string[] valueLst, List<double> newValueLst, string v )
        {
            var n = Array.IndexOf(valueLst, v);
            if (n == 0)
            {
                var newValue = Convert.ToDouble(valueLst[n + 1]);
                newValueLst.Add(newValue);

            }
            else if (n == -1)
            {
                var newValue = Convert.ToDouble(valueLst[n - 1]);
                newValueLst.Add(newValue);
            }
            else
            {
                var newValueLeft = Convert.ToDouble(valueLst[n - 1]);
                var newValueRight = Convert.ToDouble(valueLst[n + 1]);
                newValueLst.Add(newValueLeft + newValueRight);
            }
        }
        private static void subtractNumbers(string[] valueLst, List<double> newValueLst, string v)
        {
            var n = Array.IndexOf(valueLst, v);
            if (n == 0)
            {
                var newValue = Convert.ToDouble(valueLst[n + 1]);
                newValueLst.Add(-newValue);

            }
            else if (n == -1)
            {
                var newValue = Convert.ToDouble(valueLst[n - 1]);
                newValueLst.Add(newValue);
            }
            else
            {
                var newValueLeft = Convert.ToDouble(valueLst[n - 1]);
                var newValueRight = Convert.ToDouble(valueLst[n + 1]);
                newValueLst.Add(newValueLeft - newValueRight);
            }
        }

        private static void multiplyNumbers(string[] valueLst, List<double> newValueLst, string v)
        {
            var n = Array.IndexOf(valueLst, v);
            if (n == 0)
            {
                var newValue = Convert.ToDouble(valueLst[n + 1]);
                newValueLst.Add(0);

            }
            else if (n == -1)
            {
                var newValue = Convert.ToDouble(valueLst[n - 1]);
                newValueLst.Add(newValue);
            }
            else
            {
                var newValueLeft = Convert.ToDouble(valueLst[n - 1]);
                var newValueRight = Convert.ToDouble(valueLst[n + 1]);
                newValueLst.Add(newValueLeft * newValueRight);
            }
        }

        private static void divideNumbers(string[] valueLst, List<double> newValueLst, string v)
        {
            var n = Array.IndexOf(valueLst, v);
            if (n == 0)
            {
                var newValue = Convert.ToDouble(valueLst[n + 1]);
                newValueLst.Add(0);

            }
            else if (n == -1)
            {
                var newValue = Convert.ToDouble(valueLst[n - 1]);
                newValueLst.Add(newValue);
            }
            else
            {
                var newValueLeft = Convert.ToDouble(valueLst[n - 1]);
                var newValueRight = Convert.ToDouble(valueLst[n + 1]);
                newValueLst.Add(newValueLeft/newValueRight);
            }
        }
    }
}