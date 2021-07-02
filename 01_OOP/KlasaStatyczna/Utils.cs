using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KlasaStatyczna
{
    static class Utils
    {
        public static string hostname = "localhost";
        public static int portNumber = 1234;

        public static int GetMaxValue(params int[] args)
        {
            return args.Max();
        }


    }
}
