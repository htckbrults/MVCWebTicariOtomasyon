using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Classes
{
    public class SalesTransaction
    {
        [Key]
        public int SaleId { get; set; }
        //ürün
        //müşteri 
        //personel
        public DateTime Date { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public decimal AggregateAmount { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
    }
}