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
    public class ChemicalConstantVM : BaseViewModel
    {

        public ChemicalConstantLinq CCQ = new ChemicalConstantLinq();


        private string _sign = "";
        private string _name = "";
        private DataTable _dtChemicalConstant = new DataTable();
        public ICommand AllConstantCommand { get; set; }
        public ICommand FindoutConstantBySign { get; set; }
        public ICommand FindoutConstantByName { get; set; }
        public string Sign
        {
            get => _sign;
            set
            {
                _sign = value;
                OnPropertyChanged(nameof(Sign));
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public DataTable dtChemicalConstant
        {
            get => _dtChemicalConstant;
            set
            {
                _dtChemicalConstant = value;
                OnPropertyChanged(nameof(dtChemicalConstant));
            }
        }
        public ChemicalConstantVM()
        {
            AllConstantCommand = new RelayCommand<Action>(ExecuteAllConstantCommand);
            FindoutConstantBySign = new RelayCommand<Action>(ExecuteFindoutConstantBySign);
            FindoutConstantByName = new RelayCommand<Action>(ExecuteFindoutConstantByName);
        }

        private void ExecuteFindoutConstantByName(Action action)
        {
            try
            {
                dtChemicalConstant.Rows.Clear();
                dtChemicalConstant = CCQ.getChemicalConstantByName(Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteFindoutConstantBySign(Action action)
        {
            try
            {
                dtChemicalConstant.Rows.Clear();
                dtChemicalConstant = CCQ.getChemicalConstantBySign(Sign);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteAllConstantCommand(Action action)
        {
            try
            {
                dtChemicalConstant.Rows.Clear();
                dtChemicalConstant = CCQ.getAllChemicalConstant();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
