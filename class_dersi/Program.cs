using System;

namespace class_dersi
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursunEgitmeni = "engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem Varış";
            kurs2.İzlenmeOrani = 64;
           
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.KursunEgitmeni = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var Kurs in kurslar)
            {
                Console.WriteLine(Kurs.KursAdi + " : " + Kurs.KursunEgitmeni);
            }
           
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int İzlenmeOrani { get; set; }

         

    }
}
