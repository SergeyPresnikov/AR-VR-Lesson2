using MyCompony.Employee;
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

namespace MyCompanyControls
{
    /// <summary>
    /// Логика взаимодействия для EmployeeControl.xaml
    /// </summary>
    public partial class EmployeeControl : UserControl
    {
        private Employee employee;
        public EmployeeControl()
        {
            InitializeComponent();
            cbDepartment.ItemsSource = Enum.GetValues(typeof(DepartmentCategory)).Cast<DepartmentCategory>();
        }

        public void SetContact(Employee employee)
        {
            this.employee = employee;


            tbFirstName.Text = employee.FirstName;
            tbLastName.Text = employee.LastName;
            tbSecondName.Text = employee.SecondName;
            cbDepartment.SelectedItem = employee.Category;

        }

        public void UpdateContact()
        {

            employee.FirstName = tbFirstName.Text;
            employee.LastName = tbLastName.Text;
            employee.SecondName = tbSecondName.Text;
            employee.Category = (DepartmentCategory)cbDepartment.SelectedItem;




        }
    }
}
