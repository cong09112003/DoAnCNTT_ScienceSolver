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
    public class ChemicalLawVM : BaseViewModel
    {
        public ChemicalLawLinq plq = new ChemicalLawLinq();

        private string _infor = "";
        private DataTable _dtChemicalLaws = new DataTable();
        public ICommand FindoutLawByInfor { get; set; }
        public ICommand AllLawCommand { get; set; }
        public string Infor
        {
            get => _infor;
            set
            {
                _infor = value;
                OnPropertyChanged(nameof(Infor));
            }
        }
        public DataTable dtChemicalLaws
        {
            get => _dtChemicalLaws;
            set
            {
                _dtChemicalLaws = value;
                OnPropertyChanged(nameof(dtChemicalLaws));
            }
        }
        public ChemicalLawVM()
        {
            AllLawCommand = new RelayCommand<Action>(ExecuteAllLawCommand);
            FindoutLawByInfor = new RelayCommand<Action>(ExecuteFindoutLawByInfor);
        }

        private void ExecuteFindoutLawByInfor(Action action)
        {
            try
            {
                dtChemicalLaws.Rows.Clear();
                dtChemicalLaws = plq.getPhysicalFormulaByInfor(Infor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteAllLawCommand(Action action)
        {
            try
            {
                dtChemicalLaws.Rows.Clear();
                dtChemicalLaws = plq.getAllPhysicalLaw();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
