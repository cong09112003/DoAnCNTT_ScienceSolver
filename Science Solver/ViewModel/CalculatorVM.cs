using System;
using Science_Solver.DBConnection;
using Science_Solver.Linq;
using Science_Solver.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Science_Solver.AppModel;


namespace Science_Solver.ViewModel
{
    public class CalculatorVM : BaseViewModel
    {
        private string _infix ="";
        private string _postfix = "";
        private string _result = "";

        public ICommand SolveCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public string Infix
        {
            get => _infix;
            set
            {
                _infix = value;
                OnPropertyChanged(nameof(Infix));
            }
        }
        public string Postfix
        {
            get => _postfix;
            set
            {
                _postfix = value;
                OnPropertyChanged(nameof(Postfix));
            }
        }
        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }
        public CalculatorVM() 
        {
            Infix="(7!+5*3-4/3+8^2-3)*(8/2) + log(10)*4 + sin(150) ";
            ResetCommand = new RelayCommand<Action>(ExecuteResetCommand);
            SolveCommand = new RelayCommand<Action>(ExecuteSolveCommand);
        }

        private void ExecuteSolveCommand(Action action)
        {
            string str = ExprHelper.FormatExpression(Infix);
            Infix = str.Replace(" ", " ");
            try
            {
                Postfix = Y2Expression.Infix2Postfix(str);
                Result = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(Infix));
            }
            catch(Exception ex) 
            {
                Result = "ERORR"+ex.Message;
            }
        }

        private void ExecuteResetCommand(Action action)
        {
            Infix = "";
            Postfix = "";
            Result = "";
        }
    }
}
