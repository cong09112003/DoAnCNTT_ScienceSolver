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
    /// Interaction logic for Degree2.xaml
    /// </summary>
    public partial class Degree2 : UserControl
    {
        public Degree2()
        {
            InitializeComponent();
            this.DataContext = new Degree2VM();
        }
    }
}
