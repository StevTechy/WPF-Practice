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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Practice.Animation
{
    /// <summary>
    /// Interaction logic for Animation.xaml
    /// </summary>
    public partial class Animation : Window
    {
        public Animation()
        {
            InitializeComponent();

            DoubleAnimation animation = new DoubleAnimation()
            {
                From = 0,
                To = 200,
                //TimeSpan.Parse (hours:minutes:seconds)
                Duration = new Duration(TimeSpan.Parse("0:0:5")),
                AutoReverse = true,
                RepeatBehavior = new RepeatBehavior(TimeSpan.Parse("0:0:20"))
            };
            ellipse.BeginAnimation(System.Windows.Controls.Canvas.LeftProperty, animation);
        }
    }
}
