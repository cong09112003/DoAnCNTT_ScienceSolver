using Science_Solver.AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Science_Solver.ViewModel
{
    public  class Degree1VM : BaseViewModel
    {
        private string _indexA = "";
        private string _indexB = "";
        private string _equation = "";
        private string _variable1 = "";
        public MathematicalEquation mathEqua= new MathematicalEquationDegree1();
        public ICommand SolveCommand { get; set; }
        public string IndexA 
        { 
            get => _indexA;
            set
            {
                _indexA = value;
                OnPropertyChanged(nameof(IndexA));
            }
        }

        public string IndexB 
        { 
            get => _indexB;
            set
            {
                _indexB = value;
                OnPropertyChanged(nameof(IndexB));
            }
        }

        public string Equation 
        { 
            get => _equation; 
            set
            {
                _equation = value;
                OnPropertyChanged(nameof(Equation));
            } 
        }

        public string Variable1 
        { 
            get => _variable1;
            set
            {
                _variable1 = value;
                OnPropertyChanged(nameof(Variable1));
            }
        }

        public Degree1VM()
        {
            SolveCommand = new RelayCommand<Action>(ExecuteSolveCommand);
            if (IndexA == "" || IndexB == "")
            {
                IndexA = "5";
                IndexB = "10";
            }
            Solve();
        }

        private void ExecuteSolveCommand(Action action)
        {
            Solve();
        }
        public void Solve()
        {
            try
            {
                if (IndexA == "" || IndexB == "")
                {
                    IndexA = "2";
                    IndexB = "4";
                }
                mathEqua.A = double.Parse(IndexA);
                mathEqua.B = double.Parse(IndexB);
                mathEqua.MathematicalEquation_Solving();
                Equation = IndexA + "x" + " + " + IndexB + " = 0 ";
                Variable1 = mathEqua.Varible;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
