using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do nnot repeat yourself - Kendini Tekrarlama
            //değer tutucu, alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 320000000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }

            else
            {
                Console.WriteLine("Eşittir butonu");
            }

            if(sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
