using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using static System.Console;

namespace HomeWorkSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods rammstein = new Methods();
            try
            {
                rammstein.Du();
            }
            catch(IOException iosexceptions)
            {
                WriteLine(iosexceptions.Message);
            }

            ReadLine();
        }
    }
}
