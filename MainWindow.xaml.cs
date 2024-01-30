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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            InitializeComponent();
        }

        private void ExitBun_OnClick(object sender, RoutedEventArgs e)
        {
          Close();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
           Button button=sender as Button;
           numberbox.Text = numberbox.Text.ToString() + button.Content.ToString();
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            numberbox.Text = string.Empty;
        }


        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            numberbox.Text = numberbox.Text.Substring(0,numberbox.Text.Length-1);
        }

        private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        {
           Button button=sender as Button;
           numberbox.Text = numberbox.Text.ToString() + " " + button.Content.ToString()+" ";
        }

        private void ButtonBase_OnClick5(object sender, RoutedEventArgs e)
        {
            string[] res = numberbox.Text.Split(" ");
            numberbox.Text = calculator(res).ToString();
           
        }
        private void ButtonBase_OnClick6(object sender, RoutedEventArgs e)
        {
            string a = numberbox.Text;
            numberbox.Text = Taqsim(a).ToString();
        }
        private void ButtonBase_OnClick7(object sender, RoutedEventArgs e)
        {
            string a = numberbox.Text;
            double b = Convert.ToDouble(a);
            numberbox.Text = (b * b).ToString();
        }
        private void ButtonBase_OnClick9(object sender, RoutedEventArgs e)
        {
            string[] res = numberbox.Text.Split(" ");
            numberbox.Text = minus(res).ToString();
        }
        
       




       
        private double Taqsim(string a)
        {
            double b = Convert.ToDouble(a);
            return 1 / b;
        }
        
        private double calculator(string[] res)
        {
            double a = double.Parse(res[0]);
            for (int i = 1; i < res.Length; i+=2)
            {
                switch (res[i])
                {
                    case "+":
                    {
                        a = a + double.Parse(res[i + 1]);
                        break;
                    }
                    case "-":
                    {
                        a = a - double.Parse(res[i + 1]);
                        break;
                    }
                    case "*":
                    {
                        a = a * double.Parse(res[i + 1]);
                        break;
                    }
                    case "/":
                    {
                        a = a / double.Parse(res[i + 1]);
                        break;
                    }
                }

                
            }
            return a;
        }


        private void ButtonBase_OnClick8(object sender, RoutedEventArgs e)
        {
            string a = numberbox.Text;
            double b = Convert.ToDouble(a);
            numberbox.Text = (Math.Sqrt(b)).ToString();
        }

        private double minus(string[] res)
        {
            if (res.Count() == 2)
            {
                double a = Convert.ToDouble(res[1]);
                return a;
            }
            else if (res.Count() == 1)
            {
                double c = Convert.ToDouble(res[0]);
                return -c;
            }

            else
            {
                return 0;
            }
        }


        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
           
        }

       
    }
    
}