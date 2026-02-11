using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF.BootCamps.Views
{
    public partial class ScientificCalculatorView : Window
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string operation = "";
        private bool isNewOperation = true;
        private bool isRadiansMode = false; // true: راديان, false: درجات
       

        public ScientificCalculatorView()
        {
            InitializeComponent();
            InitializeStyles();
        }

        private void InitializeStyles()
        {
            // يمكن نقل الأنماط إلى Resources في المستقبل
        }

        // Event Handler للأرقام
        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (isNewOperation)
            {
                txtDisplay.Text = button.Content.ToString();
                isNewOperation = false;
            }
            else
            {
                // منع إدخال أكثر من نقطة عشرية واحدة
                if (button.Content.ToString() == "." && txtDisplay.Text.Contains("."))
                    return;

                txtDisplay.Text += button.Content.ToString();
            }
        }

        // Event Handler للعمليات الأساسية
        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                firstNumber = double.Parse(txtDisplay.Text);
                operation = button.Content?.ToString() ?? string.Empty;
                isNewOperation = true;
            }
        }

        // Event Handler للدوال العلمية
        private void ScientificFunction_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string function = button.Content?.ToString() ?? string.Empty;
            double inputValue = 0;

            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                inputValue = double.Parse(txtDisplay.Text);
            }

            double result = 0;

            switch (function)
            {
                case "sin":
                    result = CalculateSin(inputValue);
                    break;

                case "cos":
                    result = CalculateCos(inputValue);
                    break;

                case "tan":
                    result = CalculateTan(inputValue);
                    break;

                case "sin⁻¹":
                    result = CalculateAsin(inputValue);
                    break;

                case "cos⁻¹":
                    result = CalculateAcos(inputValue);
                    break;

                case "tan⁻¹":
                    result = CalculateAtan(inputValue);
                    break;

                case "√":
                    result = Math.Sqrt(inputValue);
                    break;

                case "x²":
                    result = Math.Pow(inputValue, 2);
                    break;

                case "x³":
                    result = Math.Pow(inputValue, 3);
                    break;

                case "log":
                    result = Math.Log10(inputValue);
                    break;

                case "ln":
                    result = Math.Log(inputValue);
                    break;

                case "eˣ":
                    result = Math.Exp(inputValue);
                    break;

                case "xʸ":
                    firstNumber = inputValue;
                    operation = "^";
                    isNewOperation = true;
                    return;

                case "10ˣ":
                    result = Math.Pow(10, inputValue);
                    break;

                case "1/x":
                    result = 1 / inputValue;
                    break;

                case "|x|":
                    result = Math.Abs(inputValue);
                    break;

                case "n!":
                    result = CalculateFactorial((int)inputValue);
                    break;
            }

            txtDisplay.Text = FormatResult(result);
            isNewOperation = true;
        }

        // Event Handler للثوابت
        private void Constant_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Content.ToString())
            {
                case "π":
                    txtDisplay.Text = Math.PI.ToString();
                    break;

                case "e":
                    txtDisplay.Text = Math.E.ToString();
                    break;
            }

            isNewOperation = true;
        }

        // Event handler للنتيجة
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                secondNumber = double.Parse(txtDisplay.Text);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;

                    case "-":
                        result = firstNumber - secondNumber;
                        break;

                    case "×":
                    case "*":
                        result = firstNumber * secondNumber;
                        break;

                    case "/":
                        if (secondNumber != 0)
                            result = firstNumber / secondNumber;
                        else
                            result = double.NaN;
                        break;

                    case "%":
                        result = firstNumber % secondNumber;
                        break;

                    case "^":
                        result = Math.Pow(firstNumber, secondNumber);
                        break;
                }

                txtDisplay.Text = FormatResult(result);
                isNewOperation = true;
            }
        }

        // Event Handler للمسح
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
            isNewOperation = true;
        }

        // Event Handler لمسح الإدخال الحالي
        private void ClearEntry_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            isNewOperation = true;
        }

        // Event Handler للرجوع للخلف
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
                isNewOperation = true;
            }
        }

        // Event Handler لتغيير الإشارة
        private void PlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text) && txtDisplay.Text != "0")
            {
                double value = double.Parse(txtDisplay.Text);
                value = -value;
                txtDisplay.Text = value.ToString();
            }
        }

        // Event Handler للأقواس
        private void Parenthesis_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += button.Content.ToString();
            isNewOperation = false;
        }

        // Event Handler لتغيير وضع الزوايا
        private void ToggleAngleMode_Click(object sender, RoutedEventArgs e)
        {
            isRadiansMode = !isRadiansMode;
            Button button = (Button)sender;
            button.Content = isRadiansMode ? "Rad" : "Deg";
        }

        // دوال حسابية مساعدة
        private double CalculateSin(double angle)
        {
            return isRadiansMode ? Math.Sin(angle) : Math.Sin(DegreesToRadians(angle));
        }

        private double CalculateCos(double angle)
        {
            return isRadiansMode ? Math.Cos(angle) : Math.Cos(DegreesToRadians(angle));
        }

        private double CalculateTan(double angle)
        {
            return isRadiansMode ? Math.Tan(angle) : Math.Tan(DegreesToRadians(angle));
        }

        private double CalculateAsin(double value)
        {
            double result = Math.Asin(value);
            return isRadiansMode ? result : RadiansToDegrees(result);
        }

        private double CalculateAcos(double value)
        {
            double result = Math.Acos(value);
            return isRadiansMode ? result : RadiansToDegrees(result);
        }

        private double CalculateAtan(double value)
        {
            double result = Math.Atan(value);
            return isRadiansMode ? result : RadiansToDegrees(result);
        }

        private double CalculateFactorial(int n)
        {
            if (n < 0) return double.NaN;
            if (n == 0) return 1;

            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        private double RadiansToDegrees(double radians)
        {
            return radians * 180.0 / Math.PI;
        }

        private string FormatResult(double result)
        {
            if (double.IsNaN(result))
                return "خطأ: غير معرف";

            if (double.IsInfinity(result))
                return "خطأ: غير منتهي";

            // تقريب النتيجة إلى 10 خانات عشرية
            return Math.Round(result, 10).ToString();
        }
    }
}