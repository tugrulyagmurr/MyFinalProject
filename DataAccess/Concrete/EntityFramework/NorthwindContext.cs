using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{

    //Context : Db tabloları ile proje nesnelerini bağlamak
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Sql server kullanıcağımızı ve Sql servera nasıl bağlanıcağımızı belirticez
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }



        //Product classı Products tablosuna karşılık geliyor
        public DbSet<Product> Products { get; set; }

        //Category classı Categories tablosuna karşılık geliyor
        public DbSet<Category> Categories { get; set; }

        //Customer classı Customers tablosuna karşılık geliyor 
        public DbSet<Customer> Customers { get; set; }
    }
}
