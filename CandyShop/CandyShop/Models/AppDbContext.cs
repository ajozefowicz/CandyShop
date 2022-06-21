using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class AppDbContext: DbContext //from package EntityFramework>core
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }

        public DbSet<Candy> Candies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CateogryId = 1, CategoryName = "Hard Candy", CategoryDescription = "Super hard candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CateogryId = 2, CategoryName = "Chocolate Candy", CategoryDescription = "very chocolate candy" });
            modelBuilder.Entity<Category>().HasData(new Category { CateogryId = 3, CategoryName = "Fruit Candy", CategoryDescription = "Sour fruit candy" });
            
            modelBuilder.Entity<Candy>().HasData(new Candy {
                CandyId = 1,
                Name = "Asorted Hard Candy",
                Price = 2.22M,
                Description = "Lorem ipsum dolor sit amet enim. " +
                "Etiam ullamcorper. Suspendisse a pellentesque dui, non felis",
                CategoryId = 1,
                ImageUrl = "https://cdn.pixabay.com/photo/2012/12/11/21/28/variation-69470__340.jpg",
                IsInStock = true,
                IsOnSale = false,
                ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2012/12/11/21/28/variation-69470__340.jpg"
            });
            modelBuilder.Entity<Candy>().HasData(new Candy {
                CandyId = 2,
                Name = "Super Hard Candy",
                Price = 4.22M,
                Description = "Lorem ipsum dolor sit amet enim. " +
                "Etiam ullamcorper. Suspendisse a pellentesque dui, non felis",
                CategoryId = 1,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/10/09/18/06/candy-corn-1726481_960_720.jpg",
                IsInStock = true,
                IsOnSale = true,
                ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2016/10/09/18/06/candy-corn-1726481_960_720.jpg"
            });
            modelBuilder.Entity<Candy>().HasData(new Candy {
                CandyId = 3,
                Name = "Super Chocolate Candy",
                Price = 3.33M,
                Description = "Lorem ipsum dolor sit amet enim. " +
                "Etiam ullamcorper. Suspendisse a pellentesque dui, non felis",
                CategoryId = 2,
                ImageUrl = "https://cdn.pixabay.com/photo/2014/11/30/10/48/chocolate-551424__340.jpg",
                IsInStock = true,
                IsOnSale = true,
                ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2014/11/30/10/48/chocolate-551424__340.jpg"
            });
            modelBuilder.Entity<Candy>().HasData(new Candy {
                CandyId = 4,
                Name = "Dark Chocolate Candy",
                Price = 5.55M,
                Description = "Lorem ipsum dolor sit amet enim. " +
                "Etiam ullamcorper. Suspendisse a pellentesque dui, non felis",
                CategoryId = 2,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/04/12/16/56/chocolates-2224998__340.jpg",
                IsInStock = true,
                IsOnSale = true,
                ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2017/04/12/16/56/chocolates-2224998__340.jpg"
            });

             modelBuilder.Entity<Candy>().HasData(new Candy {
                 CandyId = 5,
                 Name = "Mango Candy",
                 Price = 5.55M,
                 Description = "Lorem ipsum dolor sit amet enim. " +
                "Etiam ullamcorper. Suspendisse a pellentesque dui, non felis",
                 CategoryId = 3,
                 ImageUrl = "https://cdn.pixabay.com/photo/2018/06/19/23/30/sugar-3485447__340.jpg",
                 IsInStock = true,
                 IsOnSale = true,
                 ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2018/06/19/23/30/sugar-3485447__340.jpg"
             });


        }
    }
}
