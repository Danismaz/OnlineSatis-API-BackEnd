using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData
{
    public class CategorySeedData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    CategoryCode=1,
                    CategoryName="Kalemler",
                    CategoryDescription= "Farklı türde kalemler."
                },
                new Category
                {
                    CategoryCode = 2,
                    CategoryName ="Defterler",
                    CategoryDescription = "Çeşitli defter türleri."
                },
                new Category
                {
                    CategoryCode=3,
                    CategoryName= "Ofis Malzemeleri",
                    CategoryDescription = "Ofis için gerekli malzemeler."
                },
                new Category
                {
                    CategoryCode =4,
                    CategoryName= "Sanat Malzemeleri",
                    CategoryDescription = "Resim ve sanat malzemeleri."
                },
                new Category
                {
                    CategoryCode =5,
                    CategoryName= "Yapıştırıcılar",
                    CategoryDescription= "Farklı tür yapıştırıcılar."
                }

                );
        }
    }
}
