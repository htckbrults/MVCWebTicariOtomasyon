using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Classes
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeSurName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string EmployeePicture { get; set; }

        public ICollection<SalesTransaction> SalesTransactions { get; set; }

        public int Departmentid { get; set; }   
        public virtual Department Department { get; set; }  

    }
}