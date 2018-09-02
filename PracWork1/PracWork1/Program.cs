using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracWork1 {
    class Program {
        static void Main(string[] args) {
            int SumOfNumbers = 0;
            int counter = 0;

            Console.WriteLine("Темирлан");
            Console.WriteLine("Сулейменов");
            
            Console.WriteLine("Введите 10 чисел");
            try {
                while (counter++ < 10)
                {
                    SumOfNumbers += Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Сумма чисел: " + SumOfNumbers);
            }

            catch {
                Console.WriteLine("Ошибка преобразования");
            }
            Console.ReadLine();
        }
    }
}
