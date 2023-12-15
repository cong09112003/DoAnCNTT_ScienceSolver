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
    public class ChemicalEquationVM : BaseViewModel
    {
        public ChemicalEquationsLinq chemicalEquationsLinq = new ChemicalEquationsLinq();

        private string _precursors = "";
        private string _equation = "";
        private string _listEquations = "";
        private DataTable _dtChemicalEquations = new DataTable();


        public ICommand FindoutEquationsByPrecursorsCommand { get; set; }
        public ICommand AllChemicalEquationsCommand {  get; set; }


        public string Precursors
        {
            get => _precursors;
            set
            {
                _precursors = value;
                OnPropertyChanged(nameof(Precursors));
            }
        }
        public string Equation
        {
            get => _equation;
            set
            {
                _equation = value;
                OnPropertyChanged(nameof(Equation));
            }
        }
        public string ListEquations
        {
            get => _listEquations;
            set
            {
                _listEquations = value;
                OnPropertyChanged(nameof(ListEquations));
            }
        }
        public DataTable dtChemicalEquations
        {
            get => _dtChemicalEquations;
            set
            {
                _dtChemicalEquations = value;
                OnPropertyChanged(nameof(dtChemicalEquations));
            }
        }
        public ChemicalEquationVM()
        {
            FindoutEquationsByPrecursorsCommand = new RelayCommand<Action>(ExecuteFindoutEquationsByPrecursorsCommand);
            AllChemicalEquationsCommand = new RelayCommand<Action>(ExecuteAllChemicalEquationsCommand);
        }

        private void ExecuteAllChemicalEquationsCommand(Action action)
        {
            try
            {
                dtChemicalEquations.Rows.Clear();
                dtChemicalEquations = chemicalEquationsLinq.getAllChemicalEquations();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteFindoutEquationsByPrecursorsCommand(Action action)
        {
            try
            {
                dtChemicalEquations.Rows.Clear();
                dtChemicalEquations = chemicalEquationsLinq.getAllChemicalEquations();
                ChemicalEquation cq = chemicalEquationsLinq.GetChemicalEquationsByPrecursors(Precursors);
                Equation = cq.Precursors;
                if (cq.Precursors != null)
                {
                    try
                    {
                        string[] res = cq.ChemicalEquation1.Split('/');
                        for (int i = 0; i < res.Length; i++)
                        {
                            ListEquations += res[i] + '\n';
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else return;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
