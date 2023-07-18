using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_keyword_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("bir sayı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Kare2(ref sayi);
            Console.WriteLine("karesi alındıktan sonra sayınız : " + sayi);
        }
        static void Kare(int sayi)
        {
            sayi = sayi * sayi;
        }
        static void Kare2(ref int sayi)
        {
            sayi = sayi * sayi;
        }
    }
}
