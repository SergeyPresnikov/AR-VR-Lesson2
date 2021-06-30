using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Communication.MyCopmanyService
{
    public partial class Employee : ICloneable
    {
        public Employee() { }

        public Employee(string lastName, string firstName, string secondName, DepartmentCategory category)
        {
            LastName = lastName;
            FirstName = firstName;
            SecondName = secondName;
            Category = category;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
