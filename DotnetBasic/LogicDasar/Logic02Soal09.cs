using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic02Soal09
    {
        public Logic02Soal09()
        {
        }

        public static void CetakData(int n)
        {
            int  Median = n/2;
            int angka = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j-i <= Median && i-j <= Median &&
                            i+j >= Median && i+j <= Median + n-1)
                    {
                        Console.Write(angka +"\t");
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
