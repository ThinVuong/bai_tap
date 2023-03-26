using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen N = ");
            int N = int.Parse(Console.ReadLine());
            int giai_thua=1;
            int tong = 0;
            for (int i=0; i<N; i++)
            {
                for (int j=N-i;j>=1;j--)
                {
                    //Console.WriteLine("J={0}",N);
                    giai_thua=giai_thua*j;
                    //Console.WriteLine("Giai thua = {0}",giai_thua);   
                }
                tong+=giai_thua;
                //Console.WriteLine("Tong={0}",tong);
                giai_thua = 1;
            }
            Console.WriteLine("Tong cac giai thua tu 1 den N la {0}", tong);
            Console.ReadKey();
        }
    }
}
