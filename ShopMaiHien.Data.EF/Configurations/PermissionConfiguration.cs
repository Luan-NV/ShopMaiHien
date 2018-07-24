using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopMaiHien.Data.EF.Extensions;
using ShopMaiHien.Data.Entities;

namespace ShopMaiHien.Data.EF.Configurations
{
    public class PermissionConfiguration : DbEntityConfiguration<Permission>
    {
        public override void Configure(EntityTypeBuilder<Permission> entity)
        {
            //entity.HasKey(c => c.Id);
            //entity.Property(c => c.Id).IsRequired()
            //.HasColumnType("varchar(128)");
            entity.Property(c => c.FunctionId).HasMaxLength(128).IsRequired().HasColumnType("varchar(128)");
        }
    }
}
