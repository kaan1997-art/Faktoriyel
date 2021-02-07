using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pozitif bir tam sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            if (sayi < 1 && sayi != 0)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz");
            }
            else
            {
                for (int i = 1; i < sayi; i++)
                {
                    faktoriyel += faktoriyel * i;
                }
                Console.WriteLine(sayi + " sayısının faktoriyeli:" + faktoriyel);
            }
            Console.ReadLine();
        }
    }
}
