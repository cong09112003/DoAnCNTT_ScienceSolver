using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science_Solver.AppModel
{
    public class MathematicalEquationDegree4 : MathematicalEquation
    {
        public void Input(double a, double b,double c, double d,double e)
        {
            this.A = a; 
            this.B = b;
            this.C = c;
            this.D = d;
            this.E = e;
        }
        public override void MathematicalEquation_Input()
        {
            throw new NotImplementedException();
        }

        public override void MathematicalEquation_Solving()
        {
            this.Varible = MathematicalEquation_Solving_Degree4(this.A, this.B, this.C, this.D, this.E);
        }
        ~MathematicalEquationDegree4()
        { }
    }
}
