using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kitaplar
    {
        public int KitapID { get; set; }
        public Guid KitapKodu { get; set; }
        public string KitapISBN { get; set; }
        public string KitapAdi { get; set; }
        public string KitapTurKodu { get; set; }
        public string KitapYazarKodu { get; set; }
        public int KitapSayfaSayisi { get; set; }
        public string KitapYayinEviFirmaKodu { get; set; }
        public DateTime KitapBasimTarihi { get; set; }
        public string KitapDilKodu { get; set; }
    }
}
