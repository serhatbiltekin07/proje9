using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yıldız_yapma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun;
            Console.Write("Satır sayısı:");
            satir = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sütun sayısı:");
            sutun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for( int  i= 0; i <sutun; i ++)
            {
                for(int j =0; j < satir; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
            

        }
    }
}
