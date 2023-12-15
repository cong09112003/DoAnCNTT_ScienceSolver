using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science_Solver.AppModel
{
    public class MathematicalSystemEquationStep2 :MathematicalSystemEquation
    {
        public MathematicalSystemEquationStep2()
        { }
        ~MathematicalSystemEquationStep2() { }
        public MathematicalSystemEquationStep2(int a1, int b1, int c1, int a2, int b2, int c2)
        {
            this.a1 = a1;
            this.b1 = b1;
            this.c1 = c1;
            this.a2 = a2;
            this.b2 = b2;
            this.c2 = c2;
        }
        public void Input1(int a1, int b1, int c1, int a2, int b2, int c2)
        {
            this.a1 = a1;
            this.b1 = b1;
            this.c1 = c1;
            this.a2 = a2;
            this.b2 = b2;
            this.c2 = c2;
        }
        public override void Mathematics_SysEqua_Input()
        {
            Console.WriteLine("|         a         |           b          |          c          |");
            Console.Write("a1="); this.a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b1="); this.b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c1="); this.c1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("a2="); this.a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b2="); this.b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c2="); this.c2 = Convert.ToDouble(Console.ReadLine());
        }

        public override void Mathematics_SysEqua_Output()
        {
            base.Mathematics_SysEqua_Output();
            Console.WriteLine(this.Variables);
        }
        public override void Mathematics_SysEqua_solving()
        {
            this.Variables = Mathematics_SysEqua_step2(this.a1, this.b1, this.c1, this.a2, this.b2, this.c2);
        }
    }
}
