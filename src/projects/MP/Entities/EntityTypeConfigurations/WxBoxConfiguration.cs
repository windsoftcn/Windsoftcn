using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MP.Entities.EntityTypeConfigurations
{
    public class WxBoxConfiguration : IEntityTypeConfiguration<WxBox>
    {
        public void Configure(EntityTypeBuilder<WxBox> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(128);

            builder.Property(x => x.Remark)
                .HasMaxLength(1024);
        }
    }

}
