using Science_Solver.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Science_Solver.ViewModel
{
    public class MathematicalFormulaVM:BaseViewModel
    {
        MathematicalFormulaLinq mfq = new MathematicalFormulaLinq();

        private string _infor = "";
        private DataTable _dtMathematicalFormulas = new DataTable();
        public ICommand FindoutFormulaByInfor { get; set; }
        public ICommand AllMathematicalFormulaCommand { get; set; }
        public string Infor
        {
            get => _infor;
            set
            {
                _infor = value;
                OnPropertyChanged(nameof(Infor));
            }
        }
        public DataTable dtMathematicalFormulas
        {
            get => _dtMathematicalFormulas;
            set { _dtMathematicalFormulas = value; OnPropertyChanged(nameof(dtMathematicalFormulas)); }
        }
        public MathematicalFormulaVM()
        {
            FindoutFormulaByInfor = new RelayCommand<Action>(ExecuteFindoutFormulaByInfor);
            AllMathematicalFormulaCommand = new RelayCommand<Action>(ExecuteAllMathematicalFormulaCommand);
        }

        private void ExecuteAllMathematicalFormulaCommand(Action action)
        {
            try
            {
                dtMathematicalFormulas.Rows.Clear();
                dtMathematicalFormulas = mfq.getAllMathematicalTheorem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ExecuteFindoutFormulaByInfor(Action action)
        {
            try
            {
                dtMathematicalFormulas.Rows.Clear();
                dtMathematicalFormulas = mfq.getMathematicalTheoremByInfor(Infor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
