using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    enum Mathematics
    {
        Add= 1,Subtract,Multiply,Divide
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("1 Сложение");
            Console.WriteLine("2 Вычитание");
            Console.WriteLine("3 Умножение");
            Console.WriteLine("4 Деление");
            int choice = Convert.ToInt32(Console.ReadLine());
            Mathematics ch = (Mathematics)choice;

            double result;
                switch (ch)
            {
                case Mathematics.Add:
                    result = a + b;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case Mathematics.Subtract:
                    result = a - b;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case Mathematics.Multiply:
                    result = a * b;
                    Console.WriteLine($"Результат: {result}");
                    break;
                case Mathematics.Divide:
                    result = a / b;
                    Console.WriteLine($"Результат: {result}");
                    break;
                default: Console.WriteLine("Неверный ввод");
                    break;
            }
            Console.ReadLine();
        }
    }
}
   
