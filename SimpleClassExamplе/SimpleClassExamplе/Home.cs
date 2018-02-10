using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExamplе
{
    class Home
    {
        public string street;
        public int number;

        public void PrintState()
        //PrintState - выводит текущее состояние объекта Car в окно командной строки
        {
            Console.WriteLine("{0} is has {1} number.", street, number);
        }

        public Home()
        {
            street = "Pushkina";
            number = 12;
        }

        public Home(string Lenina)
        {
            street = Lenina;
        }

        public Home(string Stalina, int nyam)
        {
            street = Stalina;
            number = nyam;
        }
    }
}
