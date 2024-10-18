using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.SeedData;

public class ShipperSeedData : IEntityTypeConfiguration<Shipper>
{
    public void Configure(EntityTypeBuilder<Shipper> builder)
    {
        builder.HasData(
            new Shipper 
            { 
                ShipperCode = 1, 
                ShipperName = "Aras Kargo", 
                DeliveryTime = "1-2 gün", 
                Price = 15.99m 
            },
            new Shipper 
            { 
                ShipperCode = 2, 
                ShipperName = "Yurtiçi Kargo", 
                DeliveryTime = "2-3 gün", 
                Price = 12.50m 
            },
            new Shipper 
            { 
                ShipperCode = 3, 
                ShipperName = "Kolay Gelsin", 
                DeliveryTime = "1 gün", 
                Price = 20.00m 
            },
            new Shipper 
            { 
                ShipperCode = 4, 
                ShipperName = "MNG Kargo", 
                DeliveryTime = "3-5 days", 
                Price = 10.75m 
            },
            new Shipper 
            { 
                ShipperCode = 5, 
                ShipperName = "Ptt Kargo", 
                DeliveryTime = "5-7 gün", 
                Price = 25.00m 
            }
        );
    }
}