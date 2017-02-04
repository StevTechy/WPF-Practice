using System.Windows;
using System.Windows.Controls;

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

            DataContext = Employee.GetEmployees();
        }

        private void UpdateBinding_Click(object sender, RoutedEventArgs e)
        {
            employee.Name = "Jon";
            employee.Title = "Database Administrator";
        }
    }
}
