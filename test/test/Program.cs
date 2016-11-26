using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", SQLDbHelper.SQL_Connection());
            while (true) ;
        }
    }
}
