using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    enum Month
    {
        Январь, Февраль, Март, Апрель, Май, Июнь,
        Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь
    }

    class Program
    {

        static void Main()
        {
            Month i;
            for (i = Month.Январь; i <= Month.Декабрь; i++)
                Console.WriteLine($"{(int)i}\t{i}");
            Console.Read();
        }
    }
}


