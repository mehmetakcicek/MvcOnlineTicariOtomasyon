using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Fatura
    {
        [Key]
        public int FaturaId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string FaturaSeriNo { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string FaturaSiraNo { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string VergiDairesi { get; set; }
        public DateTime FaturaTarih { get; set; }
        public DateTime FaturaSaat{ get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string FaturaTeslimEden { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string FaturaTeslimAlan { get; set; }
        public ICollection<FaturaDetay> FaturaDetays { get; set; }



    }
}