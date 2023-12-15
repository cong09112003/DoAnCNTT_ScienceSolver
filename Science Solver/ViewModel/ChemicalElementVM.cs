using Science_Solver.DBConnection;
using Science_Solver.Linq;
using Science_Solver.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Science_Solver.ViewModel
{
    public class ChemicalElementVM : BaseViewModel
    {
        private DataTable _dtChemicalElements = new DataTable();
        public ChemicalElementLinq ChemicalElementLinq = new ChemicalElementLinq();

        public ICommand FindOutCommand { get; set; }
        public ICommand AllElementCommand { get; set; }
        public ICommand FindoutElementByNameAndSymbol { get; set; }
        public ICommand FindoutElementByNumber { get; set; }

        private string _number = "";
        private string _nameAndSymbol = "";
        private string _numberEle = "";
        private string _atomicMassEle = "";
        private string _symbolEle = "";
        private string _nameEle = "";
        public DataTable dtChemicalElements
        {
            get => _dtChemicalElements;
            set
            {
                _dtChemicalElements = value;
                OnPropertyChanged(nameof(dtChemicalElements));
            }
        }

        public string Number 
        { 
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }

        public string NameAndSymbol 
        { 
            get => _nameAndSymbol; 
            set
            {
                _nameAndSymbol = value;
                OnPropertyChanged(nameof(NameAndSymbol));
            }
        }

        public string NumberEle 
        { 
            get => _numberEle; 
            set
            {
                _numberEle = value;
                OnPropertyChanged(nameof(NumberEle));
            }
        }
        public string AtomicMassEle 
        { 
            get => _atomicMassEle; 
            set
            {
                _atomicMassEle = value;
                OnPropertyChanged(nameof(AtomicMassEle));
            }
        }
        public string SymbolEle 
        { 
            get => _symbolEle; 
            set
            {
                _symbolEle = value;
                OnPropertyChanged(nameof(SymbolEle));
            }
        }
        public string NameEle 
        { 
            get => _nameEle; 
            set
            {
                _nameEle = value;
                OnPropertyChanged(nameof(NameEle));
            }
        }

        public ChemicalElementVM()
        {
            AllElementCommand = new RelayCommand<Action>(ExecuteAllElementCommand);
            FindOutCommand = new RelayCommand<Action>(ExecuteFindOutCommand);
            FindoutElementByNumber = new RelayCommand<Action>(ExecuteFindoutElementByNumber);
            FindoutElementByNameAndSymbol = new RelayCommand<Action>(ExecuteFindoutElementByNameAndSymbol);
        }

        private void ExecuteFindoutElementByNameAndSymbol(Action action)
        {
            try { 
                dtChemicalElements.Rows.Clear();
                if (NameAndSymbol == "")
                {
                    return;
                }
                dtChemicalElements = ChemicalElementLinq.getChemicalElementByNameAndSymbol(NameAndSymbol);
                if (dtChemicalElements.Rows.Count == 1)
                    DataElementFromOneRow(dtChemicalElements);
                }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteFindoutElementByNumber(Action action)
        {
            try
            {
                dtChemicalElements.Rows.Clear();
                if (Number == "")
                {
                    return;
                }
                dtChemicalElements = ChemicalElementLinq.getChemicalElementByNumber(int.Parse(Number));
                if (dtChemicalElements.Rows.Count == 1)
                    DataElementFromOneRow(dtChemicalElements);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message) ;
            }
        }

        private void ExecuteAllElementCommand(Action action)
        {
            LoadChemicalElements();
        }

        private void ExecuteFindOutCommand(Action action)
        {
            
        }

        public void LoadChemicalElements()
        {
            try
            {
                this.dtChemicalElements.Rows.Clear();
                dtChemicalElements = ChemicalElementLinq.getAllChemicalElement();
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message);
            }
        }
        public void DataElementFromOneRow(DataTable dt)
        {
            DataRow dr = dt.Rows[0];
            NumberEle = dr["Number"].ToString();
            AtomicMassEle = dr["AtomicMass"].ToString();
            SymbolEle = dr["Symbol"].ToString();
            NameEle = dr["Name"].ToString();
        }
    }
}
