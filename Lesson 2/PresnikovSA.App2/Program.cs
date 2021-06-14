using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresnikovSA.App2
{/// <summary>
/// 1. Построить три класса (базовый и 2 потомка), описывающих некоторых работников 
/// с почасовой оплатой (один из потомков) и фиксированной оплатой (второй потомок).
///а) Описать в базовом классе абстрактный метод для расчёта среднемесячной заработной платы.
///Для «повременщиков» формула для расчета такова: «среднемесячная заработная плата = 20.8 * 8 * почасовая ставка»,
///для работников с фиксированной оплатой «среднемесячная заработная плата = фиксированная месячная оплата».
///б) Создать на базе абстрактного класса массив сотрудников и заполнить его.
///Пресников С.А.
/// </summary>

    abstract class Workers
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public double Pay { get; set; }
        public abstract void CalculatePay();
    }
    class Program
    {
       
        static void Main(string[] args)
        {

            List<Workers> workers = new List<Workers>();
            workers.Add(new HourlyPayWorker( "Сидоров","Андрей", 123));
            workers.Add(new FixedPayment("Николаенко", "Николай", 25300));
            workers.Add(new HourlyPayWorker("Борак", "Василий", 175));
            workers.Add(new FixedPayment("Ли", "Максим", 49000));
            workers.Add(new HourlyPayWorker("Турок", "Игорь", 110));
            workers.Add(new HourlyPayWorker("Казанцев", "Алексей", 300));
            workers.Add(new FixedPayment("Павлова", "Елена", 27600));
            workers.Add(new FixedPayment("Кожемяко", "Ирина", 22800));
            workers.Add(new FixedPayment("Ким", "Анатолий", 91000));
            workers.Add(new HourlyPayWorker("Бойко", "Антон", 360));
            foreach (Workers worker in workers)
                worker.CalculatePay();
           
            Console.ReadKey();



        }
    }
}