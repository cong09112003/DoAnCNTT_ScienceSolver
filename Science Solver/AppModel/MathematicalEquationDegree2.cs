using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science_Solver.AppModel
{
    public class MathematicalEquationDegree2:MathematicalEquation
    {
        public void Input(double a, double b,double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public override void MathematicalEquation_Input()
        {
            throw new NotImplementedException();
        }

        public override void MathematicalEquation_Solving()
        {
            this.Varible = MathematicalEquation_SolvingDegree2(this.A, this.B, this.C);
        }
        ~MathematicalEquationDegree2()
        { }
    }
}
