using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF_Practice
{
    public class Employee : INotifyPropertyChanged
    {
        private string name;
        private string title;
        private DateTime startDate;

        public string Name { get { return name; } set { name = value; OnPropertyChanged(); } }
        public string Title { get { return title; } set { title = value; OnPropertyChanged(); } }
        public DateTime StartDate { get { return startDate; } set { startDate = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        public static Employee GetEmployee()
        {
            return new Employee()
            {
                Name = "Steven",
                Title = "Application Developer"
            };
        }

        public static ObservableCollection<Employee> GetEmployees()
        {
            //By using ObservableCollection, view is notified on additions or deletions to collection
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { Name = "Barbara", Title = "Cleaner", StartDate = new DateTime(2004,10,10) });
            employees.Add(new Employee() { Name = "Daniel", Title = "Developer", StartDate = new DateTime(2005, 4, 5) });
            employees.Add(new Employee() { Name = "Jeff", Title = "Solutions Analyst", StartDate = new DateTime(2006, 10, 4) });
            employees.Add(new Employee() { Name = "Gregory", Title = "Project Manager", StartDate = new DateTime(2007, 3, 2) });
            employees.Add(new Employee() { Name = "Jennifer", Title = "HR Advisor", StartDate = new DateTime(2008, 10, 12) });
            employees.Add(new Employee() { Name = "James", Title = "Reporting Analyst", StartDate = new DateTime(2009, 10, 16) });
            employees.Add(new Employee() { Name = "Alec", Title = "Scrum Master", StartDate = new DateTime(2010, 12, 19) });
            return employees;
        }

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
