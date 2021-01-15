using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gür_market.sınıflar
{
    public class PesinSatis
    {
        [Key]
        public int SatisId { get; set; }
        public int BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public int BirimAdet { get; set; }
        public int Fiyat { get; set; }
        public int Toplam { get; set; }
    }

}
