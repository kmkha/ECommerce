using System.Linq;
using ECommerce.Data;
using ECommerce.Models;

public static class DbInitializer
{
    public static void Initialize(ECommerceDbContext context)
    {
        // Ensure the database is created
        context.Database.EnsureCreated();

        // Look for any existing products
        if (context.Products.Any())
        {
            return; // DB has been seeded
        }

        var products = new Product[]
        {
            new Product
            {
                Name = "Wireless Mouse",
                Description = "A smooth and precise wireless mouse.",
                Price = 29.99M,
                ImageUrl = "https://picsum.photos/300?random=1"
            },
            new Product
            {
                Name = "Mechanical Keyboard",
                Description = "RGB backlit mechanical keyboard with blue switches.",
                Price = 89.99M,
                ImageUrl = "https://picsum.photos/300?random=2"
            },
            new Product
            {
                Name = "Noise-Cancelling Headphones",
                Description = "Block out the world with high-quality ANC headphones.",
                Price = 199.99M,
                ImageUrl = "https://picsum.photos/300?random=3"
            }
        };

        foreach (var p in products)
        {
            context.Products.Add(p);
        }

        context.SaveChanges();
    }
}
