using System.Windows.Controls;

namespace WPF_Practice
{
    /// <summary>
    /// Interaction logic for OneWayDataBinding.xaml
    /// </summary>
    public partial class OneWayDataBinding : Page
    {
        public OneWayDataBinding()
        {
            InitializeComponent();

            DataContext = Employee.GetEmployee();
        }
    }
}
