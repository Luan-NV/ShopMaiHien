using ShopMaiHien.Data.EF.Extensions;
using ShopMaiHien.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopMaiHien.Data.EF.Configurations
{
    public class AdvertistmentPageConfiguration : DbEntityConfiguration<AdvertistmentPage>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPage> entity)
        {
            //entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired().HasColumnType("varchar(20)");
        }
    }
}
