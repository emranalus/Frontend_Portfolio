using HttpStatusCode.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HttpStatusCode.Infrastucture.SeedData
{
    public class CategorySeedData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(p => p.CategoryName)
                .HasMaxLength(50);

            builder.Property(p => p.CategoryDescription)
                .HasMaxLength(500);

            builder.HasData(

            new Category
            {
                Id = 1,
                CategoryName = "Elektronik",
                CategoryDescription = "Elektronik zamazingonlar"
            },

            new Category
            {
                Id = 2,
                CategoryName = "Tekstil",
                CategoryDescription = "Tekstil zamazingonlar"
            },

            new Category
            {
                Id = 3,
                CategoryName = "Yiyecek",
                CategoryDescription = "Yemek zamazingonlar"
            },
            new Category
            {
                Id = 4,
                CategoryName = "İçecek",
                CategoryDescription = "Meşrubat zamazingonlar"
            });
        }
    }
}
