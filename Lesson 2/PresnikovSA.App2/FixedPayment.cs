using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresnikovSA.App2
{
    class FixedPayment : Workers
    {
        public FixedPayment(string surname, string name, float pay)
        {
            Surname = surname;
            Name = name;
            Pay = pay;

        }
        public override void CalculatePay()
        {
            Console.WriteLine($"\n{Surname} {Name}\nЕжемесячная зарплата = { Pay}");
        }

    }
}
