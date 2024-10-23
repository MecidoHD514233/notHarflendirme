using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notproje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1. sayıyı giriniz : ");
            int birnot = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz : ");
            int ikinot = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Lütfen 3. sayıyı giriniz : ");
            int ucnot = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birnot + ikinot + ucnot) / 3;

            if (sonuc >= 80 && sonuc<100)
            {
                Console.WriteLine(" Harf Notunuz A+,Geçtiniz Tebrikler.");
            }
            else if (60 <= sonuc && sonuc< 80)
            {
                Console.WriteLine("Harf Notunuz A,Geçtiniz Tebrikler.");
            }
            else if (40 <= sonuc && sonuc < 60)
            {
                Console.WriteLine(" Harf Notunuz B+ ,Geçtiniz Tebrikler.");
            }
            else
            {
                Console.WriteLine("Harf Notunuz F, Üzgünüz Maalesef Kaldınız.");
            }
            Console.ReadLine();
        }
    }
}