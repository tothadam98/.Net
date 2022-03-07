using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using EmployeeApp.ViewModel;
using System.Windows;
namespace EmployeeApp
{
    public partial class MainWindow : Window
    {
        EmployeeViewModel employeeViewModel;
        public MainWindow()
        {
            InitializeComponent();
            employeeViewModel = new EmployeeViewModel();
            DataContext = employeeViewModel;
        }
    }
}