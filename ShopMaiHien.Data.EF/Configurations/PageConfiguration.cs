using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopMaiHien.Data.EF.Extensions;
using ShopMaiHien.Data.Entities;

namespace ShopMaiHien.Data.EF.Configurations
{
    public class PageConfiguration : DbEntityConfiguration<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}