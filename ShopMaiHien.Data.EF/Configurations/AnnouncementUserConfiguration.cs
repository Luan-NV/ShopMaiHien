using ShopMaiHien.Data.EF.Extensions;
using ShopMaiHien.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopMaiHien.Data.EF.Configurations
{
    public class AnnouncementUserConfiguration : DbEntityConfiguration<AnnouncementUser>
    {
        public override void Configure(EntityTypeBuilder<AnnouncementUser> entity)
        {
            entity.Property(c => c.AnnouncementId).HasMaxLength(128).IsRequired().HasColumnType("varchar(128)");
        }
    }
}
