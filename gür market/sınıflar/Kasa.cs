using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gür_market.sınıflar
{
    public class Kasa
    {
        [Key]
        public int KasaID { get; set; }
        public int ToplamBorc { get; set; }
        public int ToplamAlacakMiktari { get; set; }
        public int PotansiyelKarZarar { get; set; }
        public int MevcutKasaMiktari { get; set; }
    }
}
