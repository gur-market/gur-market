using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gür_market.sınıflar
{
    public class Tedarikci
    {
        [Key]
        public int TedarikciId { get; set; }
        public string TedarikciAdi { get; set; }
        public string TarihSaat { get; set; }
        public int ToplamBorc { get; set; }
        public int OdenenBorc { get; set; }
    }
}
