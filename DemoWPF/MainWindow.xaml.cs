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

namespace DemoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Person[] Employees { get; set; }
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            lbMain.ItemsSource = new Person[]
            { new Person() { FirstName = "Ivan", LastName = "Ivanov", Employees = new Person[]
                { new Person() { FirstName = "name1", LastName = "sname1" }, new Person() {FirstName = "name2", LastName = "sname2"} } },
              new Person() {FirstName = "Petr", LastName = "Petrov", Employees = new Person[]
              { new Person() { FirstName = "name3", LastName = "sname3" }, new Person() {FirstName = "name4", LastName = "sname4"} } },
              new Person {FirstName = "Sidor", LastName = "Sidorov", Employees = new Person[]
              { new Person() { FirstName = "name5", LastName = "sname5" }, new Person() {FirstName = "name6", LastName = "sname6"} } } };
        }
    }
}
