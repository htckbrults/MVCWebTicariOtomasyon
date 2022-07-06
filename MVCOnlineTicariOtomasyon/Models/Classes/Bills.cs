using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Classes
{
    public class Bills
    {
        [Key]
        public int BillId { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string BillSerialNumber { get; set;}

        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string BillItemNo { get; set;}
        public DateTime BillDate { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string TaxOffice { get; set; }
        public DateTime Time { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Consigner { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Receiver { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }





    }
}