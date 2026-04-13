using System;

namespace SatrancUygulamasi
{
    // Temel (Base) Sınıf
    class Satranc
    {
        public string Ad { get; set; }
        public string Renk { get; set; }
        public string Konum { get; set; }

        public void BilgiYazdir()
        {
            Console.WriteLine($"Taş: {Ad}, Renk: {Renk}, Konum: {Konum}");
        }
    }

    // Türetilmiş Sınıflar (Inheritance)
    class Piyon : Satranc { }
    class Kale : Satranc { }
    class Fil : Satranc { }
    class Vezir : Satranc { }

    class Program
    {
        static void Main(string[] args)
        {
            // Piyon nesnesi oluşturma
            Piyon p1 = new Piyon { Ad = "Piyon", Renk = "Beyaz", Konum = "A2" };
            p1.BilgiYazdir();

            // Kale nesnesi oluşturma
            Kale k1 = new Kale { Ad = "Kale", Renk = "Siyah", Konum = "H8" };
            k1.BilgiYazdir();

            // Fil nesnesi oluşturma
            Fil f1 = new Fil { Ad = "Fil", Renk = "Beyaz", Konum = "C1" };
            f1.BilgiYazdir();

            // Vezir nesnesi oluşturma
            Vezir v1 = new Vezir { Ad = "Vezir", Renk = "Siyah", Konum = "D8" };
            v1.BilgiYazdir();

            Console.ReadLine(); // Ekranın kapanmaması için
        }
    }
}