using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }
        [Column(TypeName ="Varchar")]
        [StringLength(30)]
        public string UrunAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Marka { get; set; }
        public int StokAdet { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public bool UrunStokDurum { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UrunGorsel { get; set; }

        public Kategori Kategori { get; set; }
        public SatisHareket SatisHareket { get; set; }



    }
}