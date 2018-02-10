using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExamplе
{
    class Motocycle
    {
        public int driverIntesity;
        public string name;
        public void SetDriverName(string name)
        {
            this.name = name;
        }
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntesity; i++)
            {
                Console.WriteLine("Yeeeeeeee Haaaaaaaeew!");
            }
        }
        //Вернуть стандартный конструктор, который будет устанавливать для всех членов данных стандартные значения
        public Motocycle() {}
        // Специальный конструктор
        public Motocycle(int intensity)
        {
            driverIntesity = intensity;
        }


    }
}
