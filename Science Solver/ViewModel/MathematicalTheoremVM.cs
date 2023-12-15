using Science_Solver.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Science_Solver.ViewModel
{
    public class MathematicalTheoremVM : BaseViewModel
    {
        public MathematicalTheoremLinq mtq = new MathematicalTheoremLinq();

        private string _infor = "";
        private DataTable _dtMathematicalTheorems = new DataTable();
        public ICommand FindoutTheoremByInfor { get; set; }
        public ICommand AllMathematicalTheoremaCommand { get; set; }
        public string Infor
        {
            get => _infor;
            set 
            { 
                _infor = value; 
                OnPropertyChanged(nameof(Infor)); 
            }
        }
        public DataTable dtMathematicalTheorems
        {
            get => _dtMathematicalTheorems;
            set { _dtMathematicalTheorems = value; OnPropertyChanged(nameof(dtMathematicalTheorems)); }
        }
        public MathematicalTheoremVM()
        {
            FindoutTheoremByInfor = new RelayCommand<Action>(ExecuteFindoutTheoremByInfor);
            AllMathematicalTheoremaCommand = new RelayCommand<Action>(ExecuteAllMathematicalTheoremaCommand);
        }

        private void ExecuteAllMathematicalTheoremaCommand(Action action)
        {
            try
            {
                dtMathematicalTheorems.Rows.Clear();
                dtMathematicalTheorems = mtq.getAllMathematicalTheorem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ExecuteFindoutTheoremByInfor(Action action)
        {
            try
            {
                dtMathematicalTheorems.Rows.Clear();
                dtMathematicalTheorems = mtq.getMathematicalTheoremByInfor(Infor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
