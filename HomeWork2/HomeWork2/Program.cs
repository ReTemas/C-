using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            double R1, R2, U1, U2;
            double massOfTheFirstBody, volumeOfTheFirstBody, massOfTheSecondBody, volumeOfTheSecondBody;
            double R, a;
            int distance, days = 234, twoDigitNumber;
            try {
                TaskOne();

                TaskTwo();

                Console.WriteLine("\nВведите раcстояние в сантиметрах.");
                distance = Convert.ToInt32(Console.ReadLine());

                TaskThree(distance);

                TaskFour(days);

                Console.WriteLine("\nВведите двузначное число.");
                twoDigitNumber = Convert.ToInt32(Console.ReadLine());

                TaskFive(twoDigitNumber);

                TaskSix();

                Console.WriteLine("\nВведите радиус окружности.");
                R = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nВведите сторону квадрата.");
                a = Convert.ToDouble(Console.ReadLine());
                TaskSeven(R, a);

                Console.WriteLine("\nВведите объем первого тела.");
                volumeOfTheFirstBody = Convert.ToDouble(Console.ReadLine());
               
                Console.WriteLine("\nВведите объем второго тела.");
                volumeOfTheSecondBody = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nВведите массу первого тела.");
                massOfTheFirstBody = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nВведите массу второго тела.");
                massOfTheSecondBody = Convert.ToDouble(Console.ReadLine());
                TaskEight(massOfTheSecondBody, volumeOfTheFirstBody, massOfTheSecondBody, volumeOfTheSecondBody);

                Console.WriteLine("\nВведите сопротивление первого участка.");
                R1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nВведите сопротивление второго участка.");
                R2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nВведите напряжение первого участка.");
                U1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nВведите напряжение второго участка.");
                U2 = Convert.ToDouble(Console.ReadLine());
                TaskNine(R1, R2, U1, U2);
            }
            catch
            {
                Console.WriteLine("Ошибка преобразования");
            }
            Console.ReadLine();
        }

        public static void TaskOne()
        {
            Random random = new Random();

            Console.WriteLine($"{"Случайные числа: "}{ random.Next(0, 10) },{" "}{random.Next(0, 10)},{" "}{random.Next(0, 10)}");
        }

        public static void TaskTwo()
        {
            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");
        }

        public static void TaskThree(double distance)
        {
            int distanceInMeter = 0;
            while (distance >= 100)
            {
                distanceInMeter++;
                distance -= 100;
            }

            Console.WriteLine("Дистанция в полных метрах: " + distanceInMeter);
        }

        public static void TaskFour(double days)
        {
            int daysInWeek = 0;
            while (days >= 7)
            {
                daysInWeek++;
                days -= 7;
            }

            Console.WriteLine("234 дня недель в нем: " + daysInWeek);
        }

        public static void TaskFive(int twoDigitNumber)
        {
            int sumOfNumbers = 0, comprositionOfNumber = 1;
            int countOfOne = 0;
            while (twoDigitNumber != 0)
            {
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

        public static void TaskSix()
        {
            bool A = true;
            bool B = true;
            bool C = true;
            if (A || B)
            {
                Console.WriteLine("A || B");
            }
            if (A && B)
            {
                Console.WriteLine("A && B");
            }
            if (B || C)
            {
                Console.WriteLine("B || C");
            }
        }

        public static void TaskSeven(double R, double a)
        {
            double sOfCircle = Math.PI * Math.Pow(R, 2); 
            double sOfSquare = Math.Pow(a, 2);

            if(sOfCircle > sOfSquare)
            {
                Console.WriteLine("Площадь круга больше площади квадрата.");
            }
            else if(sOfCircle < sOfSquare)
            {
                Console.WriteLine("Площадь круга меньше площади квадрата.");
            }
            else Console.WriteLine("Площадь круга и площадь квадрата равны.");
        }

        public static void TaskEight(double massOfTheFirstBody, double volumeOfTheFirstBody,
            double massOfTheSecondBody, double volumeOfTheSecondBody)
        {
            double densityOfTheFirstBody = massOfTheFirstBody / volumeOfTheFirstBody;
            double densityOfTheSecondBody = massOfTheSecondBody / volumeOfTheSecondBody;
            if (densityOfTheFirstBody > densityOfTheSecondBody)
            {
                Console.WriteLine("Плотность первого тела больше плотности второго тела.");
            }
            else if (densityOfTheFirstBody < densityOfTheSecondBody)
            {
                Console.WriteLine("Плотность первого тела меньше плотности второго тела.");
            }
            else Console.WriteLine("Плотность первого тела и плотность второго тела равны.");
        }

        public static void TaskNine(double R1,double R2,double U1,double U2)
        {
            double I1, I2;
            I1 = U1 / R1;
            I2 = U2 / R2;
            if (I1 > I2)
            {
                Console.WriteLine("По второму участку проходит меньший ток.");
            }
            else if (I1 < I2)
            {
                Console.WriteLine("По первому участку проходит меньший ток.");
            }
            else Console.WriteLine("По двум участкам проходит меньший ток.");
        }

        

    }
}
