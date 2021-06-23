using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyCompony.Employee
{
    

    public class Employee : INotifyPropertyChanged, ICloneable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    
        private string _firstName;
        private string _lastName;
        private string _secondName;
        private DepartmentCategory _category = DepartmentCategory.Терапевтическое;


        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Отчество
        /// </summary>
        public string SecondName
        {
            get { return _secondName; }
            set
            {
                _secondName = value;
                NotifyPropertyChanged();
            }
        }


        /// <summary>
        /// Категория
        /// </summary>
        public DepartmentCategory Category
        {
            get { return _category; }
            set
            {
                _category = value;
                NotifyPropertyChanged();
            }
        }

        public Employee() { }

        public Employee(string lastName, string firstName, string secondName,  DepartmentCategory category)
        {
            LastName = lastName;
            FirstName = firstName;
            SecondName = secondName;
            Category = category;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {SecondName}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

