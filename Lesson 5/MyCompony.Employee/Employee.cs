using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompony.Employee
{
    

    public class Employee
    {

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string SecondName { get; set; }

        public string FIO
        {
            get { return $"{LastName} {FirstName} {SecondName}"; }
        }


        /// <summary>
        /// Категория
        /// </summary>
        public DepartmentCategory Category { get; set; } = DepartmentCategory.Терапевтическое;

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
    }
}

