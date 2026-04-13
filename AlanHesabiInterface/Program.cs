using System;

namespace AlanHesabiInterface
{
    // Interface (Arayüz) tanımı
    // Interface içindeki metotların gövdesi olmaz, sadece imzası olur.
    interface ISekil
    {
        double Alan();
    }

    class Daire : ISekil
    {
        public double Yaricap { get; set; }
        // Interface metodunu uyguluyoruz (Burada override yazılmaz)
        public double Alan() => Math.PI * Yaricap * Yaricap;
    }

    class Dikdortgen : ISekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }
        public double Alan() => Genislik * Yukseklik;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Interface referansı kullanarak nesne oluşturma
            ISekil daire = new Daire { Yaricap = 3 };
            ISekil dikdortgen = new Dikdortgen { Genislik = 4, Yukseklik = 6 };

            Console.WriteLine("--- Interface ile Alan Hesabı ---");
            Console.WriteLine($"Daire Alanı: {daire.Alan():F2}");
            Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen.Alan()}");

            Console.ReadLine();
        }
    }
}
