using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracWork2 {
    class Program {
        static void Main(string[] args) {
            double x, R;
            int distance, days = 234, twoDigitNumber, fourDigitNumber;
            try { 
            Console.WriteLine("Введите значение x.");
            x = Convert.ToInt32(Console.ReadLine());

            TaskOne(x);

            Console.WriteLine("\nВведите радиус окружности.");
            R = Convert.ToInt32(Console.ReadLine());

            TaskTwo(R);

            Console.WriteLine("\nВведите раcстояние в сантиметрах.");
            distance = Convert.ToInt32(Console.ReadLine());

            TaskThree(distance);


            TaskFour(days);


            Console.WriteLine("\nВведите двузначное число.");
            twoDigitNumber = Convert.ToInt32(Console.ReadLine());

            TaskFive(twoDigitNumber);

            Console.WriteLine("\nВведите четырехзначное число.");
            fourDigitNumber = Convert.ToInt32(Console.ReadLine());

            TaskSix(fourDigitNumber);
            }
            catch
            {
                Console.WriteLine("Ошибка преобразования");
            }
            Console.ReadLine();
        }

        public static void TaskOne(double x) {
            double y = (7 * Math.Pow(x, 2) - (3 * x) + 4);

            Console.WriteLine("По формуле \"7x^2-3x+4\"");
            Console.WriteLine("у = " + y);
        }

        public static void TaskTwo(double R) {
            double S = Math.PI * Math.Pow(R, 2);
            double C = 2 * Math.PI * R;

            Console.WriteLine("Площадь окружности: " + S);
            Console.WriteLine("Длина окружности: " + C);
        }

        public static void TaskThree(double distance) {
            int distanceInMeter = 0;
            while(distance >= 100) {
                distanceInMeter++;
                distance -= 100;
            }

            Console.WriteLine("Дистанция в полных метрах: " + distanceInMeter);
        }

        public static void TaskFour(double days) {
            int daysInWeek = 0;
            while (days >= 7) {
                daysInWeek++;
                days -= 7;
            }

            Console.WriteLine("234 дня недель в нем: " + daysInWeek);
        }

        public static void TaskFive(int twoDigitNumber) {
            int sumOfNumbers = 0, comprositionOfNumber = 1;
            int countOfOne = 0;
            while (twoDigitNumber != 0) {
                sumOfNumbers += twoDigitNumber % 10;
                if (twoDigitNumber % 10 == 1)
                {
                    countOfOne++;
                }
                comprositionOfNumber *= twoDigitNumber % 10;
                twoDigitNumber /= 10;
            }
            Console.WriteLine("Кол-во единиц: " + countOfOne);
            Console.WriteLine("Сумма цифр: " + sumOfNumbers);
            Console.WriteLine("Произведение цифр: " + comprositionOfNumber);
        }

        public static void TaskSix(int fourDigitNumber) {
            int sumOfNumbers = 0, comprositionOfNumber = 1;
            while (fourDigitNumber != 0) {
                sumOfNumbers += fourDigitNumber % 10;
                comprositionOfNumber *= fourDigitNumber % 10;
                fourDigitNumber /= 10;
            }

            Console.WriteLine("Сумма цифр: " + sumOfNumbers);
            Console.WriteLine("Произведение цифр: " + comprositionOfNumber);

        }


    }
}
