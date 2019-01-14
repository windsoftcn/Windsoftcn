using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MP.Entities.EntityTypeConfigurations
{
    public class AppOwnerConfiguration : IEntityTypeConfiguration<AppOwner>
    {
        public void Configure(EntityTypeBuilder<AppOwner> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(128);

            builder.Property(x => x.Phone).HasMaxLength(128);

            builder.Property(x => x.Remark).HasMaxLength(1024);

            builder.Property(x => x.Enabled).HasDefaultValue(true);

            builder.HasMany(x => x.WeChatApps)
                .WithOne(x => x.AppOwner);                
        }
    }
}
