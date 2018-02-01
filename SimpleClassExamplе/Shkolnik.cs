using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExamplе
{
    class Shkolnik
    {
        public int shkolnikSpeed;
        public string shkolnikName;

        //Связываем конструктор в цепочку
        public Shkolnik() { }
        public Shkolnik(int speed) 
            :this(speed, "") { }
        public Shkolnik(string name) 
            :this(0, name) { }
        //Главный конструктор, использующий необязательные аргументы
        public Shkolnik(int speed = 1, string name = "Сережа")
        {
            if (speed > 5)
            {
                speed = 5;
            }

            shkolnikSpeed = speed;
            shkolnikName = name;
        }
    }
}
