using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCOnlineTicariOtomasyon.Models.Classes;

namespace MVCOnlineTicariOtomasyon.Models.Classes
{
    public class Context:DbContext  
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departmans { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Bills> Billss { get; set; }
        public DbSet<Expenses> Expensess{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SalesTransaction> SalesTransactions { get; set; }
        public DbSet<Product> Produucts { get; set; }
    }
}