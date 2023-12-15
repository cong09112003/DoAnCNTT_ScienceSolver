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
    public class Step4VM:BaseViewModel
    {
        private string _indexA1 = "";
        private string _indexB1 = "";
        private string _indexC1 = "";
        private string _indexD1 = "";
        private string _indexE1 = "";

        private string _indexA2 = "";
        private string _indexB2 = "";
        private string _indexC2 = "";
        private string _indexD2 = "";
        private string _indexE2 = "";

        private string _indexA3 = "";
        private string _indexB3 = "";
        private string _indexC3 = "";
        private string _indexD3 = "";
        private string _indexE3 = "";

        private string _indexA4 = "";
        private string _indexB4 = "";
        private string _indexC4 = "";
        private string _indexD4 = "";
        private string _indexE4 = "";

        private string _systemEquation1 = "";
        private string _systemEquation2 = "";
        private string _systemEquation3 = "";
        private string _systemEquation4 = "";

        private string _variable1 = "";
        private string _variable2 = "";
        private string _variable3 = "";
        private string _variable4 = "";
        public ICommand SolveCommand { get; set; }
        public MathematicalSystemEquation mathSysEqua = new MathematicalSystemEquationStep4();
        public string IndexA1
        {
            get => _indexA1;
            set
            {
                _indexA1 = value;
                OnPropertyChanged(nameof(IndexA1));
            }
        }
        public string IndexB1
        {
            get => _indexB1;
            set
            {
                _indexB1 = value;
                OnPropertyChanged(nameof(IndexB1));
            }
        }
        public string IndexC1
        {
            get => _indexC1;
            set
            {
                _indexC1 = value;
                OnPropertyChanged(nameof(IndexC1));
            }
        }
        public string IndexD1
        {
            get => _indexD1;
            set
            {
                _indexD1 = value;
                OnPropertyChanged(nameof(IndexD1));
            }
        }
        public string IndexE1
        {
            get => _indexE1;
            set
            {
                _indexE1 = value;
                OnPropertyChanged(nameof(IndexE1));
            }
        }

        public string IndexA2
        {
            get => _indexA2;
            set
            {
                _indexA2 = value;
                OnPropertyChanged(nameof(IndexA2));
            }
        }
        public string IndexB2
        {
            get => _indexB2;
            set
            {
                _indexB2 = value;
                OnPropertyChanged(nameof(IndexB2));
            }
        }
        public string IndexC2
        {
            get => _indexC2;
            set
            {
                _indexC2 = value;
                OnPropertyChanged(nameof(IndexC2));
            }
        }
        public string IndexD2
        {
            get => _indexD2;
            set
            {
                _indexD2 = value;
                OnPropertyChanged(nameof(IndexD2));
            }
        }
        public string IndexE2
        {
            get => _indexE2;
            set
            {
                _indexE2 = value;
                OnPropertyChanged(nameof(IndexE2));
            }
        }
        public string IndexA3
        {
            get => _indexA3;
            set
            {
                _indexA3 = value;
                OnPropertyChanged(nameof(IndexA3));
            }
        }
        public string IndexB3
        {
            get => _indexB3;
            set
            {
                _indexB3 = value;
                OnPropertyChanged(nameof(IndexB3));
            }
        }
        public string IndexC3
        {
            get => _indexC3;
            set
            {
                _indexC3 = value;
                OnPropertyChanged(nameof(IndexC3));
            }
        }
        public string IndexD3
        {
            get => _indexD3;
            set
            {
                _indexD3 = value;
                OnPropertyChanged(nameof(IndexD3));
            }
        }
        public string IndexE3
        {
            get => _indexE3;
            set
            {
                _indexE3 = value;
                OnPropertyChanged(nameof(IndexE3));
            }
        }
        public string IndexA4
        {
            get => _indexA4;
            set
            {
                _indexA4 = value;
                OnPropertyChanged(nameof(IndexA4));
            }
        }
        public string IndexB4
        {
            get => _indexB4;
            set
            {
                _indexB4 = value;
                OnPropertyChanged(nameof(IndexB4));
            }
        }
        public string IndexC4
        {
            get => _indexC4;
            set
            {
                _indexC4 = value;
                OnPropertyChanged(nameof(IndexC4));
            }
        }
        public string IndexD4
        {
            get => _indexD4;
            set
            {
                _indexD4 = value;
                OnPropertyChanged(nameof(IndexD4));
            }
        }
        public string IndexE4
        {
            get => _indexE4;
            set
            {
                _indexE4 = value;
                OnPropertyChanged(nameof(IndexE4));
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
        public string SystemEquation3
        {
            get => _systemEquation3;
            set
            {
                _systemEquation3 = value;
                OnPropertyChanged(nameof(SystemEquation3));
            }
        }
        public string SystemEquation4
        {
            get => _systemEquation4;
            set
            {
                _systemEquation4 = value;
                OnPropertyChanged(nameof(SystemEquation4));
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

        public string Variable2
        {
            get => _variable2;
            set
            {
                _variable2 = value;
                OnPropertyChanged(nameof(Variable2));
            }
        }
        public string Variable3
        {
            get => _variable3;
            set
            {
                _variable3 = value;
                OnPropertyChanged(nameof(Variable3));
            }
        }
        public string Variable4
        {
            get => _variable4;
            set
            {
                _variable4 = value;
                OnPropertyChanged(nameof(Variable4));
            }
        }
        
        public Step4VM()
        {
            SolveCommand = new RelayCommand<Action>(ExecuteSolveCommand);
            if (IndexA1 == "" || IndexB1 == "" || IndexC1 == "" || IndexD1 == "" ||IndexE1==""
              || IndexA2 == "" || IndexB2 == "" || IndexC2 == "" || IndexD2 == "" || IndexE2==""
              || IndexA3 == "" || IndexB3 == "" || IndexC3 == "" || IndexD3 == "" || IndexE3==""
              || IndexA4=="" || IndexB4=="" || IndexC4=="" || IndexD4==""||IndexE4=="")
            {
                IndexA1 = "2";
                IndexB1 = "1";
                IndexC1 = "10";
                IndexD1 = "8.4";
                IndexE1 = "68";

                IndexA2 = "3";
                IndexB2 = "8";
                IndexC2 = "33";
                IndexD2 = "9.7";
                IndexE2 = "196";

                IndexA3 = "4";
                IndexB3 = "9";
                IndexC3 = "40";
                IndexD3 = "10.3";
                IndexE3 = "200";

                IndexA4 = "6";
                IndexB4 = "3";
                IndexC4 = "35";
                IndexD4 = "10";
                IndexE4 = "300";
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
                if (IndexA1 == "" || IndexB1 == "" || IndexC1 == "" || IndexD1 == "" || IndexE1 == ""
               || IndexA2 == "" || IndexB2 == "" || IndexC2 == "" || IndexD2 == "" || IndexE2 == ""
               || IndexA3 == "" || IndexB3 == "" || IndexC3 == "" || IndexD3 == "" || IndexE3 == ""
               || IndexA4 == "" || IndexB4 == "" || IndexC4 == "" || IndexD4 == "" || IndexE4 == "")
                {
                    IndexA1 = "2";
                    IndexB1 = "1";
                    IndexC1 = "10";
                    IndexD1 = "8.4";
                    IndexE1 = "68";

                    IndexA2 = "3";
                    IndexB2 = "8";
                    IndexC2 = "33";
                    IndexD2 = "9.7";
                    IndexE2 = "196";

                    IndexA3 = "4";
                    IndexB3 = "9";
                    IndexC3 = "40";
                    IndexD3 = "10.3";
                    IndexE3 = "200";

                    IndexA4 = "6";
                    IndexB4 = "3";
                    IndexC4 = "35";
                    IndexD4 = "10";
                    IndexE4 = "300";
                }
                mathSysEqua.a1 = double.Parse(IndexA1);
                mathSysEqua.b1 = double.Parse(IndexB1);
                mathSysEqua.c1 = double.Parse(IndexC1);
                mathSysEqua.d1 = double.Parse(IndexD1);
                mathSysEqua.e1 = double.Parse(IndexE1);

                mathSysEqua.a2 = double.Parse(IndexA2);
                mathSysEqua.b2 = double.Parse(IndexB2);
                mathSysEqua.c2 = double.Parse(IndexC2);
                mathSysEqua.d2 = double.Parse(IndexD2);
                mathSysEqua.e2 = double.Parse(IndexE2);

                mathSysEqua.a3 = double.Parse(IndexA3);
                mathSysEqua.b3 = double.Parse(IndexB3);
                mathSysEqua.c3 = double.Parse(IndexC3);
                mathSysEqua.d3 = double.Parse(IndexD3);
                mathSysEqua.e3 = double.Parse(IndexE3);

                mathSysEqua.a4 = double.Parse(IndexA4);
                mathSysEqua.b4 = double.Parse(IndexB4);
                mathSysEqua.c4 = double.Parse(IndexC4);
                mathSysEqua.d4 = double.Parse(IndexD4);
                mathSysEqua.e4 = double.Parse(IndexE4);

                mathSysEqua.Mathematics_SysEqua_solving();
                SystemEquation1 = IndexA1 + "x + " + IndexB1 + "y + " + IndexC1 + "z  +" + IndexD1 + "t = " + IndexE1;
                SystemEquation2 = IndexA2 + "x + " + IndexB2 + "y + " + IndexC2 + "z  +" + IndexD2 + "t = " + IndexE2;
                SystemEquation3 = IndexA3 + "x + " + IndexB3 + "y + " + IndexC3 + "z  +" + IndexD3 + "t = " + IndexE3;
                SystemEquation4 = IndexA4 + "x + " + IndexB4 + "y + " + IndexC4 + "z  +" + IndexD4 + "t = " + IndexE4;
                if (mathSysEqua.Variables.Contains(','))
                {
                    string[] arr = mathSysEqua.Variables.Split(',');
                    Variable1 = arr[0];
                    Variable2 = arr[1];
                    Variable3 = arr[2];
                    Variable4 = arr[3];
                }
                else
                {
                    Variable1 = mathSysEqua.Variables;
                    Variable2 = mathSysEqua.Variables;
                    Variable3 = mathSysEqua.Variables;
                    Variable4 = mathSysEqua.Variables;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
