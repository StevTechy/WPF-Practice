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

namespace WPF_Practice
{
    /// <summary>
    /// Interaction logic for TwoWayDataBinding.xaml
    /// </summary>
    public partial class TwoWayDataBinding : Page
    {
        private Employee employee;

        public TwoWayDataBinding()
        {
            InitializeComponent();

            employee = Employee.GetEmployee();

            DataContext = employee;
        }

        private void UpdateBinding_Click(object sender, RoutedEventArgs e)
        {
            employee.Name = "Jon";
            employee.Title = "Database Administrator";
        }
    }
}
