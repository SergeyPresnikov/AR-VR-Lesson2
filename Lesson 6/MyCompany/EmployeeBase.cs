using MyCompony.Employee;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    public class EmployeeBase
    {
        private static int CHAR_BOUND_L = 65; // Номер начального символа (для генерации последовательности символов)
        private static int CHAR_BOUND_H = 90; // Номер конечного  символа (для генерации последовательности символов)
        private Random random = new Random();

        public ObservableCollection<Employee> Staff { get; set; }

        public EmployeeBase()
        {
            Staff = new ObservableCollection<Employee>();
            GenerateContacts(15);
        }


        private string GenerateSymbols(int amount)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < amount; i++)
                stringBuilder.Append((char)(CHAR_BOUND_L + random.Next(CHAR_BOUND_H - CHAR_BOUND_L)));
            return stringBuilder.ToString();
        }


        private void GenerateContacts(int contactCount)
        {
            Staff.Clear();

            string firstName = GenerateSymbols(random.Next(6) + 5);
            string lastName = GenerateSymbols(random.Next(6) + 5);
            string secondName = GenerateSymbols(random.Next(6) + 5);

            var category = (DepartmentCategory)random.Next(0, 5);

            for (int i = 0; i < contactCount; i++)
            {
                if (random.Next(2) == 0)
                {
                    firstName = GenerateSymbols(random.Next(6) + 5);
                    lastName = GenerateSymbols(random.Next(6) + 5);
                    secondName = GenerateSymbols(random.Next(6) + 5);
                    category = (DepartmentCategory)random.Next(0, 3);

                }
                Staff.Add(new Employee(lastName, firstName , secondName, category));
            }
        }
    }
}
