using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Science_Solver.Utilities;
using System.Windows.Input;
using System.CodeDom.Compiler;
using System.Threading;
using System.Windows.Baml2006;
using System.Data.SqlClient;

namespace Science_Solver.ViewModel
{
    class NavigationVM:ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get => _currentView; 
            set { 
                _currentView = value; 
                OnPropertyChanged(nameof(CurrentView)); 
            }
        }
        public ICommand HomeCommand { get; }   
        public ICommand AppCommand { get; }
        public ICommand IntroductionCommand { get; }
        //Mathematical changes
        public ICommand CalculatorCommand {  get; }
        
        
        public ICommand Degree1Command {  get; }
        public ICommand Degree2Command { get; }
        public ICommand Degree3Command { get; }

        public ICommand Degree4Command { get; }
        public ICommand Step2Command { get; }
        public ICommand Step3Command { get; }
        public ICommand Step4Command { get; }
        public ICommand MatrixCommand {  get; }
        public ICommand IntegralCommand { get; }
        public ICommand MathematicalFormulaCommand { get; }
        public ICommand MathematicalTheoremCommand { get; }
        //Physical changes
        public ICommand PhysicalUnitsCommand {  get; }
        public ICommand PhysicalConstantCommand { get; }
        public ICommand PhysicalLawCommand {  get; }
        public ICommand PhysicalFormulaCommand { get; }
        //Chemical changes
        public ICommand SearchingElementChemicalCommand { get; }
        public ICommand ChemicalEquationCommand {  get; }
        public ICommand ChemicalConstantCommand {  get; }
        public ICommand ChemicalLawCommand { get; }
        public NavigationVM()
        {
            _currentView=new ViewModelBase();
            //HomeCommand = new RelayCommand(Home);
            //AppCommand = new RelayCommand(App); 
            //IntroductionCommand=new RelayCommand(Introduction);

            //Startup Page
            HomeCommand = new RelayCommand<object>(ExecuteShowHomeViewCommand);
            AppCommand = new RelayCommand<object>(ExecuteShowAppViewCommand);
            IntroductionCommand = new RelayCommand<object>(ExecuteShowIntroductionViewCommand);
            //Mathematical
            CalculatorCommand = new RelayCommand<object>(ExecuteCalculatorCommand);
            Degree1Command = new RelayCommand<object>(ExecuteDegree1Command);
            Degree2Command = new RelayCommand<object>(ExecuteDegree2Command);
            Degree3Command = new RelayCommand<object>(ExecuteDegree3Command);
            Degree4Command = new RelayCommand<object>(ExecuteDegree4Command);
            Step2Command = new RelayCommand<object>(ExecuteStep2Command);
            Step3Command = new RelayCommand<object>(ExecuteStep3Command);
            Step4Command = new RelayCommand<object>(ExecuteStep4Command);
            MatrixCommand = new RelayCommand<object>(ExecuteMatrixCommand);
            IntegralCommand = new RelayCommand<object>(ExecuteIntegralCommand);
            MathematicalFormulaCommand = new RelayCommand<object>(ExecuteMathematicalFormulaCommand);
            MathematicalTheoremCommand = new RelayCommand<object>(ExecuteMathematicalTheoremCommand);
            // Physical Command
            PhysicalUnitsCommand = new RelayCommand<object>(ExecutePhysicalUnitsCommand);
            PhysicalConstantCommand = new RelayCommand<object>(ExecutePhysicalConstantCommand);
            PhysicalFormulaCommand = new RelayCommand<object>(ExecutePhysicalFormulaCommand);
            PhysicalLawCommand = new RelayCommand<object>(ExecutePhysicalLawCommand);
            //Chemical Command
            SearchingElementChemicalCommand = new RelayCommand<object>(ExecuteSearchingElementChemicaCommand);
            ChemicalConstantCommand = new RelayCommand<object>(ExecuteChemicalConstantCommand);
            ChemicalLawCommand = new RelayCommand<object>(ExecuteChemicalLawCommand);
            ChemicalEquationCommand = new RelayCommand<object>(ExecuteChemicalEquationCommand); 
            ExecuteShowUserInforViewCommand(null);
        }

        private void ExecuteChemicalEquationCommand(object obj)
        {
            CurrentView = new ChemicalEquationVM();
        }

        private void ExecuteChemicalLawCommand(object obj)
        {
            CurrentView = new ChemicalLawVM();
        }

        private void ExecuteChemicalConstantCommand(object obj)
        {
            CurrentView = new ChemicalConstantVM();
        }

        private void ExecutePhysicalLawCommand(object obj)
        {
            CurrentView = new PhysicalLawVM();
        }

        private void ExecutePhysicalFormulaCommand(object obj)
        {
            CurrentView = new PhysicalFormulaVM();
        }

        private void ExecutePhysicalConstantCommand(object obj)
        {
            CurrentView = new PhysicalConstantVM();
        }

        private void ExecutePhysicalUnitsCommand(object obj)
        {
            CurrentView = new PhysicalUnitsVM();
        }

        private void ExecuteMathematicalTheoremCommand(object obj)
        {
            CurrentView = new MathematicalTheoremVM();
        }

        private void ExecuteMathematicalFormulaCommand(object obj)
        {
            CurrentView = new MathematicalFormulaVM();
        }

        private void ExecuteIntegralCommand(object obj)
        {
            CurrentView = new IntegralVM();
        }

        private void ExecuteMatrixCommand(object obj)
        {
            CurrentView = new MatrixVM();
        }

        private void ExecuteStep4Command(object obj)
        {
            CurrentView = new Step4VM();
        }

        private void ExecuteStep3Command(object obj)
        {
            CurrentView = new Step3VM();    
        }

        private void ExecuteStep2Command(object obj)
        {
            CurrentView = new Step2VM();
        }

        private void ExecuteDegree4Command(object obj)
        {
            CurrentView = new Degree4VM();
        }

        private void ExecuteDegree3Command(object obj)
        {
            CurrentView = new Degree3VM();
        }

        private void ExecuteDegree2Command(object obj)
        {
           CurrentView = new Degree2VM();
        }

        private void ExecuteDegree1Command(object obj)
        {
           CurrentView =new Degree1VM();
        }

        private void ExecuteCalculatorCommand(object obj)
        {
            CurrentView = new CalculatorVM();
        }

        private void ExecuteSearchingElementChemicaCommand(object obj)
        {
            CurrentView = new ChemicalElementVM();
        }

        private void ExecuteShowUserInforViewCommand(object obj)
        {
            CurrentView=new HomeVM();
        }

        private void ExecuteShowIntroductionViewCommand(object obj)
        {
            CurrentView =new IntroductionVM();
        }

        private void ExecuteShowAppViewCommand(object obj)
        {
            CurrentView=new AppVM();
        }

        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentView = new HomeVM();
        }
    }
}
