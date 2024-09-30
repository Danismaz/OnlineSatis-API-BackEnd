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
    public class ProductSeedData : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    ProductCode = 1,
                    ProductName = "Kurşun Kalem",
                    ProductPrice = 40,
                    Stock = 100,
                    CategoryCode=1
                },
                new Product
                {
                    ProductCode = 2,
                    ProductName = "Mavi Renkli Kalem",
                    ProductPrice = 80,
                    Stock = 80,
                    CategoryCode = 1
                },
                new Product
                {
                    ProductCode = 3,
                    ProductName = "Kırmızı Jel Kalem",
                    ProductPrice = 90,
                    Stock = 60,
                    CategoryCode = 1
                },
                new Product
                {
                    ProductCode = 4,
                    ProductName = "Siyah Mürekkep Kalem",
                    ProductPrice = 100,
                    Stock = 40,
                    CategoryCode = 1
                },
                new Product
                {
                    ProductCode = 5,
                    ProductName = "Renkli Silgi",
                    ProductPrice = 25,
                    Stock = 120,
                    CategoryCode = 1
                },
                new Product
                {
                    ProductCode = 6,
                    ProductName = "A5 Kırmızı Defter",
                    ProductPrice = 150,
                    Stock = 200,
                    CategoryCode = 2
                },
                new Product 
                {
                    ProductCode = 7,
                    ProductName = "A4 Beyaz Defter",
                    ProductPrice = 85,
                    Stock = 150,
                    CategoryCode = 2
                },
                new Product 
                {
                    ProductCode = 8,
                    ProductName = "Kareli Defter",
                    ProductPrice = 120,
                    Stock = 100,
                    CategoryCode = 2
                },
                new Product 
                {
                    ProductCode = 9,
                    ProductName = "Çizgili Defter",
                    ProductPrice = 120,
                    Stock = 90,
                    CategoryCode = 2
                },
                new Product 
                {
                    ProductCode = 10,
                    ProductName = "Sert Kapaklı Defter",
                    ProductPrice = 160,
                    Stock = 50,
                    CategoryCode = 2
                },
                new Product
                {
                    ProductCode = 11,
                    ProductName = "Zımba Makinesi",
                    ProductPrice = 90,
                    Stock = 30,
                    CategoryCode = 3
                },
                new Product
                {
                    ProductCode = 12,
                    ProductName = "Bant Dispenseri",
                    ProductPrice = 45,
                    Stock = 70,
                    CategoryCode = 3
                },
                new Product
                {
                    ProductCode = 13,
                    ProductName = "Makas",
                    ProductPrice = 55,
                    Stock = 40,
                    CategoryCode = 3
                },
                new Product 
                {
                    ProductCode = 14,
                    ProductName = "Post-it Notlar",
                    ProductPrice = 75,
                    Stock = 200,
                    CategoryCode = 3
                },
                new Product
                {
                    ProductCode = 15,
                    ProductName = "Kalemtraş",
                    ProductPrice = 20,
                    Stock = 100,
                    CategoryCode = 3
                },
                new Product
                {
                    ProductCode = 16,
                    ProductName = "Akrilik Boya Seti",
                    ProductPrice = 165,
                    Stock = 20,
                    CategoryCode = 4
                },
                new Product
                {
                    ProductCode = 17,
                    ProductName = "Su Renkleri Seti",
                    ProductPrice = 145,
                    Stock = 30,
                    CategoryCode = 4
                },
                new Product
                {
                    ProductCode = 18,
                    ProductName = "Fırça Seti",
                    ProductPrice = 110,
                    Stock = 25,
                    CategoryCode = 4
                },
                new Product
                {
                    ProductCode = 19,
                    ProductName = "Çizim Defteri",
                    ProductPrice = 85,
                    Stock = 40,
                    CategoryCode = 4
                },
                new Product 
                {
                    ProductCode = 20,
                    ProductName = "Sanat Paleti",
                    ProductPrice = 55,
                    Stock = 50,
                    CategoryCode = 4
                },
                new Product
                {
                    ProductCode = 21,
                    ProductName = "Sıvı Yapıştırıcı",
                    ProductPrice = 35,
                    Stock = 60,
                    CategoryCode = 5
                },
                new Product 
                {
                    ProductCode = 22,
                    ProductName = "Bantlı Yapıştırıcı",
                    ProductPrice = 30,
                    Stock = 90,
                    CategoryCode = 5
                },
                new Product 
                {
                    ProductCode = 23,
                    ProductName = "Hot Melt Yapıştırıcı",
                    ProductPrice = 80,
                    Stock = 30,
                    CategoryCode = 5
                },
                new Product
                {
                    ProductCode = 24,
                    ProductName = "Yapıştırıcı Stik",
                    ProductPrice = 75,
                    Stock = 120,
                    CategoryCode = 5
                },
                new Product
                {
                    ProductCode = 25,
                    ProductName = "Modeller İçin Yapıştırıcı",
                    ProductPrice = 55,
                    Stock = 40,
                    CategoryCode = 5
                }

                );
        }
    }
}
