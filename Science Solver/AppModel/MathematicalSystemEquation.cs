using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science_Solver.AppModel
{
    public abstract class MathematicalSystemEquation
    {
        // fields
        private double dA1; private double dB1; private double dC1; private double dD1; private double dE1;
        private double dA2; private double dB2; private double dC2; private double dD2; private double dE2;
        private double dA3; private double dB3; private double dC3; private double dD3; private double dE3;
        private double dA4; private double dB4; private double dC4; private double dD4; private double dE4;
        private double dA5; private double dB5; private double dC5; private double dD5; private double dE5;
        private string x;
        // Finalizers
        ~MathematicalSystemEquation()
        { }
        // Properties
        public string Variables
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double a1
        {
            get { return this.dA1; }
            set { this.dA1 = value; }
        }
        public double a2
        {
            get { return this.dA2; }
            set { this.dA2 = value; }
        }
        public double a3
        {
            get { return this.dA3; }
            set { this.dA3 = value; }
        }
        public double a4
        {
            get { return this.dA4; }
            set { this.dA4 = value; }
        }
        public double a5
        {
            get { return this.dA5; }
            set { this.dA5 = value; }
        }
        public double b1
        {
            get { return this.dB1; }
            set { this.dB1 = value; }
        }
        public double b2
        {
            get { return this.dB2; }
            set { this.dB2 = value; }
        }
        public double b3
        {
            get { return this.dB3; }
            set { this.dB3 = value; }
        }
        public double b4
        {
            get { return this.dB4; }
            set { this.dB4 = value; }
        }
        public double b5
        {
            get { return this.dB5; }
            set { this.dB5 = value; }
        }
        public double c1
        {
            get { return this.dC1; }
            set { this.dC1 = value; }
        }
        public double c2
        {
            get { return this.dC2; }
            set { this.dC2 = value; }
        }
        public double c3
        {
            get { return this.dC3; }
            set { this.dC3 = value; }
        }
        public double c4
        {
            get { return this.dC4; }
            set { this.dC4 = value; }
        }
        public double c5
        {
            get { return this.dC5; }
            set { this.dC5 = value; }
        }
        public double d1
        {
            get { return this.dD1; }
            set { this.dD1 = value; }
        }
        public double d2
        {
            get { return this.dD2; }
            set { this.dD2 = value; }
        }
        public double d3
        {
            get { return this.dD3; }
            set { this.dD3 = value; }
        }

        public double d4
        {
            get { return this.dD4; }
            set { this.dD4 = value; }
        }
        public double d5
        {
            get { return this.dD5; }
            set { this.dD5 = value; }
        }
        //
        public double e1
        {
            get { return this.dE1; }
            set { this.dE1 = value; }
        }
        public double e2
        {
            get { return this.dE2; }
            set { this.dE2 = value; }
        }
        public double e3
        {
            get { return this.dE3; }
            set { this.dE3 = value; }
        }

        public double e4
        {
            get { return this.dE4; }
            set { this.dE4 = value; }
        }
        public double e5
        {
            get { return this.dE5; }
            set { this.dE5 = value; }
        }

        // Constructors
        public MathematicalSystemEquation()
        {
        }
        public abstract void Mathematics_SysEqua_Input();
        public virtual void Mathematics_SysEqua_Output()
        {
            Console.Write("Result: \n");
        }
        public abstract void Mathematics_SysEqua_solving();
        public static string Mathematics_SysEqua_step2(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            try
            {
                string res = "";
                MathematicalMatrix A = new MathematicalMatrix();
                A.Matrix_Row = 2; A.Matrix_Colum = 2;
                A.Matrix = new double[2, 2]; A.Matrix[0, 0] = a1; A.Matrix[0, 1] = b1; A.Matrix[1, 0] = a2; A.Matrix[1, 1] = b2;
                MathematicalMatrix B = new MathematicalMatrix();
                B.Matrix_Row = 2; B.Matrix_Colum = 1;
                B.Matrix = new double[2, 1];
                B.Matrix[0, 0] = c1; B.Matrix[1, 0] = c2;
                MathematicalMatrix C = MathematicalMatrix.MathematicalMatrixInverse(A) * B;
                res += "x=" + ((float)C.Matrix[0, 0]) + ",";
                res += "y=" + ((float)C.Matrix[1, 0]) + ",";
                return res;
            }
            catch (Exception)
            {
                return "error";
            }
        }
        public static string Mathematics_SysEqua_step3(double a1, double b1, double c1, double d1, double a2, double b2, double c2, double d2, double a3, double b3, double c3, double d3)
        {
            try
            {
                string res = "";
                MathematicalMatrix A = new MathematicalMatrix();
                A.Matrix_Row = 3; A.Matrix_Colum = 3;
                A.Matrix = new double[3, 3];
                A.Matrix[0, 0] = a1; A.Matrix[0, 1] = b1; A.Matrix[0, 2] = c1;
                A.Matrix[1, 0] = a2; A.Matrix[1, 1] = b2; A.Matrix[1, 2] = c2;
                A.Matrix[2, 0] = a3; A.Matrix[2, 1] = b3; A.Matrix[2, 2] = c3;
                MathematicalMatrix B = new MathematicalMatrix();
                B.Matrix_Row = 3; B.Matrix_Colum = 1;
                B.Matrix = new double[3, 1];
                B.Matrix[0, 0] = d1; B.Matrix[1, 0] = d2; B.Matrix[2, 0] = d3;
                MathematicalMatrix C = MathematicalMatrix.MathematicalMatrixInverse(A) * B;
                res += "x=" + (float)C.Matrix[0, 0] + ",";
                res += "y=" + ((float)C.Matrix[1, 0]) + ",";
                res += "z=" + ((float)C.Matrix[2, 0]) + ",";
                return res;
            }
            catch (Exception)
            {
                return "ERROR";
            }
        }
        public static string Mathematics_SysEqua_step4(double a1, double b1, double c1, double d1, double e1, double a2, double b2, double c2, double d2, double e2,
            double a3, double b3, double c3, double d3, double e3, double a4, double b4, double c4, double d4, double e4)
        {
            string res = "";
            try
            {
                MathematicalMatrix A = new MathematicalMatrix();
                A.Matrix_Row = 4; A.Matrix_Colum = 4;
                A.Matrix = new double[4, 4];
                A.Matrix[0, 0] = a1; A.Matrix[0, 1] = b1; A.Matrix[0, 2] = c1; A.Matrix[0, 3] = d1;
                A.Matrix[1, 0] = a2; A.Matrix[1, 1] = b2; A.Matrix[1, 2] = c2; A.Matrix[1, 3] = d2;
                A.Matrix[2, 0] = a3; A.Matrix[2, 1] = b3; A.Matrix[2, 2] = c3; A.Matrix[2, 3] = d3;
                A.Matrix[3, 0] = a4; A.Matrix[3, 1] = b4; A.Matrix[3, 2] = c4; A.Matrix[3, 3] = d4;
                MathematicalMatrix B = new MathematicalMatrix();
                B.Matrix_Row = 4; B.Matrix_Colum = 1;
                B.Matrix = new double[4, 1];
                B.Matrix[0, 0] = e1; B.Matrix[1, 0] = e2; B.Matrix[2, 0] = e3; B.Matrix[3, 0] = e4;
                MathematicalMatrix C = MathematicalMatrix.MathematicalMatrixInverse(A) * B;
                res += "x=" + (float)C.Matrix[0, 0] + ",";
                res += "y=" + ((float)C.Matrix[1, 0]) + ",";
                res += "z=" + ((float)C.Matrix[2, 0]) + ",";
                res += "t=" + ((float)C.Matrix[3, 0]) + ",";
                return res;
            }
            catch (Exception)
            {
                return "ERROR";
            }
        }
    }
}
