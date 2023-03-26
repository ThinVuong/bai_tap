using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //int N = int.Parse(Console.ReadLine());
                //bool laSNT=true;
                //string result = "";
                //int tong = 0;
                Console.WriteLine("Nhap phim Esc de thoat, nhap phim bat ky de tiep tuc");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    bool laSNT = true;
                    string result = "";
                    int tong = 0;
                    Console.WriteLine("<------------------------------------->");
                    Console.Write("Nhap so nguyen N = ");
                    int N = int.Parse(Console.ReadLine());
                    for (int j = 2; j <= N; j++)
                    {
                        for (int i = 2; i < j; i++)
                        {
                            if (j % i == 0)
                            {
                                laSNT = false;
                            }

                        }
                        if (laSNT)
                        {
                            result = (j == 2) ? $"{j}" : $"{result}, {j}";
                            tong += j;
                        }
                        laSNT = true;
                    }
                    Console.WriteLine("Cac songuyen to den N la {0}", result);
                    Console.WriteLine("Tong cac so nguyen to la {0}", tong);
                    Console.WriteLine("<------------------------------------->");
                }
            }
        }
    }
}
