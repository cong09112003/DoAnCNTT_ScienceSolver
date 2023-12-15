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
    public class PhysicalConstantVM : BaseViewModel
    {
        public PhysicalConstantLinq PhysicalConstantLinq = new PhysicalConstantLinq();

        private string _sign = "";
        private string _name = "";
        private DataTable _dtPhysicalConstant = new DataTable();

        public ICommand FindoutConstantBySymbol { get; set; }
        public ICommand FindoutConstantByName { get; set; }
        public ICommand AllConstantCommand { get; set; }




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
        public DataTable dtPhysicalConstant
        {
            get => _dtPhysicalConstant;
            set
            {
                _dtPhysicalConstant = value;
                OnPropertyChanged(nameof(dtPhysicalConstant));
            }
        }
        public PhysicalConstantVM()
        {
            FindoutConstantBySymbol = new RelayCommand<Action>(ExecuteFindoutConstantBySymbol);
            FindoutConstantByName = new RelayCommand<Action>(ExecuteFindoutConstantByName);
            AllConstantCommand = new RelayCommand<Action>(ExecuteAllConstantCommand);

        }

        private void ExecuteAllConstantCommand(Action action)
        {
            try
            {
                dtPhysicalConstant.Rows.Clear();
                dtPhysicalConstant = PhysicalConstantLinq.getAllPhysicalConstant();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }   
        }

        private void ExecuteFindoutConstantByName(Action action)
        {
            dtPhysicalConstant.Rows.Clear();
            if (Name == "")
            {
                return;
            }
            dtPhysicalConstant = PhysicalConstantLinq.getPhysicalConstantByName(Name);
        }

        private void ExecuteFindoutConstantBySymbol(Action action)
        {
            dtPhysicalConstant.Rows.Clear();
            if (Sign == "") 
            {
                return;
            }
            dtPhysicalConstant = PhysicalConstantLinq.getPhysicalConstantBySign(Sign);

        }
    }
}
