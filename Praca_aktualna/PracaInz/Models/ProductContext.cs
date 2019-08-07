using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using PracaInz.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PracaInz.Models
{
    public class ProductContext : IdentityDbContext
    {
        //private string connectionString = "Data Source=CARAN/SQLEXPRESS;Initial Catalog=Purchase_Assistant;Integrated Security=True";


        public Microsoft.EntityFrameworkCore.DbSet<Product> Products { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<List> Lists { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<ProductList> ProductLists { get; set; }


        //string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true";
        //private string connectionString = @"Server=(localdb)\MSSQLLocalDB\Purchase_Assistant;Integrated Security=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //if (
            //    System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform
            //        (System.Runtime.InteropServices.OSPlatform.Linux)
            //)
            
                optionsBuilder.UseSqlite("Data Source=database.db");
            
            //else
            //{
               
            //    optionsBuilder.UseSqlServer(connectionString);
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Relation>()
            //     .HasKey(pt => new { pt.ID });

            // // modelBuilder.Entity<Relation>()
            // //     .HasOne(pt => pt.Product)
            // //     // .WithMany(t => t.Relations)
            // //     .HasForeignKey(pt => pt.ProductID);

            // modelBuilder.Entity<Relation>()
            //     .HasOne(pt => pt.ProductList)
            //     .WithMany(t => t.Relations)
            //     .HasForeignKey(pt => pt.ListID);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductList>()
                .HasKey(pl => new { pl.ProductId, pl.ListId });


            modelBuilder.Entity<ProductList>()
                .HasOne(pl => pl.Product)
                .WithMany(p => p.ProductList)
                .HasForeignKey(pl => pl.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
               


            modelBuilder.Entity<ProductList>()
                .HasOne(pl => pl.List)
                .WithMany(l => l.ProductList)
                .HasForeignKey(pl => pl.ListId)
                .OnDelete(DeleteBehavior.Cascade);
        }







    }
}









//public ProductContext() :base("ProductContext-DataAnnotations")
//{

//}

//public DbSet<ProductList> Lists { get; set; }
//public DbSet<Product> Products { get; set; }



//protected override void OnModelCreating(DbModelBuilder modelBuilder)
//{


//    modelBuilder.Entity<Product>()
//                .HasMany<ProductList>(s => s.ProductLists)
//                .WithMany(c => c.products)
//                .Map(cs =>
//                {
//                    cs.MapLeftKey("ProductRefId");
//                    cs.MapRightKey("ProductListRefId");
//                    cs.ToTable("ProductProductList");
//                });

//}