using ShopMaiHien.Data.EF.Extensions;
using ShopMaiHien.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopMaiHien.Data.EF.Configurations
{
    public class AnnouncementConfiguration : DbEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(128).IsRequired().HasColumnType("varchar(128)");
        }
    }
}
