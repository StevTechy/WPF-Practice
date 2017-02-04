using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Practice
{
    public class Employee : INotifyPropertyChanged
    {
        private string name;
        private string title;

        public string Name { get { return name; } set { name = value; OnPropertyChanged(); } }
        public string Title { get { return title; } set { title = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        public static Employee GetEmployee()
        {
            return new Employee()
            {
                Name = "Steven",
                Title = "Application Developer"
            };
        }

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
