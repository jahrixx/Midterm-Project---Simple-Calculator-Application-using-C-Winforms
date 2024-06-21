using System.Data;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void backspace(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
        private void allClear(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }
        private void num1(object sender, EventArgs e)
        {
            AppendTextToTextBox("1");
        }
        private void num2(object sender, EventArgs e)
        {
            AppendTextToTextBox("2");
        }
        private void num3(object sender, EventArgs e)
        {
            AppendTextToTextBox("3");
        }
        private void num4(object sender, EventArgs e)
        {
            AppendTextToTextBox("4");
        }
        private void num5(object sender, EventArgs e)
        {
            AppendTextToTextBox("5");
        }
        private void num6(object sender, EventArgs e)
        {
            AppendTextToTextBox("6");
        }
        private void num7(object sender, EventArgs e)
        {
            AppendTextToTextBox("7");
        }
        private void num8(object sender, EventArgs e)
        {
            AppendTextToTextBox("8");
        }
        private void num9(object sender, EventArgs e)
        {
            AppendTextToTextBox("9");
        }
        private void num0(object sender, EventArgs e)
        {
            AppendTextToTextBox("0");
        }
        private void decimalBtn(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                AppendTextToTextBox(".");
            }
        }
        private void addition(object sender, EventArgs e)
        {
            AppendOperation("+");
        }
        private void subtraction(object sender, EventArgs e)
        {
            AppendOperation("-");
        }
        private void multiplication(object sender, EventArgs e)
        {
            AppendOperation("*");
        }
        private void division(object sender, EventArgs e)
        {
            AppendOperation("/");
        }
        private void equalBtn(object sender, EventArgs e)
        {
            try
            {
                string expression = label1.Text + textBox1.Text;

                var result = new DataTable().Compute(expression, null);
                textBox1.Text = FormatNumber(Convert.ToDouble(result));

                label1.Text = "";
            }
            catch
            {
                textBox1.Text = "Error";
                label1.Text = "";
            }
        }
        private void AppendOperation(string operation)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Text += textBox1.Text + " " + operation + " ";
                textBox1.Text = "";
            }
        }
        private string FormatNumber(double number)
        {
            if (number == Math.Floor(number))
            {
                return number.ToString("0");
            }
            else
            {
                return number.ToString("0.##");
            }
        }
        private void AppendTextToTextBox(string text)
        {
            textBox1.Text += text;
        }
        private double EvaluateExpression(string expression)
        {
            List<string> tokens = Tokenize(expression);
            List<string> rpn = ConvertToRPN(tokens);

            return EvaluateRPN(rpn);
        }
        private List<string> Tokenize(string expression)
        {
            List<string> tokens = new List<string>();
            string number = "";

            foreach (char ch in expression)
            {
                if (char.IsDigit(ch) || ch == '.')
                {
                    number += ch;
                }
                else if (ch == ' ')
                {
                    continue;
                }
                else
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        tokens.Add(number);
                        number = "";
                    }
                    tokens.Add(ch.ToString());
                }
            }

            if (!string.IsNullOrEmpty(number))
            {
                tokens.Add(number);
            }

            return tokens;
        }
        private List<string> ConvertToRPN(List<string> tokens)
        {
            List<string> output = new List<string>();
            Stack<string> operators = new Stack<string>();
            Dictionary<string, int> precedence = new Dictionary<string, int>
            {
                { "+", 1 },
                { "-", 1 },
                { "*", 2 },
                { "/", 2 }
            };

            foreach (string token in tokens)
            {
                double number;
                if (double.TryParse(token, out number))
                {
                    output.Add(token);
                }
                else if (precedence.ContainsKey(token))
                {
                    while (operators.Count > 0 && precedence.ContainsKey(operators.Peek()) &&
                           precedence[operators.Peek()] >= precedence[token])
                    {
                        output.Add(operators.Pop());
                    }
                    operators.Push(token);
                }
            }

            while (operators.Count > 0)
            {
                output.Add(operators.Pop());
            }

            return output;
        }
        private double EvaluateRPN(List<string> rpn)
        {
            Stack<double> stack = new Stack<double>();

            foreach (string token in rpn)
            {
                double number;
                if (double.TryParse(token, out number))
                {
                    stack.Push(number);
                }
                else
                {
                    double b = stack.Pop();
                    double a = stack.Pop();

                    switch (token)
                    {
                        case "+":
                            stack.Push(a + b);
                            break;
                        case "-":
                            stack.Push(a - b);
                            break;
                        case "*":
                            stack.Push(a * b);
                            break;
                        case "/":
                            stack.Push(a / b);
                            break;
                    }
                }
            }

            return stack.Pop();
        }
    }
}
