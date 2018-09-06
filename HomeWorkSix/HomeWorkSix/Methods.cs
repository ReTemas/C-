using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace HomeWorkSix
{
    public class Methods
    {
        public void Du()
        {
            Console.WriteLine("Du!");
            DuHast();
        }

        public void DuHast()
        {
            Console.WriteLine("DuHast!");
            Mich();
        }

        public void Mich()
        {
            Console.WriteLine("Mich!");
            throw new IOException();
            //IOException ioexception = new IOException("О привет, а я тебя знаю!");
            //throw ioexception.Message;
           // return /*ioexception.Message;*/ "О привет";
        }
    }
}
