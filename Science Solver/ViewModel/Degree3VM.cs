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
    public class Degree3VM:BaseViewModel
    {
        private string _indexA = "";
        private string _indexB = "";
        private string _indexC = "";
        private string _indexD = "";
        private string _equation = "";
        private string _variable1 = "";
        public MathematicalEquation mathEqua = new MathematicalEquationDegree3();
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
        public Degree3VM()
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
                if (IndexA == "" || IndexB == "" || IndexC == ""||IndexD=="")
                {
                    IndexA = "1";
                    IndexB = "6";
                    IndexC = "8";
                    IndexD = "10";
                }
                mathEqua.A = double.Parse(IndexA);
                mathEqua.B = double.Parse(IndexB);
                mathEqua.C = double.Parse(IndexC);
                mathEqua.D = double.Parse(IndexD);
                mathEqua.MathematicalEquation_Solving();
                Equation = IndexA + "x^3" + " + " + IndexB + "x^2 + " + IndexC +"x + " + IndexD +" = 0 ";
                Variable1 = mathEqua.Varible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
