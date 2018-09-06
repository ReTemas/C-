using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Net;

namespace Bankomat
{
    class Bankomat
    {
        static void Main(string[] args)
        {
            int password;
            WriteLine("Введите пароль для кредитной карточки.");
            try
            {
                password = Convert.ToInt32(ReadLine());
            }
            catch (ArithmeticException exception)
            {
                WriteLine(exception.Message);
            }
            catch(FormatException exception)
            {
                WriteLine(exception.Message);
            }
            ReadLine();
            // 1.Приложение предлагает ввести пароль предполагаемой кредитной карточки, даётся 3 попытки на 
            // правильный ввод пароля.Если попытки исчерпаны, приложение выдаёт соответствующее сообщение и завершается.
            // 2.При успешном вводе пароля выводится меню.Пользователь может выбрать одно из нескольких действий:
            // a.вывод баланса на экран;
            // b.пополнение счёта;


        }
    }
}
