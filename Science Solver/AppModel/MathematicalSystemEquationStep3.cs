using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science_Solver.AppModel
{
    public class MathematicalSystemEquationStep3:MathematicalSystemEquation
    {
        public MathematicalSystemEquationStep3()
        { }
        ~MathematicalSystemEquationStep3()
        { }
        public MathematicalSystemEquationStep3(int a1, int b1, int c1, int d1, int a2, int b2, int c2, int d2, int a3, int b3, int c3, int d3)
        {
            this.a1 = a1;
            this.b1 = b1;
            this.c1 = c1;
            this.d1 = d1;

            this.a2 = a2;
            this.b2 = b2;
            this.c2 = c2;
            this.d2 = d2;

            this.a3 = a3;
            this.b3 = b3;
            this.c3 = c3;
            this.d3 = d3;
        }
        public void Input1(int a1, int b1, int c1, int d1, int a2, int b2, int c2, int d2, int a3, int b3, int c3, int d3)
        {
            this.a1 = a1;
            this.b1 = b1;
            this.c1 = c1;
            this.d1 = d1;

            this.a2 = a2;
            this.b2 = b2;
            this.c2 = c2;
            this.d2 = d2;

            this.a3 = a3;
            this.b3 = b3;
            this.c3 = c3;
            this.d3 = d3;
        }
        public override void Mathematics_SysEqua_Input()
        {
            Console.WriteLine("|         a         |           b          |          c          |          d          |");
            Console.Write("a1="); this.a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b1="); this.b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c1="); this.c1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("d1="); this.d1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("a2="); this.a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2="); this.b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c2="); this.c2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("d2="); this.d2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("a3="); this.a3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b3="); this.b3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c3="); this.c3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("d3="); this.d3 = Convert.ToDouble(Console.ReadLine());
        }

        public override void Mathematics_SysEqua_Output()
        {
            base.Mathematics_SysEqua_Output();
            Console.WriteLine(this.Variables);
        }
        public override void Mathematics_SysEqua_solving()
        {
            this.Variables = Mathematics_SysEqua_step3(this.a1, this.b1, this.c1, this.d1, this.a2, this.b2, this.c2, this.d2, this.a3, this.b3, this.c3, this.d3);
        }
    }
}
