using Science_Solver.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Science_Solver.AppModel
{
    public abstract class MathematicalEquation
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double e;
        private double f;
        private string x;// variable
        ~MathematicalEquation() { }
        public string Varible
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double A
        {
            get { return this.a; }
            set { this.a = value; }
        }
        public double B
        {
            get { return this.b; }
            set { this.b = value; }
        }
        public double C
        {
            get { return this.c; }
            set { this.c = value; }
        }
        public double D
        {
            get { return this.d; }
            set { this.d = value; }
        }
        public double E
        {
            get { return this.e; }
            set { this.e = value; }
        }
        public MathematicalEquation()
        {
            /*
            this.a = 1;
            this.b = 1;
            this.c = 1;
            this.d = 1;
            this.e = 1;
            this.f = 1;
            */
        }

        public MathematicalEquation(double A, double B, double C, double D, double E, double F)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
            this.e = E;
            this.f = F;
        }
        public abstract void MathematicalEquation_Input();
        public virtual void MathematicalEquation_Output() { Console.WriteLine("Result:" + this.Varible); }
        public abstract void MathematicalEquation_Solving();
        public static string MathematicalEquation_Solving_Degree4(double a, double b, double c, double d, double e)
        {
            if ((a == 0 && b == 0 && c == 0 && d == 0 && e == 0) || (a != 0 && b == 0 && c == 0 && d == 0 && e == 0) ||
                (a == 0 && b != 0 && c == 0 && d == 0 && e == 0) || (a == 0 && b == 0 && c != 0 && d == 0 && e == 0) ||
                (a == 0 && b == 0 && c == 0 && d != 0 && e == 0)) { return "No Solution"; }
            else if (a == 0 && b == 0 && c == 0 && d == 0 && e != 0) { return "ERROR"; }
            else if (a == 0 && b != 0 && c != 0 && d != 0 && e != 0) return MathematicalEquation_SolvingDegree3(b, c, d, e);
            else if (a == 0 && b == 0 && c != 0 && d != 0 && e != 0) return MathematicalEquation_SolvingDegree2(c, d, e);
            else if (a == 0 && b == 0 && c == 0 && d != 0 && e != 0) return MathematicalEquation_SolvingDegree1(d, e);
            else if (a != 0 && b == 0 && c != 0 && d == 0 && e != 0)
            {
                double delta = c * c - 4 * a * e;
                double Root = (Math.Sqrt(-c / (2 * a)));
                double Root_1 = ((-c + Math.Sqrt(delta)) / (2 * a));
                double Root_2 = ((-c - Math.Sqrt(delta)) / (2 * a));
                if (delta < 0) return "< ERROR >";
                else if (delta == 0)
                {
                    if (Root_1 < 0) return "ERROR";
                    else if (Root_1 == 0) return "<single solution>, x=" + 0;
                    else return "< double Solution >, x1= " + (Math.Sqrt(Root_1))
                        + ", x2= " + (-Math.Sqrt(Root_1));
                }
                else
                {
                    if (Root_1 < 0)
                    {
                        if (Root_2 < 0) return "ERROR";
                        else if (Root_2 == 0) return "< Single Solution > x= " + 0;
                        else return "< Double solution >, x1= " + (Math.Sqrt(Root_2)) + ", x2= " + (-Math.Sqrt(Root_1));
                    }
                    else if (Root_1 == 0)
                    {
                        if (Root_2 < 0) return "< Single solution > x= " + 0;
                        else return "< Triple solution >, x1= " + (Math.Sqrt(Root_2)) + ", x2= " + (-Math.Sqrt(Root_2)) + ", x3= " + 0;
                    }
                    else
                    {
                        if (Root_2 < 0)
                        {
                            return "< Double solution >, x1= " + (Math.Sqrt(Root_1)) + ", x2= " + (-Math.Sqrt(Root_1));
                        }
                        else if (Root_2 == 0)
                        {
                            return " Triple solution >, x1= " + (Math.Sqrt(Root_1)) + ", x2= " + (-Math.Sqrt(Root_1)) + ", x3= " + 0;
                        }
                        else
                        {
                            return "< Four solutions >, x1= " + (Math.Sqrt(Root_1)) + ", x2= " + (-Math.Sqrt(Root_1))
                                + ", x3= " + (Math.Sqrt(Root_2)) + ", x4= " + (-Math.Sqrt(Root_2));

                        }
                    }
                }
            }
            else
            {
                string res = " < Solution > ,";
                // Varibale of Discriminant
                double Var_discriminant = 256 * Math.Pow(a, 3) * Math.Pow(e, 3) - (192 * Math.Pow(a, 2) * b * d * Math.Pow(e, 2)) -
                (128 * Math.Pow(a, 2) * Math.Pow(c, 2) * Math.Pow(e, 2)) + (144 * Math.Pow(a, 2) * c * Math.Pow(d, 2) * e) -
                (27 * Math.Pow(a, 2) * Math.Pow(d, 4)) + (144 * a * Math.Pow(b, 2) * c * Math.Pow(e, 2)) -
                (6 * a * Math.Pow(b, 2) * Math.Pow(d, 2) * e) - (80 * a * b * Math.Pow(c, 2) * d * e) +
                (18 * a * b * c * Math.Pow(d, 3)) + (16 * a * Math.Pow(c, 4) * e) - (4 * a * Math.Pow(c, 3) * Math.Pow(d, 2)) -
                (27 * Math.Pow(b, 4) * Math.Pow(e, 2)) + (18 * Math.Pow(b, 3) * c * d * e) -
                (4 * Math.Pow(b, 3) * Math.Pow(d, 3)) - (4 * Math.Pow(b, 2) * Math.Pow(c, 3) * e) +
                (Math.Pow(b, 2) * Math.Pow(c, 2) * Math.Pow(d, 2));
                // different parts of the roots presented in Varibale 1 to 6
                double Var_1 = (2 * Math.Pow(c, 3)) - (9 * b * c * d) + (27 * a * Math.Pow(d, 2)) + (27 * Math.Pow(b, 2) * e) -
                (72 * a * c * e);
                double Var_2 = Var_1 + Math.Sqrt(-4.0 * Math.Pow(Math.Pow(c, 2) - (3 * b * d) + (12 * a * e), 3) + Math.Pow(Var_1, 2));
                double Var_3 = ((Math.Pow(c, 2) - (3 * b * d) + (12 * a * e)) / (3 * a * MathExtensions.Cbrt(Var_2 / 2))) + (MathExtensions.Cbrt(Var_2 / 2) / (3 * a));
                double Var_4 = Math.Sqrt((Math.Pow(b, 2) / (4 * Math.Pow(a, 2))) - (2 * c / (3 * a)) + Var_3);
                double Var_5 = (Math.Pow(b, 2) / (2 * Math.Pow(a, 2))) - (4 * c / (3 * a)) - Var_3;
                double Var_6 = ((-(Math.Pow(b, 3) / Math.Pow(a, 3))) + (4 * b * c / Math.Pow(a, 2)) - (8 * d / a)) / (4 * Var_4);
                // Caculate the roots with Var1 - Var2
                Complex Delta_1 = (-(b / (4 * a))) - (Var_4 / 2) - (Math.Sqrt(Var_5 - Var_6) / 2);
                Complex Delta_2 = (-(b / (4 * a))) - (Var_4 / 2) + (Math.Sqrt(Var_5 - Var_6) / 2);
                Complex Delta_3 = (-(b / (4 * a))) + (Var_4 / 2) - (Math.Sqrt(Var_5 - Var_6) / 2);
                Complex Delta_4 = (-(b / (4 * a))) + (Var_4 / 2) + (Math.Sqrt(Var_5 - Var_6) / 2);
                // Polynimcial used for testing the nature of ROOT
                double Const_P = (8 * a * c) - (3 * Math.Pow(b, 2));
                double Const_R = Math.Pow(b, 3) + (8 * d * Math.Pow(a, 2)) - (4 * a * b * c);
                double deltazero = Math.Pow(c, 2) - (3 * b * d) + (12 * a * e);
                double Const_D = (64 * Math.Pow(a, 3) * e) - (16 * Math.Pow(a, 2) * Math.Pow(c, 2)) +
                    (16 * a * Math.Pow(b, 2) * c) - (16 * Math.Pow(a, 2) * b * d) - (3 * Math.Pow(b, 4));
                // FUntion_Reslt
                // res_1
                string Root1_Rp = Convert.ToString(Math.Round(Delta_1.Real, 5)); // Real of Complex // Around 5 num
                string Root1_Ip = Convert.ToString(Math.Round(Delta_1.Imaginary, 5));// Imaginary of Complex
                // ... check
                if (Delta_1.Imaginary == 0) res += " x1 = " + Root1_Rp;
                else if (Delta_1.Imaginary < 0) // testing if unreal part is negative
                    res += " x1= " + Root1_Rp + " - " + (Math.Round(Complex.Abs(Delta_1.Imaginary))) + "i";
                else res += " x1= " + Root1_Rp + " + " + Root1_Ip + "i";
                // res_2
                string Root2_Rp = Convert.ToString(Math.Round(Delta_2.Real, 5));
                string Root2_Ip = Convert.ToString(Math.Round(Delta_2.Imaginary, 5));
                //...check
                if (Delta_2.Imaginary == 0) res += ", x2 = " + Root2_Rp;
                else if (Delta_2.Imaginary < 0) // testing if unreal part is negative
                    res += ", x2= " + Root2_Rp + " - " + (Math.Round(Complex.Abs(Delta_2.Imaginary))) + "i";
                else res += ", x2= " + Root2_Rp + " + " + Root2_Ip + "i";
                // res_3
                string Root3_Rp = Convert.ToString(Math.Round(Delta_3.Real, 5));
                string Root3_Ip = Convert.ToString(Math.Round(Delta_3.Imaginary, 5));
                //...check
                if (Delta_3.Imaginary == 0) res += ", x3 = " + Root3_Rp;
                else if (Delta_3.Imaginary < 0) // testing if unreal part is negative
                    res += ", x3= " + Root3_Rp + " - " + (Math.Round(Complex.Abs(Delta_3.Imaginary))) + "i";
                else res += ", x3= " + Root3_Rp + " + " + Root3_Ip + "i";
                // res_4
                string Root4_Rp = Convert.ToString(Math.Round(Delta_4.Real, 5));
                string Root4_Ip = Convert.ToString(Math.Round(Delta_4.Imaginary, 5));
                //...check
                if (Delta_4.Imaginary == 0) res += ", x4 = " + Root4_Rp;
                else if (Delta_4.Imaginary < 0) // testing if unreal part is negative
                    res += ", x4= " + Root4_Rp + " - " + (Math.Round(Complex.Abs(Delta_4.Imaginary))) + "i";
                else res += ", x4= " + Root4_Rp + " + " + Root4_Ip + "i";
                // Discriminant Tsest
                res += "<";
                if (Var_discriminant == 0) // if delta = 0
                {
                    if (Const_P < 0 && Const_D < 0 && deltazero != 0)
                    {
                        string result4 = res + "The equation yields a pair of double roots and two real simple roots.";
                    }
                    else if (Const_D > 0 || (Const_P > 0 && (Const_D != 0 || Const_R != 0)))
                    {
                        res += "The equation yields a pair of double roots and two complex conjugate roots.";
                    }
                    else if (deltazero == 0 && Const_D != 0)
                    {
                        res += "The equation yields a triple root and a simple root.";
                    }
                    else if (Const_D == 0)
                    {
                        if (Const_P < 0)
                        {
                            res += "The equation yields two pairs of real double roots.";
                        }
                        else if (Const_P > 0 && Const_R == 0)
                        {
                            res += "The equation yields two pairs of double complex conjugate roots.";
                        }
                        else if (deltazero == 0)
                        {
                            // square equation with 1 variable
                            string result9pt2 = Convert.ToString(-(b / (4 * a)));
                            string result9 = "All of the roots of this equation are equal to -b/4a";
                            res += result9 + "(" + result9pt2 + ")";
                        }
                        else
                        {
                            res += "ERROR";
                        }
                    }
                    else
                    {
                        res += "ERROR";
                    }
                }
                else if (Var_discriminant > 0) // if delta > 0
                {
                    if (Const_P < 0 && Const_D < 0)
                    {
                        res += "The equation yields four distinct real roots.";
                    }
                    else if (Const_P > 0 && Const_D > 0)
                    {
                        string result3 = "The equation yields two pairs of unreal complex conjugate roots.";
                        Console.WriteLine(result3);
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                    }
                }
                else if (Var_discriminant < 0) // if delta < 0
                {
                    res += "The equation yields two distinct real roots and two complex conjugate non-real roots.";
                }
                res += ">";
                return res;
            }
        }
        public static string MathematicalEquation_SolvingDegree3(double a, double b, double c, double d)
        {
            if ((a == 0 && b == 0 && c == 0 && d == 0) || (a != 0 && b == 0 && c == 0 && d == 0) ||
                (a == 0 && b != 0 && c == 0 && d == 0) || (a == 0 && b == 0 && c != 0 && d == 0)) { return "No Solution"; }
            else if (a == 0 && b == 0 && c == 0 && d != 0) { return "ERROR"; }
            else if (a == 0 && b != 0 && c != 0 && d != 0) return MathematicalEquation_SolvingDegree2(b, c, d);
            else if (a == 0 && b == 0 && c != 0 && d != 0) return MathematicalEquation_SolvingDegree1(c, d);
            else
            {
                double denta = System.Math.Pow(b, 2) - (3 * a * c);
                double k = (9 * a * b * c - 2 * Math.Pow(b, 3) - 27 * Math.Pow(a, 2) * d) / (2 * Math.Sqrt(Math.Pow(Math.Abs(denta), 3)));
                if (denta > 0)
                {
                    if (Math.Abs(k) <= 1)
                    {
                        return "<Triple solution>, x1 = " + ((2 * Math.Sqrt(denta) * Math.Cos((Math.Acos(k) / 3)) - b) / (3 * a)) +
                            " ,  x2 = " + ((2 * Math.Sqrt(denta) * Math.Cos(Math.Acos(k) / 3 - (2 * Math.PI / 3)) - b) / (3 * a)) +
                            " , x3 =  " + ((2 * Math.Sqrt(denta) * Math.Cos(Math.Acos(k) / 3 + (2 * Math.PI / 3)) - b) / (3 * a));
                    }
                    else
                    {
                        return "<Single Solution>,  x= " + ((Math.Sqrt(denta) * Math.Abs(k) / (3 * a * k) * (MathExtensions.Cbrt((Math.Abs(k) + Math.Sqrt(k * k - 1))) + MathExtensions.Cbrt(Math.Abs(k) - Math.Sqrt(k * k - 1)))) - (b / (3 * a)));
                    }
                }
                if (denta == 0)
                {
                    return "<Single Solution>,  x= " + ((-b + MathExtensions.Cbrt((Math.Pow(b, 3) - 27 * a * a * d))) / (3 * a));
                }
                else
                {
                    return "<single Solution>,  x=" + (((Math.Sqrt(Math.Abs(denta)) / (3 * a)) * (MathExtensions.Cbrt(k + Math.Sqrt(k * k + 1)) + MathExtensions.Cbrt(k - Math.Sqrt(k * k + 1)))) - (b / (3 * a)));
                }
            }
        }
        public static string MathematicalEquation_SolvingDegree1(double a, double b)
        {
            if (a == 0 && b == 0) return "No Solution";
            else if (a == 0 && b != 0) return "ERORR";
            else return "x:" + (-(b) / (a));
        }
        public static string MathematicalEquation_SolvingDegree2(double a, double b, double c)
        {
            if ((a == 0 && b == 0 && b == 0) || (a != 0 && b == 0 && c == 0) ||
                (a == 0 && b != 0 && c == 0)) { return " No Solution "; }
            else if (a == 0 && b == 0 && c != 0) { return " ERROR "; }
            else if (a == 0 && b != 0 && c != 0) { return MathematicalEquation_SolvingDegree1(b, c); }
            else
            {
                double denta = b * b - 4 * a * c;
                if (denta < 0) { return " No Solution "; }
                else if (denta == 0) { return " <Single Solutions>,  x1 = x2 = " + ((-b) / (2 * a)); }
                else
                {
                    return " <Double Solution>, x1 = " + ((-b + Math.Sqrt(denta)) / (2 * a))
                        + " , x2 = " + ((-b - Math.Sqrt(denta)) / (2 * a));
                }
            }
        }
    }
}
