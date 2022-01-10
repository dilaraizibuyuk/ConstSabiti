using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstSabiti
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pisayisi = 3.14;
            int yaricap = 5;
            double cevre = 2 * yaricap * pisayisi;
            Console.WriteLine("Dairenin Çevresi:"+cevre);
            Console.ReadLine();
        }
    }
}
