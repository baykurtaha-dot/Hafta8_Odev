using System;

namespace AlanHesabiAbstract
{
    // Abstract (Soyut) Sınıf
    // Bu sınıftan nesne üretilemez, sadece kalıtım verir.
    abstract class Sekil
    {
        public abstract double Alan(); // Gövdesiz metot, türetilen sınıflar bunu yazmak zorundadır.
    }

    class Daire : Sekil
    {
        public double Yaricap { get; set; }
        // Abstract metodu override ederek kendi formülümüzü yazıyoruz.
        public override double Alan() => Math.PI * Yaricap * Yaricap;
    }

    class Dikdortgen : Sekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }
        public override double Alan() => Genislik * Yukseklik;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Daire daire = new Daire { Yaricap = 5 };
            Dikdortgen dikdortgen = new Dikdortgen { Genislik = 10, Yukseklik = 5 };

            Console.WriteLine("--- Abstract Sınıf ile Alan Hesabı ---");
            // :F2 formatı virgülden sonra sadece iki basamak gösterir.
            Console.WriteLine($"Daire Alanı: {daire.Alan():F2}");
            Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen.Alan()}");

            Console.ReadLine();
        }
    }
}