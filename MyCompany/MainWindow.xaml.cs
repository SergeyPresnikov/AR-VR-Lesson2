﻿using MyCompany.Communication.MyCopmanyService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private EmployeeBase employeebase = new EmployeeBase();

        public ObservableCollection<Employee> StaffList { get; set; }


        public Employee SelectedEmployee { get; set; }


        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            StaffList = employeebase.Staff;

        }

        private void MyCompanyListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count != 0)
            {
                employeeControl.Employee = (Employee)SelectedEmployee.Clone();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            EmployeeEditor editor = new EmployeeEditor();
            if (editor.ShowDialog() == true)
            {
                if (employeebase.Add(editor.Employee) > 0) ;
                {
                    MyCompanyListView.SelectedItem = editor.Employee;
                    MyCompanyListView.ScrollIntoView(editor.Employee);
                    MessageBox.Show("Запись успешно добавлен.", "Добавление новой записи", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                  
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (MyCompanyListView.SelectedItems.Count < 1)
                return;

            if (MessageBox.Show("Вы действительно желаете удалить?", "Удалить", MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                 MessageBoxResult.Yes)
            {
                if (employeebase.Remove((Employee)MyCompanyListView.SelectedItems[0]) > 0)
                {
                    MessageBox.Show("Запись успешно удалена.", "Удаление записи", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                    
            }
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            if (MyCompanyListView.SelectedItems.Count < 1)
                return;

            if (employeebase.Update(employeeControl.Employee) > 0)
            {
                StaffList[StaffList.IndexOf(SelectedEmployee)] = employeeControl.Employee;
                MessageBox.Show("Запись успешно обновлена.", "Обновление записи", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        } 
    }
}
