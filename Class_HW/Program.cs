using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            int denomination;
            int countOfNote;
            try
            {
                Console.WriteLine("Введите номинал купюры.");
                denomination = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите кол-во купюр.");
                countOfNote = Convert.ToInt32(Console.ReadLine());

                Money money = new Money(denomination, countOfNote);

                Console.WriteLine("Содержание кошелька.");
                Console.WriteLine("Номинал: " + money.GetDenomination());
                Console.WriteLine("Кол-во: " + money.GetCountOfNote());
                Console.WriteLine("Общая сумма: " + money.GetSumm());





                Console.WriteLine("\nПроверка на возможность приобретения товара по заданой цене.\nВведите цену товара.");
                if (money.CanIBuy(Convert.ToInt32(Console.ReadLine())))
                {
                    Console.WriteLine("У вас хватает денег");
                }
                else Console.WriteLine("У вас не хватает денег!");

                Console.WriteLine("\nПодсчет кол-во товара которую есть возможность приобрести по заданой цене.\nВведите цену товара.");
                Console.WriteLine("Кол-во: " + money.HowMuchCanIBuy(Convert.ToInt32(Console.ReadLine())));

            }
            catch
            {
                Console.WriteLine("Следующий раз введите число\nДосвидания!");
            }

            Console.ReadLine();
        }
    }
}
