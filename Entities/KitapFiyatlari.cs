using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class KitapFiyatlari
    {
        public Guid KitapFiyatlariKitapKodu { get; set; }
        public decimal KitapFiyati { get; set; }
        public decimal GunlukKiralamaFiyati { get; set; }
    }
}
