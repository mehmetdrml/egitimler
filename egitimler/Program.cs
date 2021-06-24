using System;

namespace egitimler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";

            int ogrencisayisi = 32000;
            double faizOrani = 1.45;
            double dolarDun = 7.45;
            double dolarBugun = 7.35;


            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Yükseliş Oku");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Düşüş Oku");
            }
            else
            {
                Console.WriteLine("Eşitlik Oku");
            } 
                
                {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");

            }

                Console.WriteLine(kategoriEtiketi);
            



        }
    }
}
