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
using System.Windows.Shapes;

namespace Science_Solver.OtherForms
{
    /// <summary>
    /// Interaction logic for Matrix2_1.xaml
    /// </summary>
    public partial class Matrix2_1 : Window
    {
        private double _ma0_0 = new double();
        private double _ma1_0 = new double();
        public Matrix2_1()
        {
            InitializeComponent();
        }
        public double Ma0_0 { get => _ma0_0; set => _ma0_0 = value; }
        public double Ma1_0 { get => _ma0_0; set => _ma0_0 = value; }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Ma0_0 = Double.Parse(value0_0.Text);
                Ma1_0 = Double.Parse(value1_0.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
