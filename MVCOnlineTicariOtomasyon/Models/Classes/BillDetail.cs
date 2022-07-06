using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Classes
{
    public class BillDetail
    {
        [Key]
        public int BillDetailId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Description{ get; set;}
        public int Quantity { get; set;}
        public decimal UnitPrice { get; set;}
        public decimal Amount { get; set; }
        public Bills Bills { get; set; }
    }
}