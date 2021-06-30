using MyCompany.Communication.MyCopmanyService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class EmployeeControl : UserControl, INotifyPropertyChanged
    {
        private Employee _employee;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        public Employee Employee
        {
            get { return _employee; }
            set
            {
                _employee = value;
                NotifyPropertyChanged();
            }
        }

        public ObservableCollection<DepartmentCategory> CategoryList { get; set; } = new ObservableCollection<DepartmentCategory>();


        public EmployeeControl()
        {
            InitializeComponent();
            this.DataContext = this;

            CategoryList.Add(DepartmentCategory.Терапевтическое);
            CategoryList.Add(DepartmentCategory.Неврологическое);
            CategoryList.Add(DepartmentCategory.Инфекционное);
            CategoryList.Add(DepartmentCategory.Урологическое);
            CategoryList.Add(DepartmentCategory.Хирургическое);

        }
  
    }
}
