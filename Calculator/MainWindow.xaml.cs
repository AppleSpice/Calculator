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
    public partial class MainWindow : Window
    {
        double num1 = 0;
        double num2 = 0;
        double answer = 0;
        bool plus = false;
        bool minus = false;
        bool multiply = false;
        bool divide = false;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + 1;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + 2;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + 3;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + 4;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + 5;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + 6;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + 7;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + 8;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + 9;
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + 0;
        }

        private void ButtonDecimal_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = equation.Text + ".";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(equation.Text);

            plus = false;
            minus = false;
            multiply = false;
            divide = true;

            equation.Text = "";
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(equation.Text);

            plus = false;
            minus = false;
            multiply = true;
            divide = false;

            equation.Text = "";
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(equation.Text);

            plus = true;
            minus = false;
            multiply = false;
            divide = false;

            equation.Text = "";
        }

        private void ButtonSubtract_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(equation.Text);

            plus = false;
            minus = true;
            multiply = false;
            divide = false;

            equation.Text = "";
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            num2 = double.Parse(equation.Text);

            if (plus == true)
            {
                answer = num1 + num2;
                equation.Text = Convert.ToString(answer); 
            }
            else if (minus == true)
            {
                answer = num1 - num2;
                equation.Text = Convert.ToString(answer);
            }
            else if (multiply == true)
            {
                answer = num1 * num2;
                equation.Text = Convert.ToString(answer);
            }
            else if (divide == true)
            {
                answer = num1 / num2;
                equation.Text = Convert.ToString(answer);
            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            equation.Text = "";
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
