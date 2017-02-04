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
    /// Interaction logic for BasicForm.xaml
    /// </summary>
    public partial class BasicForm : Page
    {
        public BasicForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var user = new User();

            user.FullName = txbFullName.Text;

            if (rdoSexMale.IsChecked != null)
                if (Convert.ToBoolean(rdoSexMale.IsChecked))
                    user.Sex = "Male";
            if (rdoSexFemale.IsChecked != null)
                if (Convert.ToBoolean(rdoSexFemale.IsChecked))
                    user.Sex = "Female";

            user.Machines = new List<string>();

            if (chkDesktop.IsChecked != null)
                if (Convert.ToBoolean(chkDesktop.IsChecked))
                    user.Machines.Add("Desktop");
            if (chkLaptop.IsChecked != null)
                if (Convert.ToBoolean(chkLaptop.IsChecked))
                    user.Machines.Add("Laptop");

            if (cmbJob.SelectedItem != null)
                user.Job = cmbJob.SelectedItem.ToString();

            user.PromisedDeliveryDate = clnPromisedDeliveryDate.SelectedDate;

            MessageBox.Show($"Full Name: {user.FullName}, Sex: {user.Sex}, Machines: {string.Join(",", user.Machines)}," +
                $" Job: {user.Job}, Promised Delivery Date: {user.PromisedDeliveryDate}");
        }

        internal class User
        {
            public string FullName { get; set; }
            public string Sex { get; set; }
            public ICollection<string> Machines { get; set; }
            public string Job { get; set; }
            public DateTime? PromisedDeliveryDate { get; set; }
        }
    }


}
