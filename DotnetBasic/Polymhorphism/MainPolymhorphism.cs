using Polymhorpism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymhorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Lingkaran LuasLingkaran = new Lingkaran(7);
            Console.WriteLine("Luas Lingkaran = " + LuasLingkaran.HitungLuas());

            Segitiga LuasSegitiga = new Segitiga(5, 9);
            Console.WriteLine("Luas Segitiga = " + LuasSegitiga.HitungLuas());

            Console.ReadKey();
        }
    }
}
