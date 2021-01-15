using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gür_market.sınıflar
{
    public class Stok
    {
        [Key]
        public int StokID { get; set; }
        public int IrsaliyeNo { get; set; }
        public string TedarikciAdi { get; set; }
        public int BarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public int BirimAdedi { get; set; }
        public int BirimFiyat { get; set; }
    }
}
