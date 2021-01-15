using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gür_market.sınıflar
{
    public class VeresiyeSatis
    {
        [Key]
        public int MusteriId { get; set; }
        public string MusteriAdSoyad { get; set; }
        public int MusteriTel { get; set; }
        public string TarihSaat { get; set; }
        public int BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public int BirimAdet { get; set; }
        public int Fiyat { get; set; }
        public int Toplam { get; set; }

    }
}
