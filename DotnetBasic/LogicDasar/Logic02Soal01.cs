﻿namespace LogicDasar
{
    internal class Logic02Soal01
    {
        public Logic02Soal01()
        {
        }

        public static void CetakData(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int angka = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i+j == n - 1)
                    {
                        Console.Write(angka +"\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }

                    angka ++;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
