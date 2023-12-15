using Science_Solver.AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Science_Solver.ViewModel
{
    public class Degree4VM:BaseViewModel
    {
        private string _indexA = "";
        private string _indexB = "";
        private string _indexC = "";
        private string _indexD = "";
        private string _indexE = "";
        private string _equation = "";
        private string _variable1 = "";
        public MathematicalEquation mathEqua = new MathematicalEquationDegree4();
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

        public string IndexC
        {
            get => _indexC;
            set
            {
                _indexC = value;
                OnPropertyChanged(nameof(IndexC));
            }
        }

        public string IndexD
        {
            get => _indexD;
            set
            {
                _indexD = value;
                OnPropertyChanged(nameof(IndexD));
            }
        }

        public string IndexE
        { 
            get => _indexE; 
            set
            {
                _indexE = value;
                OnPropertyChanged(nameof(IndexE));
            }
        }
        public Degree4VM()
        {
            SolveCommand = new RelayCommand<Action>(ExecuteSolveCommand);
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
                if (IndexA == "" || IndexB == "" || IndexC == "" || IndexD == ""|| IndexE=="")
                {
                    IndexA = "1";
                    IndexB = "6";
                    IndexC = "8";
                    IndexD = "10";
                    IndexE = "20";
                }
                mathEqua.A = double.Parse(IndexA);
                mathEqua.B = double.Parse(IndexB);
                mathEqua.C = double.Parse(IndexC);
                mathEqua.D = double.Parse(IndexD);
                mathEqua.E = double.Parse(IndexE);
                mathEqua.MathematicalEquation_Solving();
                Equation = IndexA + "x^4" + " + " + IndexB + "x^3 + " + IndexC + "x^2 + " + IndexD +"x + "+ IndexE + " = 0 ";
                Variable1 = mathEqua.Varible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
