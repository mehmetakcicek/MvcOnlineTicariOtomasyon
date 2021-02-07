using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Gider
    {
        [Key]
        public int GiderId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string GiderAdi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string GiderAciklama { get; set; }
        public DateTime GiderTarih { get; set; }
        public decimal Tutar { get; set; }

    }
}