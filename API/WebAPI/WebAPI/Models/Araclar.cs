using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Araclar
    {
        [Key]
        public int AraclarID { get; set; }
        public string AraclarName { get; set; }
        public string AraclarModel { get; set; }
        public string AraclarYil { get; set; }
        public string AraclarSeri { get; set; }
        public string AraclarRenk { get; set; }
        public string AraclarDurum { get; set; }
        public string AraclarHiz { get; set; }
        public string AraclarYakit { get; set; }
        public string AraclarFiyat { get; set; }
        public string AraclarURL { get; set; }
    }
}
