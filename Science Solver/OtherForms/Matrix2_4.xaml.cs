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
    /// Interaction logic for Matrix2_4.xaml
    /// </summary>
    public partial class Matrix2_4 : Window
    {
        private double _ma0_0 = new double();
        private double _ma0_1 = new double();
        private double _ma0_2 = new double();
        private double _ma0_3 = new double();

        private double _ma1_0 = new double();
        private double _ma1_1 = new double();
        private double _ma1_2 = new double();
        private double _ma1_3 = new double();
        public Matrix2_4()
        {
            InitializeComponent();
        }

        public double Ma0_0 { get => _ma0_0; set => _ma0_0 = value; }
        public double Ma0_1 { get => _ma0_1; set => _ma0_1 = value; }
        public double Ma0_2 { get => _ma0_2; set => _ma0_2 = value; }
        public double Ma0_3 { get => _ma0_3; set => _ma0_3 = value; }
        public double Ma1_0 { get => _ma1_0; set => _ma1_0 = value; }
        public double Ma1_1 { get => _ma1_1; set => _ma1_1 = value; }
        public double Ma1_2 { get => _ma1_2; set => _ma1_2 = value; }
        public double Ma1_3 { get => _ma1_3; set => _ma1_3 = value; }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Ma0_0 = Double.Parse(value0_0.Text);
                Ma0_1 = Double.Parse(value0_1.Text);
                Ma0_2 = Double.Parse(value0_2.Text);
                Ma0_3 = Double.Parse(value0_3.Text);

                Ma1_0 = Double.Parse(value1_0.Text);
                Ma1_1 = Double.Parse(value1_1.Text);
                Ma1_2 = Double.Parse(value1_2.Text);
                Ma1_3 = Double.Parse(value1_3.Text);
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
