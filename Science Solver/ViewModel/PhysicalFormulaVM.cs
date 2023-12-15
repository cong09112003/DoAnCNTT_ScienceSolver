using Science_Solver.AppModel;
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
    public class PhysicalFormulaVM:BaseViewModel
    {
        PhysicalFormulaLinq PhysicalFormulaLinq = new PhysicalFormulaLinq();

        private string _infor="";
        private DataTable _dtPhysicalFormulas = new DataTable();
        public ICommand FindoutFormulaByInfor {  get; set; }
        public ICommand AllPhysicalFormulaCommand {  get; set; }
        public string Infor
        { 
            get => _infor;  
            set
            {
                _infor = value;
                OnPropertyChanged(nameof(Infor));
            }
        }

        public DataTable dtPhysicalFormulas 
        { 
            get => _dtPhysicalFormulas;
            set
            {
                _dtPhysicalFormulas = value;
                OnPropertyChanged(nameof(dtPhysicalFormulas));
            }
        }

        public PhysicalFormulaVM() 
        {
            FindoutFormulaByInfor = new RelayCommand<Action>(ExecuteFindoutFormulaByInfor);
            AllPhysicalFormulaCommand = new RelayCommand<Action>(ExecuteAllPhysicalFormulaCommand);
        }

        private void ExecuteAllPhysicalFormulaCommand(Action action)
        {
            try
            {
                dtPhysicalFormulas.Rows.Clear();
                dtPhysicalFormulas = PhysicalFormulaLinq.getAllPhysicalFormula();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ExecuteFindoutFormulaByInfor(Action action)
        {
            try
            {
                if (Infor == "")
                    return;
                else
                {
                    dtPhysicalFormulas.Rows.Clear();
                    dtPhysicalFormulas = PhysicalFormulaLinq.getPhysicalFormulaByInfor(Infor);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadAllData()
        {

        }
    }
}
