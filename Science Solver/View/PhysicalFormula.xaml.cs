using Science_Solver.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Science_Solver.View
{
    /// <summary>
    /// Interaction logic for PhysicalFormula.xaml
    /// </summary>
    public partial class PhysicalFormula : UserControl
    {
        public PhysicalFormula()
        {
            InitializeComponent();
            this.DataContext = new PhysicalFormulaVM();
        }

        private void Information_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
