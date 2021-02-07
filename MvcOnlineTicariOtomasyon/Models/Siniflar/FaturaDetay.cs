using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class FaturaDetay
    {
        [Key]
        public int FaturaDetayId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string FaturaDetayAciklama { get; set; }
        public int Miktar{ get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; }
        public Fatura Fatura { get; set; }


    }
}