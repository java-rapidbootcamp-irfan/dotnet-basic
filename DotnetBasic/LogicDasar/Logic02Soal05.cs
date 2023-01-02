using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic02Soal05
    {
        public Logic02Soal05()
        {
        }

        public static void CetakData(int n)
        {
            int angka = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= i && j >= n - i - 1 || j <= i && j <= n - i - 1)
                    {
                        Console.Write(angka + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    angka += 2;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
