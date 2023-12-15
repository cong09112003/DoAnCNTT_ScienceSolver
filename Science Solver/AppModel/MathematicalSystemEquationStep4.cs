using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science_Solver.AppModel
{
    public class MathematicalSystemEquationStep4:MathematicalSystemEquation
    {
        public MathematicalSystemEquationStep4()
        { }
        ~MathematicalSystemEquationStep4()
        { }
        public MathematicalSystemEquationStep4(int a1, int b1, int c1, int d1, int e1, int a2, int b2, int c2, int d2, int e2, int a3, int b3, int c3, int d3, int e3, int a4, int b4, int c4, int d4, int e4)
        {
            this.a1 = a1;
            this.b1 = b1;
            this.c1 = c1;
            this.d1 = d1;
            this.e1 = e1;

            this.a2 = a2;
            this.b2 = b2;
            this.c2 = c2;
            this.d2 = d2;
            this.e2 = e2;

            this.a3 = a3;
            this.b3 = b3;
            this.c3 = c3;
            this.d3 = d3;
            this.e3 = e3;

            this.a4 = a4;
            this.b4 = b4;
            this.c4 = c4;
            this.d4 = d4;
            this.e4 = e4;
        }
        public void Input1(int a1, int b1, int c1, int d1, int e1, int a2, int b2, int c2, int d2, int e2, int a3, int b3, int c3, int d3, int e3, int a4, int b4, int c4, int d4, int e4)
        {
            this.a1 = a1;
            this.b1 = b1;
            this.c1 = c1;
            this.d1 = d1;
            this.e1 = e1;

            this.a2 = a2;
            this.b2 = b2;
            this.c2 = c2;
            this.d2 = d2;
            this.e2 = e2;

            this.a3 = a3;
            this.b3 = b3;
            this.c3 = c3;
            this.d3 = d3;
            this.e3 = e3;

            this.a4 = a4;
            this.b4 = b4;
            this.c4 = c4;
            this.d4 = d4;
            this.e4 = e4;
        }
        public override void Mathematics_SysEqua_Input()
        {
            Console.WriteLine("|         a         |           b          |          c          |          d          |");
            Console.Write("a1="); this.a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b1="); this.b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c1="); this.c1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("d1="); this.d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("e1="); this.e1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("a2="); this.a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2="); this.b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c2="); this.c2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("d2="); this.d2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("e2="); this.e2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("a3="); this.a3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b3="); this.b3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c3="); this.c3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("d3="); this.d3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("e3="); this.e3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("a4="); this.a4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b4="); this.b4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c4="); this.c4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("d4="); this.d4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("e4="); this.e4 = Convert.ToDouble(Console.ReadLine());
        }

        public override void Mathematics_SysEqua_Output()
        {
            base.Mathematics_SysEqua_Output();
            Console.WriteLine(this.Variables);
        }
        public override void Mathematics_SysEqua_solving()
        {
            this.Variables = Mathematics_SysEqua_step4(this.a1, this.b1, this.c1, this.d1, this.e1, this.a2, this.b2, this.c2, this.d2, this.e2,
                this.a3, this.b3, this.c3, this.d3, this.e3, this.a4, this.b4, this.c4, this.d4, this.e4);
        }
    }
}

