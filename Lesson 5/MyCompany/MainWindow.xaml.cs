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

namespace MyCompany
{
   

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmployeeBase employeeBase = new EmployeeBase();

        public MainWindow()
        {
            InitializeComponent();

            MyCompanyListView.ItemsSource = employeeBase.Staff;

        }

        private void MyCompanyListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count != 0)
            {
                employeeControl.SetContact((Employee)e.AddedItems[0]);
            }



        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            EmployeeEditor editor = new EmployeeEditor();
            if (editor.ShowDialog() == true)
            {
                employeeBase.Staff.Add(editor.Employee);
                UpdateBinding();
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (MyCompanyListView.SelectedItems.Count < 1)
                return;

            if (MessageBox.Show("Вы действительно желаете удалить?", "Удалить", MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                 MessageBoxResult.Yes)
            {
                employeeBase.Staff.Remove((Employee)MyCompanyListView.SelectedItems[0]);
                UpdateBinding();
            }
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            if (MyCompanyListView.SelectedItems.Count < 1)
                return;

            employeeControl.UpdateContact();
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            MyCompanyListView.ItemsSource = null;
            MyCompanyListView.ItemsSource = employeeBase.Staff;
        }
    }
}
