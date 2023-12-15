using Science_Solver.Linq;
using Science_Solver.Model;
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
    public  class PhysicalLawVM :BaseViewModel
    {
        PhysicalLawLinq physicalLawLinq = new PhysicalLawLinq();
        private string _infor = "";
        private DataTable _dtPhysicalLaws = new DataTable();
        public ICommand FindoutLawByInfor { get; set; }
        public ICommand AllPhysicalLawsCommand { get; set; }
        public string Infor
        {
            get => _infor;
            set
            {
                _infor = value;
                OnPropertyChanged(nameof(Infor));
            }
        }

        public DataTable dtPhysicalLaws 
        { 
            get => _dtPhysicalLaws; 
            set
            {
                _dtPhysicalLaws = value;
                OnPropertyChanged(nameof(dtPhysicalLaws));
            } 
        }
        public PhysicalLawVM()
        {
            FindoutLawByInfor = new RelayCommand<Action>(ExecuteFindoutLawByInfor);
            AllPhysicalLawsCommand = new RelayCommand<Action>(ExecuteAllPhysicalLawsCommand);

        }

        private void ExecuteAllPhysicalLawsCommand(Action action)
        {
            try
            {
                dtPhysicalLaws.Rows.Clear();
                dtPhysicalLaws = physicalLawLinq.getAllPhysicalLaw();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteFindoutLawByInfor(Action action)
        {
            try
            {
                if (Infor == "")
                    return;
                else
                {
                    dtPhysicalLaws.Rows.Clear();
                    dtPhysicalLaws = physicalLawLinq.getPhysicalFormulaByInfor(Infor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
