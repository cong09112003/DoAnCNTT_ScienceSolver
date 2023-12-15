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
    public class Degree2VM : BaseViewModel
    {
        private string _indexA = "";
        private string _indexB = "";
        private string _indexC = "";
        private string _equation = "";
        private string _variable1 = "";
        public MathematicalEquation mathEqua = new MathematicalEquationDegree2();
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
        public Degree2VM()
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
                if (IndexA == "" || IndexB == ""|| IndexC == "")
                {
                    IndexA = "1";
                    IndexB = "4";
                    IndexC = "4";
                }
                mathEqua.A = double.Parse(IndexA);
                mathEqua.B = double.Parse(IndexB);
                mathEqua.C = double.Parse(IndexC);
                mathEqua.MathematicalEquation_Solving();
                Equation = IndexA + "x^2" + " + " + IndexB + "x + " + IndexC + " = 0 ";
                Variable1 = mathEqua.Varible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
