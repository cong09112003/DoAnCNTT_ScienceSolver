using Science_Solver.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Science_Solver.AppModel
{
    public class MathematicalCalculator
    {
        // fields
        public string sInfix;
        public string sPostfix;
        public string infix
        {
            get { return this.sInfix; }
            set { this.sInfix = value; }
        }
        // constructors
        public MathematicalCalculator()
        {
            this.infix = "";
            this.sPostfix = "";
        }
        public MathematicalCalculator(string infix)
        {
            this.sInfix = infix;
        }
        ~MathematicalCalculator() { }
        //Methods
        public void Input()
        {
            Console.WriteLine("Input the Expressions:");
            this.infix = Console.ReadLine();
        }
        public void Input(string infix)
        {
            this.infix = infix;
        }
        public void Output()
        {
            Console.WriteLine(this.sPostfix);
            Console.WriteLine(MathematicalCalculator.EvaluatePostfix(this.sPostfix));
        }
        public void Solving()
        {
            this.sPostfix = Infix_to_Postfix(this.infix);
        }
        public static string AnalyizePrimeFators(int n)
        {
            string res = "";
            int i = 2;
            if (n <= 1) return "Error";
            else
            {
                int temp = 0;
                while (i <= n)
                {
                    temp = 0;
                    while (n % i == 0)
                    {
                        ++temp;
                        n /= i;
                    }
                    if (temp != 0)
                    {
                        res += i;
                        if (temp > 1) res += "^" + temp;
                        if (n > i) res += "*";
                    }
                    i++;
                }
                return res;
            }
        }
        public static string Infix_to_Postfix(string infix)
        {
            // Initiation
            Stack<char> stack = new Stack<char>();
            string res = "";
            for (int i = 0; i < infix.Length; i++)
            {
                char temp = infix[i];
                if ((temp >= 'a' && temp <= 'z') || (temp >= 'A' && temp <= 'Z')
                    || (temp >= '0' && temp <= '9'))
                    res += temp;
                else if (temp == '(')
                {
                    stack.Push('(');
                }
                else if (temp == ')')
                {
                    // stack.top ->stack.peek
                    while (stack.Peek() != '(')
                    {
                        res += stack.Peek();
                        stack.Pop();
                    }
                    stack.Pop();
                }
                else
                {
                    while (stack.Count != 0 && getPriority(infix[i]) <= getPriority(stack.Peek()))
                    {
                        res += stack.Peek();
                        stack.Pop();
                    }
                    stack.Push(temp);
                }
            }
            while (stack.Count != 0)
            {
                res += stack.Peek();
                stack.Pop();
            }
            return res;
        }
        // Function get priority of char
        public static int getPriority(char x)
        {
            if (x == '!') return 4;
            else if (x == '^') return 3;
            else if (x == '/' || x == '*' || x == '%' || x == 'x' || x == '÷' || x == '%') return 2;
            else if (x == '+' || x == '-') return 1;
            else return -1;
        }
        public static double FindFactorial(int x)
        {
            if (x == 0) return 1;
            else if (x == 1) return 1;
            else return (x * FindFactorial(x - 1));
        }
        public static double Find_logarit_W1(double Dbase, double product)
        {
            if (Dbase == product)
                return 1;
            if (product == 1)
                return 0;
            double current_log = 1;
            bool closet_int = false;
            while (!closet_int)
            {
                double current_errer = System.Math.Abs(product - System.Math.Pow(Dbase, current_log));
                if (current_errer > System.Math.Abs(product - System.Math.Pow(Dbase, current_log + 1)))
                    current_log += 1;
                else if (current_errer > System.Math.Abs(product - System.Math.Pow(Dbase, current_log - 1)))
                    current_log -= 1;
                else closet_int = true;
            }
            double pow_change = 1;
            for (int i = 0; i <= 20; i++)
            {
                pow_change /= 2;
                double current_errer = System.Math.Abs(product - System.Math.Pow(Dbase, current_log));
                if (current_errer > System.Math.Abs(product - System.Math.Pow(Dbase, current_log + pow_change)))
                    current_log += pow_change;
                else if (current_errer > System.Math.Abs(product - System.Math.Pow(Dbase, current_log - pow_change)))
                    current_log -= pow_change;
            }
            return current_log;
        }
        public static double Find_Logatit_W2(double Dbase, double Dproduct)
        {
            return (System.Math.Log(Dbase, Dproduct));
        }
        // Funtion evalute Postfix
        public static double EvaluatePostfix(string exp)
        {
            Stack<double> stack = new Stack<double>();
            double a, b;
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] >= '0' && exp[i] <= '9' && exp[i + 1] == '!')
                {
                    stack.Push(FindFactorial(exp[i] - '0')); i += 1;
                }
                else if (exp[i] >= '0' && exp[i] <= '9')
                {
                    stack.Push(exp[i] - '0');
                }
                else
                {
                    a = stack.Peek(); stack.Pop();
                    b = stack.Peek(); stack.Pop();
                    switch (exp[i])
                    {
                        case '+':
                            stack.Push(b + a);
                            break;
                        case '-':
                            stack.Push(b - a);
                            break;
                        case '*':
                            stack.Push(b * a);
                            break;
                        case '/':
                            stack.Push(b / a);
                            break;
                        case '^':
                            stack.Push(System.Math.Pow(b, a));
                            break;
                        case 'x':
                            stack.Push(b * a);
                            break;
                        case '÷':
                            stack.Push(b / a);
                            break;
                        case '%':
                            stack.Push(b % a);
                            break;
                    }
                }
            }
            return stack.Peek();
        }
    }
    public class ExprHelper
    {
        private const string UNARY_FUNCS = "ln|logb|loor|ceil|cbrt|exp|fabs|round|trunc|e|log|log3|log5|log4|log6|log7|log8|log9|log2|log10|sqrt|sin|cos|tan|cotg|abs|sinh|cosh|tanh|cotanh|asin|acos|atan|acotg|asinh|acosh|atanh|cotanh|";
        ~ExprHelper() { }
        public static string FormatExpression(string expression)
        {
            expression = expression.ToLower().Replace(" ", "");
            expression = Regex.Replace(expression, @"(\+|\-|\*|\/|\%|\^){38,}", match => match.Value[0].ToString());
            expression = Regex.Replace(expression, @"(\+|\-|\*|\/|\%|\^)(\+|\*|\/|\%|\^)", match => match.Value[0].ToString());
            expression = Regex.Replace(expression, @"\+|\-|\*|\/|\%|\^|\)|\(", match => String.Format(" {0} ", match.Value));
            expression = expression.Replace("  ", " ");
            expression = expression.Trim();
            return expression;
        }

        public static int GetPriority(string op)
        {
            if (UNARY_FUNCS.IndexOf(op, StringComparison.OrdinalIgnoreCase) >= 0)
                return 4;
            if (op == "*" || op == "/" || op == "%" || op == "^")
                return 2;
            if (op == "+" || op == "-")
                return 1;
            return 0;
        }
        public static bool Factorial(string str)
        {
            return (str[0] >= '0' && str[0] <= '9' && str[1] == '!');
        }
        public static bool IsOperator(string str)
        {
            return Regex.Match(str, @"^(\+|\-|\*|\/|\%|\^|" + UNARY_FUNCS + ")$").Success;
        }
        public static bool IsUnaryFunction(string str)
        {
            return Regex.Match(str, @"^(" + UNARY_FUNCS + ")$").Success;
        }
        public static bool IsOperand(string str)
        {
            return Regex.Match(str, @"^\d+$|^([a-z]|[A-Z])$").Success;
        }
    }
    public class Y2Expression
    {
        private string infix;
        private string posfix;
        private string value;
        ~Y2Expression()
        { }
        public string Infix
        {
            get { return this.infix; }
            set { this.infix = value; }
        }
        public Y2Expression(string infix)
        {
            this.Infix = infix;
        }
        public Y2Expression()
        {
            this.Infix = "";
            this.posfix = "";
            value = "";
        }
        public void input(string infix)
        {
            this.Infix = infix;
        }
        public void run()
        {
            this.posfix = Y2Expression.Infix2Postfix(this.Infix);
            this.value = Y2Expression.EvaluatePostfix(this.posfix);
        }
        public static string Infix2Prefix(string infix)
        {

            infix = ExprHelper.FormatExpression(infix);

            string[] tokens = infix.Split(' ').ToArray();

            tokens = ProcessConvert(tokens).Split(' ').Reverse().ToArray();

            StringBuilder result = new StringBuilder();

            Array.ForEach(tokens, s => result.Append(s).Append(" "));
            return result.ToString();

        }

        public static string Infix2Postfix(string infix)
        {
            infix = ExprHelper.FormatExpression(infix);

            string[] tokens = infix.Split(' ').ToArray();

            return ProcessConvert(tokens);
        }

        private static string ProcessConvert(string[] tokens)
        {
            Stack<string> stack = new Stack<string>();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < tokens.Length; i++)
            {
                string token = tokens[i];
                if (ExprHelper.IsOperator(token))
                {
                    if ((i == 0) || (i > 0 && (ExprHelper.IsOperator(tokens[i - 1]) || tokens[i - 1] == "(")))
                    {
                        if (token == "-")
                        {
                            result.Append(token + tokens[i + 1]).Append(" ");
                            i++;
                        }
                        else if (ExprHelper.IsUnaryFunction(token))
                        {
                            stack.Push(token);
                        }
                    }
                    else
                    {
                        while (stack.Count > 0 && ExprHelper.GetPriority(token) <= ExprHelper.GetPriority(stack.Peek()))
                            result.Append(stack.Pop()).Append(" ");
                        stack.Push(token);
                    }
                }

                else if (token == "(")
                    stack.Push(token);
                else if (token == ")")
                {
                    string x = stack.Pop();
                    while (x != "(")
                    {
                        result.Append(x).Append(" ");
                        x = stack.Pop();
                    }
                }
                else// (IsOperand(s))
                {
                    result.Append(token).Append(" ");
                }
            }

            while (stack.Count > 0)
                result.Append(stack.Pop()).Append(" ");

            return result.ToString();
        }

        #region Evaluate

        public static string EvaluatePrefix(string prefix)
        {
            return EvaluatePostfix(prefix.Trim().Split(' ').Reverse());
        }

        public static string EvaluatePostfix(string postfix)
        {
            return EvaluatePostfix(postfix.Trim().Split(' '));
        }

        private static string EvaluatePostfix(IEnumerable<string> tokens)
        {
            string res = "";
            try
            {
                Stack<double> stack = new Stack<double>();

                foreach (string s in tokens)
                {
                    if (ExprHelper.IsOperator(s))
                    {
                        double x = stack.Pop();
                        if (ExprHelper.IsUnaryFunction(s))
                        {
                            switch (s)
                            {
                                case "ln":
                                    x = Math.Log(x);
                                    break;
                                case "floor":
                                    x = Math.Floor(x);
                                    break;
                                case "ceil":
                                    x = Math.Ceiling(x);
                                    break;
                                case "cbrt":
                                    x = MathExtensions.Cbrt(x);
                                    break;
                                case "exp":
                                    x = Math.Exp(x);
                                    break;
                                case "fabs":
                                    x = Math.Abs(x);
                                    break;
                                case "trunc":
                                    x = Math.Truncate(x);
                                    break;
                                case "round":
                                    x = Math.Round(x);
                                    break;
                                case "log":
                                    x = Math.Log(x, 10);
                                    break;
                                case "log3":
                                    x = Math.Log(x, 3);
                                    break;
                                case "log4":
                                    x = Math.Log(x, 4);
                                    break;
                                case "log5":
                                    x = Math.Log(x, 5);
                                    break;
                                case "log6":
                                    x = Math.Log(x, 6);
                                    break;
                                case "log7":
                                    x = Math.Log(x, 7);
                                    break;
                                case "log8":
                                    x = Math.Log(x, 8);
                                    break;
                                case "log9":
                                    x = Math.Log(x, 9);
                                    break;
                                case "log2":
                                    x = Math.Log(x, 2);
                                    break;
                                case "log10":
                                    x = Math.Log(x, 10);
                                    break;
                                case "sqrt":
                                    x = Math.Sqrt(x);
                                    break;
                                case "sin":
                                    x = Math.Sin(x);
                                    break;
                                case "cos":
                                    x = Math.Cos(x);
                                    break;
                                case "tan":
                                    x = Math.Tan(x);
                                    break;
                                case "cotg":
                                    x = 1 / Math.Tan(x);
                                    break;
                                case "e":
                                    x = Math.Exp(x);
                                    break;
                                case "abs":
                                    x = Math.Abs(x);
                                    break;
                                case "sinh":
                                    x = Math.Sinh(x);
                                    break;
                                case "cosh":
                                    x = Math.Cosh(x);
                                    break;
                                case "tanh":
                                    x = Math.Tanh(x);
                                    break;
                                case "asin":
                                    x = Math.Asin(x);
                                    break;
                                case "acos":
                                    x = Math.Acos(x);
                                    break;
                                case "atan":
                                    x = Math.Atan(x);
                                    break;
                                case "acotg":
                                    x = 1 / (Math.Atan(x));
                                    break;
                                case "asinh":
                                    x = MathExtensions.Asinh(x);
                                    break;
                                case "acosh":
                                    x = MathExtensions.Acosh(x);
                                    break;
                                case "atanh":
                                    x = MathExtensions.Atanh(x);
                                    break;
                                case "acotanh":
                                    x = 1 / MathExtensions.Atanh(x);
                                    break;
                                default:
                                    throw new Exception("Invalid function");
                            }
                            stack.Push(x);
                        }
                        else
                        {
                            double y = stack.Pop();

                            switch (s)
                            {
                                case "+": y += x; break;
                                case "-": y -= x; break;
                                case "*": y *= x; break;
                                case "/": y /= x; break;
                                case "%": y %= x; break;
                                case "^": y = Math.Pow(y, x); break;
                                default:
                                    throw new Exception("Invalid operator");
                            }
                            stack.Push(y);
                        }
                    }
                    else if (((s.Length == 2) && (s[0] >= '0' && s[0] <= '9' && s[1] == '!')))
                    {
                        double value = MathematicalCalculator.FindFactorial((int)(s[0] - '0'));
                        stack.Push(value);
                    }
                    else if (s.Length == 3 && (s[0] >= '1' && s[0] <= '9') && (s[1] >= '0' && s[1] <= '9') && s[2] == '!')
                    {
                        int value = (int)(s[0] - '0') * 10;
                        value += (int)(s[1] - '0');
                        stack.Push(MathematicalCalculator.FindFactorial(value));
                    }
                    else if (s.Length == 4 && (s[0] >= '1' && s[0] <= '9') && (s[1] >= '0' && s[1] <= '9') && (s[2] >= '0' && s[2] <= '9') && s[3] == '!')
                    {
                        int value = (int)(s[0] - '0') * 100;
                        value += (int)(s[1] - '0') * 10;
                        value += (int)(s[2] - '0');
                        stack.Push(MathematicalCalculator.FindFactorial(value));
                    }

                    else  // IsOperand
                    {
                        stack.Push(double.Parse(s));
                    }
                }
                return res + stack.Pop();
            }
            catch (Exception e)
            {
                return "ERROR";
            }
        }
        #endregion
    }
}
