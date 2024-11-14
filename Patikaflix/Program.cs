namespace Patikaflix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dizi> diziler = new List<Dizi>() 
            { 
               new Dizi{DiziAd="Avrupa Yakası",YapımYili =2004,Tur="Komedi",BaslamaYili=2004,Yonetmen="Yüksel Aksu",Platform="Kanal D"},
               new Dizi{DiziAd="Yalan Dünya",YapımYili =2012,Tur="Komedi",BaslamaYili=2012,Yonetmen="Gülseren Buda Başkaya",Platform="Fox"},
               new Dizi{DiziAd="Jet Sosyete",YapımYili =2018,Tur="Komedi",BaslamaYili=2018,Yonetmen="Gülseren Buda Başkaya",Platform="TV8"},
               new Dizi{DiziAd="Dadı",YapımYili =2006,Tur="Komedi",BaslamaYili=2006,Yonetmen="Yusuf Pirhasan",Platform="Kanal D"},
               new Dizi{DiziAd="Belalı Baldız",YapımYili =2007,Tur="Komedi",BaslamaYili=2007,Yonetmen="Yüksel Aksu",Platform="Kanal D"},
               new Dizi{DiziAd="Arka Sokaklar",YapımYili =2004,Tur="Polisiye,Dram",BaslamaYili=2004,Yonetmen="Orhan Oğuz",Platform="Kanal D"},
               new Dizi{DiziAd="Aşk-ı Memnu",YapımYili =2008,Tur="Dram,Romantik",BaslamaYili=2008,Yonetmen="Hilal Saral",Platform="Kanal D"},
               new Dizi{DiziAd="Muhteşem Yüzyıl",YapımYili =2011,Tur="Tarihi,Dram",BaslamaYili=2011,Yonetmen="Mercan Çilingiroğlu",Platform="Star"},
               new Dizi{DiziAd="Yaprak Dökümü",YapımYili =2006,Tur="Dram",BaslamaYili=2006,Yonetmen="Serdar Akar",Platform="Kanal D"},

            };


            while (true)
            {
                Console.WriteLine("Yeni dizi eklemek istiyor musunuz? (e/h)");
                string cevap = Console.ReadLine();

                if (cevap.ToLower() == "h")
                    break;

                Console.Write("Dizi Adı: ");
                string ad = Console.ReadLine();
                Console.Write("Yapım Yılı: ");
                int yapimyili = int.Parse(Console.ReadLine());
                Console.Write("Dizi Türü: ");
                string tur = Console.ReadLine();
                Console.Write("Yayınlanmaya Başlama Yılı: ");
                int baslamayili = int.Parse(Console.ReadLine());
                Console.Write("Yönetmen: ");
                string yonetmen = Console.ReadLine();
                Console.Write("Yayınlandığı İlk Platform: ");
                string platform = Console.ReadLine();

                Dizi yeniDizi = new Dizi
                {
                    DiziAd = ad,
                    YapımYili= yapimyili,
                    BaslamaYili= baslamayili,
                    Tur = tur,
                    Yonetmen = yonetmen,
                    Platform=platform

                   
                };

                diziler.Add(yeniDizi);
            }

            // Komedi dizilerinden yeni bir liste oluşturma
            var komediDizileri = diziler.Where(d => d.Tur == "Komedi")
                                       .Select(d => new KomediDizi
                                       {
                                           DiziAd = d.DiziAd,
                                           Tur = d.Tur,
                                           Yonetmen = d.Yonetmen
                                       })
                                       .ToList();

            // Dizi isimlerine göre sıralama
            komediDizileri = komediDizileri.OrderBy(d => d.DiziAd).ToList();

            // Yönetmen isimlerine göre sıralama
            komediDizileri = komediDizileri.OrderBy(d => d.Yonetmen).ToList();

            Console.WriteLine("\nKomedi Dizileri (Dizi Adına Göre Sıralı):");
            foreach (var dizi in komediDizileri.OrderBy(d => d.DiziAd))
            {
                Console.WriteLine($"Adı: {dizi.DiziAd}, Türü: {dizi.Tur}, Yönetmen: {dizi.Yonetmen}");
            }

            Console.WriteLine("\nKomedi Dizileri (Yönetmene Göre Sıralı):");
            foreach (var dizi in komediDizileri.OrderBy(d => d.Yonetmen))
            {
                Console.WriteLine($"Adı: {dizi.DiziAd}, Türü: {dizi.Tur}, Yönetmen: {dizi.Yonetmen}");
            }
        }
    }
}
