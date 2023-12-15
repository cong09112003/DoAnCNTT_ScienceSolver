using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science_Solver.AppModel
{
    public class MathematicalEquationDegree1 : MathematicalEquation
    {
        public void Input(double a, double b)
        {
            this.A = a;
            this.B = b;
        }
        public override void MathematicalEquation_Input()
        {
            throw new NotImplementedException();
        }

        public override void MathematicalEquation_Solving()
        {
            this.Varible = MathematicalEquation_SolvingDegree1(this.A, this.B);
        }
        ~MathematicalEquationDegree1()
        { }
    }
}
