using System;

namespace DovuscuKarakterler
{
    // Temel Sınıf
    class Oyuncu
    {
        public virtual void Dovus()
        {
            Console.WriteLine("Oyuncu dövüşüyor...");
        }
    }

    // Türetilmiş Sınıf 1
    class DemirYumruk : Oyuncu
    {
        public override void Dovus()
        {
            Console.WriteLine("Demir Yumruk: Çok iyi yumruk atar.");
        }
    }

    // Türetilmiş Sınıf 2
    class UcanTekme : Oyuncu
    {
        public override void Dovus()
        {
            Console.WriteLine("Uçan Tekme: Çok iyi tekme atar.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Temel sınıf referansı ile türetilmiş nesneler oluşturma (Polimorfizm)
            Oyuncu karakter1 = new DemirYumruk();
            Oyuncu karakter2 = new UcanTekme();

            karakter1.Dovus();
            karakter2.Dovus();

            Console.ReadLine();
        }
    }
}