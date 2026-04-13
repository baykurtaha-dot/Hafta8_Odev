using System;

namespace AlanHesabiPolimorfizm
{
    // Temel Sınıf
    class Sekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public virtual double Alan()
        {
            return 0;
        }
    }

    // Türetilmiş Sınıflar
    class Ucgen : Sekil
    {
        public override double Alan() => (Genislik * Yukseklik) / 2;
    }

    class Kare : Sekil
    {
        public override double Alan() => Genislik * Genislik;
    }

    class Dikdortgen : Sekil
    {
        public override double Alan() => Genislik * Yukseklik;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sekil ucgen = new Ucgen { Genislik = 10, Yukseklik = 5 };
            Sekil kare = new Kare { Genislik = 4 };
            Sekil dikdortgen = new Dikdortgen { Genislik = 8, Yukseklik = 4 };

            Console.WriteLine($"Üçgen Alanı: {ucgen.Alan()}");
            Console.WriteLine($"Kare Alanı: {kare.Alan()}");
            Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen.Alan()}");

            Console.ReadLine();
        }
    }
}