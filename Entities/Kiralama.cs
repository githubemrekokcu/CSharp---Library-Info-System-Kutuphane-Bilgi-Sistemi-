using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Kiralama
    {
        public int KiralamaID { get; set; }
        public string KiralamaKodu { get; set; }
        public Guid KiralamaKitapKodu { get; set; }
        public DateTime KiralamaBaslangicTarihi { get; set; }
        public DateTime KiralamaBitisTarihi { get; set; }
        public DateTime KiralamaKitapVerisTarihi { get; set; }
        public string KiralamaUyeKodu { get; set; }
        public decimal KiralamaFiyati { get; set; }
        public string KiralamaNotu { get; set; }
        public bool KiralamaBitisDurumu { get; set; }
    }
}
