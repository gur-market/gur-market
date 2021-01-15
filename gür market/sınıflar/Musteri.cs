using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gür_market.sınıflar
{
    public class Musteri { 
    
        [Key]
        public int MusteriId { get; set; }
        public string MusteriAdSoyad { get; set; }
        public String MusteriTc { get; set; }
        public int MusteriTel { get; set; }
        public string TarihSaat { get; set; }
        public int BorcMiktari { get; set; }
    }
}
