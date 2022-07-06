using MVCOnlineTicariOtomasyon.Models.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Classes
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection <Product> Products { get; set; }
        public object Categories { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}