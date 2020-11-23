using eShopSolution.Data.Entities;
using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extentions
{
   public static class ModeBuilderExtensions
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData
            (new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
            new AppConfig() { Key = "HomeKeyWord", Value = "This is Keyword page of eShopSolution" },
            new AppConfig() { Key = "HomeDescription", Value = "This is description page of eShopSolution" });

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category() {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId=null,
                    SortOrder=1,
                    Status=Enums.Status.Active                  
                }
                );
            ///
            modelBuilder.Entity<Category>().HasData(
         new Category()
         {
             Id = 2,
             IsShowOnHome = true,
             ParentId = null,
             SortOrder = 2,
             Status = Enums.Status.Active          
         }
         );
            modelBuilder.Entity<CategoryTranslation>().HasData(
                    new CategoryTranslation() {Id=1, CategoryId = 1, Name = "Áo Nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "sản phẩm áo thời trang nam", SeoTitle = "sản phẩm áo thời trang nam" },
                    new CategoryTranslation() {Id=2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en-US", SeoAlias = "ao-nam", SeoDescription = "the shirt product for men", SeoTitle = "the shirt product for men" },
                    new CategoryTranslation() {Id=3, CategoryId=  2, Name = "Áo Nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "sản phẩm áo thời trang nữ", SeoTitle = "sản phẩm áo thời trang nữ" },
                    new CategoryTranslation() {Id=4, CategoryId=  2, Name = "WoMen Shirt", LanguageId = "en-US", SeoAlias = "ao-nu", SeoDescription = "the shirt product for women", SeoTitle = "the shirt product for women" });


            modelBuilder.Entity<Product>().HasData(
             new Product()
             {
                 Id = 1,
                 DateCreate=DateTime.Now,
                 OriginalPrive=100000,
                 Price=20000,
                 Stock = 0,
                 ViewCount = 0        
             
             }
             ); 
            modelBuilder.Entity<ProductTranslation>().HasData(                
                 new ProductTranslation ()
                 { 
                     Id = 1,
                     ProductId = 1,
                     Name="Áo so mi nam trắng Việt Tiến",
                     LanguageId="vi-VN",
                     SeoAlias="ao-sp-mi-nam-trang-viet-tien",
                     SeoDescription="Áo so mi nam trắng Việt Tiến",
                     SeoTitle="Áo so mi nam trắng Việt Tiến",
                     Details="Áo so mi nam trắng Việt Tiến",
                     Description= "Áo sơ mi nam trắng Việt Tiến"
                 },
                    new ProductTranslation ()
                    { 
                        Id = 2,
                        ProductId = 1,
                        Name="Viet Tien Men T-Shirt",
                        LanguageId="en-US",
                        SeoAlias="ao-nam",
                        SeoDescription="Viet Tien Men T-Shirt",
                        SeoTitle="Viet Tien Men T-Shirt",
                        Details="Viet Tien Men T-Shirt",
                        Description= "Viet Tien Men T-Shirt"
                    }
                 );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 });
        }
    }
}
