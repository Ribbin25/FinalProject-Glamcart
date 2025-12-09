using Microsoft.EntityFrameworkCore;

namespace GlamCart.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Products.Any())
        {
            return;
        }
        context.Products.AddRange(
            new Product
            {
                Name = "Hourglass Vanish Airbrush Concealer",
                ProductDescription = "A full-coverage, waterproof concealer that blurs imperfections.",
                ImageURL = "hourglass.jpg",
                Price = 36.00m
            },

            new Product
            {
                Name = "Bobbi Brown Skin Concealer Stick",
                ProductDescription = "A creamy concealer stick for on-the-go touch ups.",
                ImageURL = "bobbi_brown.jpg",
                Price = 32.00m
            },

            new Product
            {
                Name = "Haus Labs Triclone Skin Tech Foundation",
                ProductDescription = "A serum-like foundation with long wear and skincare benefits.",
                ImageURL = "haus_labs.jpg",
                Price = 45.00m
            },

            new Product
            {
                Name = "Charlotte Tilbury Airbrush Flawless Setting Spray",
                ProductDescription = "A weightless setting spray that locks in makeup all day.",
                ImageURL = "charlotte_tilbury.jpg",
                Price = 38.00m
            },

            new Product
            {
                Name = "Rare Beauty Soft Pinch Liquid Blush",
                ProductDescription = "A highly pigmented liquid blush with a natural dewy finish.",
                ImageURL = "rare_beauty.jpg",
                Price = 23.00m
            }
        );

        context.SaveChanges();

        
        context.Reviews.AddRange(
            new Review { ProductID = 1, Rating = 5, Comment = "Best concealer I’ve ever used!" },
            new Review { ProductID = 1, Rating = 4, Comment = "Full coverage and lightweight." },

            new Review { ProductID = 2, Rating = 5, Comment = "Perfect for travel and everyday use." },
            new Review { ProductID = 2, Rating = 4, Comment = "Blends easily and looks natural." },

            new Review { ProductID = 3, Rating = 5, Comment = "Gives flawless skin all day." },
            new Review { ProductID = 3, Rating = 4, Comment = "Great coverage without feeling heavy." },

            new Review { ProductID = 4, Rating = 5, Comment = "My makeup lasts ALL day!" },
            new Review { ProductID = 4, Rating = 4, Comment = "Super lightweight and refreshing." },

            new Review { ProductID = 5, Rating = 5, Comment = "The blush is so pigmented and beautiful!" },
            new Review { ProductID = 5, Rating = 4, Comment = "A little goes a long way." }
        );

        context.SaveChanges();
    }
}
