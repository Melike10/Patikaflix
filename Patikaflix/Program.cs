using Patikaflix;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Movie> diziListesi = new List<Movie>();

        while (true)
        {
            Movie yeniDizi = new Movie();

            Console.Write("Dizinin Adı: ");
            yeniDizi.MovieName = Console.ReadLine();

            Console.Write("Yapım Yılı: ");
            yeniDizi.ProductionYear = int.Parse(Console.ReadLine());

            Console.Write("Türü: ");
            yeniDizi.Type = Console.ReadLine();

            Console.Write("Yayınlanmaya Yılı: ");
            yeniDizi.PublicationYear = int.Parse(Console.ReadLine());

            Console.Write("Yönetmen: ");
            yeniDizi.DirectorName = Console.ReadLine();

            Console.Write("İlk Yayınlandığı Platform: ");
            yeniDizi.FirstPlatform = Console.ReadLine();

            diziListesi.Add(yeniDizi);

            Console.Write("Yeni bir dizi eklemek ister misiniz? (E/H): ");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap != "E")
                break;
        }


        List<ComedyMovie> komediDizileri = new List<ComedyMovie>();

        foreach (var dizi in diziListesi)
        {
            if (dizi.Type.ToLower() == "komedi")
            {
                komediDizileri.Add(new ComedyMovie
                {
                    MovieName = dizi.MovieName,
                    Type = dizi.Type,
                    DirectorName = dizi.DirectorName
                });
            }
        }

        var siraliKomediDizileri = komediDizileri.OrderBy(k => k.MovieName).ThenBy(k => k.DirectorName).ToList();

        Console.WriteLine("\nKomedi Dizileri:");
        foreach (var komediDizi in siraliKomediDizileri)
        {
            Console.WriteLine($"Dizi Adı: {komediDizi.MovieName}, Türü: {komediDizi.Type}, Yönetmen: {komediDizi.DirectorName}");
        }

    }
}