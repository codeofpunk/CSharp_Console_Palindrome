using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  1) Kullanıcı 'q' harfine basana kadar tekrar tekrar giriş yapabilir, 'q' harfine bastığında uygulamadan çıkılır.
                2) Kullanıcının yaptığı giriş en az iki karakter olmalıdır.
                3) Kullanıcı sadece harf girecek diye bir zorunluluk yoktur.
                4) Eğer kullanıcının girdiği kelime palindrom ise ekrana "Girdiğiniz kelime palindromdur.", değilse "Girdiğiniz kelime palindrom değildir." yazılır.
            */

            

            string gelenVeri;
            string sonuc;
            Console.WriteLine("Palindrom Kontrolü v1 - (Çıkış için \"q\")");
            gelenVeri = Console.ReadLine();

            while (gelenVeri != "q")
            {
                if (gelenVeri.Length >= 2)
                {
                    sonuc = "";
                    for (int i = gelenVeri.Length - 1; i >= 0; i--)
                    {
                        sonuc += gelenVeri[i];
                    }
                    if (gelenVeri == sonuc)
                        Console.WriteLine("Girdiğiniz veri palindromdur.");
                    else
                        Console.WriteLine("Girdiğiniz veri palindrom değildir.");
                }
                else
                {
                    Console.WriteLine("Kelime en az 3 karakter olmalıdır!");
                }
                Console.Write("Palindrom kontrolü için kelime (ç: Çıkış): ");
                gelenVeri = Console.ReadLine();
            }

        }

        



    }
}
