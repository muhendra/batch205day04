using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay04
{
    class Program
    {
        public static int hitung(int x)
        {
            return x + 2;
        }
        static void Main(string[] args)
        {
            int angka = 3;
            bool status = true;

            Console.Write("ABC {0} {0}\n" , angka, status);
            Console.Write("ABC" + angka + " " + status);

            Console.ReadLine();
        }
    }
}
