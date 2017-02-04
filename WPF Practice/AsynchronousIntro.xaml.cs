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
    /// Interaction logic for AsynchronousIntro.xaml
    /// </summary>
    public partial class AsynchronousIntro : Page
    {
        public AsynchronousIntro()
        {
            InitializeComponent();
            ComputeStuffASync();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }

        private async void ComputeStuffASync()
        {
            for (;;)
            {
                var sum = 0.0;
                txbMessage.Text = "Computing...";
                await Task.Run(() =>
                {
                    for(var i = 1; i < 20000000; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });

                txbMessage.Text = $"Sum = {sum}";

                await Task.Run(() =>
                {
                    for (var i = 1; i < 20000000; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });

                txbMessage.Text = $"Sum = {sum}";

                await Task.Run(() =>
                {
                    for (var i = 1; i < 20000000; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });

                txbMessage.Text = $"Sum = {sum}";

                await Task.Run(() =>
                {
                    for (var i = 1; i < 20000000; i++)
                    {
                        sum += Math.Sqrt(i);
                    }
                });

                txbMessage.Text = $"Sum = {sum}";
            }
        }
    }
}
