using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MP.Enumerations;

namespace MP.Entities.EntityTypeConfigurations
{
    public class WxBoxAppConfiguration : IEntityTypeConfiguration<WxBoxApp>
    {
        public void Configure(EntityTypeBuilder<WxBoxApp> builder)
        {
            var appShowTypeConverter = new ValueConverter<AppShowType, int>(
                v => v.Id,
                v => Enumeration.FromValue<AppShowType>(v));

            var appNavigationTypeConverter = new ValueConverter<AppNavigationType, int>(
                v => v.Id,
                v => Enumeration.FromValue<AppNavigationType>(v));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.AppShowType)
                .HasConversion(appShowTypeConverter);

            builder.Property(x => x.AppNavigationType)
                .HasConversion(appNavigationTypeConverter);

            builder.Property(x => x.Position)
                .HasDefaultValue(1);

            builder.HasOne(x => x.WxApp)
                .WithMany(x => x.WeChatBoxApps)
                .HasForeignKey(x => x.AppId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.WxBox)
                .WithMany(x => x.WxBoxApps)
                .HasForeignKey(x => x.BoxId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Enabled)
                .HasDefaultValue(true);
        }


    }

}
