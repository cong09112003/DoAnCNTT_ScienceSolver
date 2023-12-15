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
    public class Step2VM:BaseViewModel
    {
        private string _indexA1 = "";
        private string _indexB1 = "";
        private string _indexC1 = "";
        private string _indexA2 = "";
        private string _indexB2 = "";
        private string _indexC2 = "";
        private string _systemEquation1 = "";
        private string _systemEquation2 = "";
        private string _variable1 = "";
        private string _variable2 = "";
        public ICommand SolveCommand {  get; set; }
        public MathematicalSystemEquation mathSysEqua = new MathematicalSystemEquationStep2();
        public string IndexA1 { 
            get => _indexA1; 
            set{
                _indexA1=value;
                OnPropertyChanged(nameof(IndexA1));
            } 
        }
        public string IndexB1 { 
            get => _indexB1; 
            set{
                _indexB1=value;
                OnPropertyChanged(nameof(IndexB1));
            } 
        }
        public string IndexC1 { 
            get => _indexC1; 
            set{
                _indexC1=value;
                OnPropertyChanged(nameof(IndexC1));
            } 
        }
        public string IndexA2 { 
            get => _indexA2; 
            set{
                _indexA2=value;
                OnPropertyChanged(nameof(IndexA2));
            } 
        }
        public string IndexB2 { 
            get => _indexB2; 
            set{
                _indexB2=value;
                OnPropertyChanged(nameof(IndexB2));
            } 
        }
        public string IndexC2 { 
            get => _indexC2; 
            set{
                _indexC2=value;
                OnPropertyChanged(nameof(IndexC2));
            } 
        }

        public string SystemEquation1
        {
            get => _systemEquation1;
            set
            {
                _systemEquation1 = value;
                OnPropertyChanged(nameof(SystemEquation1));
            }
        }
        public string SystemEquation2 
        { 
            get => _systemEquation2;
            set
            {
                _systemEquation2 = value;
                OnPropertyChanged(nameof(SystemEquation2)); 
            }
        }

        public string Variable1 
        { 
            get => _variable1; 
            set{
                _variable1=value;
                OnPropertyChanged(nameof(Variable1));
            } 
        }
        public string Variable2 
        { 
            get => _variable2; 
            set{
                _variable2=value;
                OnPropertyChanged(nameof(Variable2));
            } 
        }

        

        public Step2VM()
        {
            SolveCommand = new RelayCommand<Action>(ExecuteSolveCommand);
            if (IndexA1 == "" || IndexB1 == "" || IndexC1 == "" || IndexA2 == "" || IndexB2 == "" || IndexC2 == "")
            {
                IndexA1 = "2";
                IndexB1 = "5";
                IndexC1 = "10";
                IndexA2 = "3";
                IndexB2 = "6";
                IndexC2 = "12";
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
                if(IndexA1 == ""||IndexB1==""||IndexC1==""|| IndexA2==""||IndexB2==""|| IndexC2 == "")
                {
                    IndexA1 = "2";
                    IndexB1 = "4";
                    IndexC1 = "8";
                    IndexA2 = "3";
                    IndexB2 = "6";
                    IndexC2 = "12";
                }
                mathSysEqua.a1 = double.Parse(IndexA1);
                mathSysEqua.b1 = double.Parse(IndexB1);
                mathSysEqua.c1 = double.Parse(IndexC1);
                mathSysEqua.a2 = double.Parse(IndexA2);
                mathSysEqua.b2 = double.Parse(IndexB2);
                mathSysEqua.c2 = double.Parse(IndexC2);
                mathSysEqua.Mathematics_SysEqua_solving();
                SystemEquation1 = IndexA1 + "x + " + IndexB1 + "y  = " + IndexC1 ;
                SystemEquation2 = IndexA2 + "x + " + IndexB2 + "y  = " + IndexC2 ;
                if (mathSysEqua.Variables.Contains(','))
                {
                    string[] arr = mathSysEqua.Variables.Split(',');
                    Variable1 = arr[0];
                    Variable2 = arr[1]; 
                }
                else
                {
                    Variable1 = mathSysEqua.Variables;
                    Variable2 = mathSysEqua.Variables;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
