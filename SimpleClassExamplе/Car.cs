using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExamplе
{
    class Car
    {
        //Состояние объекта Car
        public string petName;
        public int currSpeed;

        public void PrintState()
            //PrintState - выводит текущее состояние объекта Car в окно командной строки
        {
            Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        }
        public void SpeedUp(int delta)
            // Увеличивает скорость Car, увеличимвая на величину, переданную во входящем параметре типа int
        {
            currSpeed += delta;
        }
    }

    

}
