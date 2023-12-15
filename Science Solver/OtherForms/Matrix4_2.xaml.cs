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
    /// Interaction logic for Matrix4_2.xaml
    /// </summary>
    public partial class Matrix4_2 : Window
    {
        private double _ma0_0 = new double();
        private double _ma0_1 = new double();

        private double _ma1_0 = new double();
        private double _ma1_1 = new double();

        private double _ma2_0 = new double();
        private double _ma2_1 = new double();

        private double _ma3_0 = new double();
        private double _ma3_1 = new double();
        public Matrix4_2()
        {
            InitializeComponent();
        }

        public double Ma0_0 { get => _ma0_0; set => _ma0_0 = value; }
        public double Ma0_1 { get => _ma0_1; set => _ma0_1 = value; }
        public double Ma1_0 { get => _ma1_0; set => _ma1_0 = value; }
        public double Ma1_1 { get => _ma1_1; set => _ma1_1 = value; }
        public double Ma2_0 { get => _ma2_0; set => _ma2_0 = value; }
        public double Ma2_1 { get => _ma2_1; set => _ma2_1 = value; }
        public double Ma3_0 { get => _ma3_0; set => _ma3_0 = value; }
        public double Ma3_1 { get => _ma3_1; set => _ma3_1 = value; }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Ma0_0 = Double.Parse(value0_0.Text);
                Ma0_1 = Double.Parse(value0_1.Text);

                Ma1_0 = Double.Parse(value1_0.Text);
                Ma1_1 = Double.Parse(value1_1.Text);

                Ma2_0 = Double.Parse(value2_0.Text);
                Ma2_1 = Double.Parse(value2_1.Text);

                Ma3_0 = Double.Parse(value3_0.Text);
                Ma3_1 = Double.Parse(value3_1.Text);
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
