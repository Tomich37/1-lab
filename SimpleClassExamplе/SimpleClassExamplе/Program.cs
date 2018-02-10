using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExamplе
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            // Разместить в памяти и сконфигурировать объект Car
            Car myCar = new Car
            {
                petName = "Henry",
                currSpeed = 10
            };

            // Увеличить скорость автомобиля в нескольуо раз и вывести новое состояние
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            Console.WriteLine("***** Street and numbers for address *****\n");

            Home first = new Home();
            first.PrintState();

            Home second = new Home("Lenina");
            second.PrintState();

            Home third = new Home("Stalina", 666);
            third.PrintState();

            Console.ReadLine();
        }
    }
}
