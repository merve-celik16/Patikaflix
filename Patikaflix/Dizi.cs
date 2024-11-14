using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix
{
   public class Dizi
    {
        public string DiziAd { get; set; }
        public int YapımYili { get; set; }
        public string Tur { get; set; }
        public int BaslamaYili { get; set; }
        public string Yonetmen { get; set; }
        public string Platform { get; set; }
    }

    class KomediDizi : Dizi
    {
        public string DiziAd { get; set; }
        public string Tur { get; set; }
        public string Yonetmen { get; set; }
    }

}
