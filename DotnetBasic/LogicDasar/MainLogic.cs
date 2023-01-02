using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class MainLogic

    {
        public static void Main()
        {
            Console.WriteLine("Masukkan Angka : ");
            string? input = Console.ReadLine();
            int n = input == null ? 0 : int.Parse(input);

            Console.WriteLine("Logic 02 Soal 01 " + "\n");
            Logic02Soal01.CetakData(n);

            Console.WriteLine("Logic 02 Soal 02 " + "\n");
            Logic02Soal02.CetakData(n);

            Console.WriteLine("Logic 02 Soal 03 " + "\n");
            Logic02Soal03.CetakData(n);

            Console.WriteLine("Logic 02 Soal 04 " + "\n");
            Logic02Soal04.CetakData(n);

            Console.WriteLine("Logic 02 Soal 05 " + "\n");
            Logic02Soal05.CetakData(n);

            Console.WriteLine("Logic 02 Soal 06 " + "\n");
            Logic02Soal06.CetakData(n);

            Console.WriteLine("Logic 02 Soal 09 " + "\n");
            Logic02Soal09.CetakData(n);

            Console.WriteLine("Logic 02 Soal 10 " + "\n");
            Logic02Soal10.CetakData(n);
        }
    }
}
