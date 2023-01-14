using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Urunler
    {
        [Key]
        public int UrunlerID { get; set; }
        public string UrunlerName { get; set; }
        public string MusteriIsim { get; set; }
        public string MusteriSoyisim { get; set; }
        public string MusteriAdres { get; set; }
        public string PanelMetrekare { get; set; }
        public string Fiyat { get; set; }
    }
}
