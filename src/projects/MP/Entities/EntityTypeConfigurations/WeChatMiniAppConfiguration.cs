using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MP.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Entities.EntityTypeConfigurations
{
    public class WeChatMiniAppConfiguration : IEntityTypeConfiguration<WeChatApp>
    {
        public void Configure(EntityTypeBuilder<WeChatApp> builder)
        {
            var appTypeConverter = new ValueConverter<AppType, int>(
             v => v.Id,
             v => Enumeration.FromValue<AppType>(v));

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.AppId).IsUnique();

            builder.Property(x => x.Secret).HasMaxLength(32);

            builder.Property(x => x.AppName).HasMaxLength(64);

            builder.Property(x => x.AppAlias).HasMaxLength(64);

            builder.Property(x => x.Email).HasMaxLength(64);

            builder.Property(x => x.IconUrl).HasMaxLength(256);

            builder.Property(x => x.CoverUrl).HasMaxLength(256);

            builder.Property(x => x.BannerUrl).HasMaxLength(256);

            builder.Property(x => x.QRUrl).HasMaxLength(256);

            builder.Property(x => x.ShareUrl).HasMaxLength(256);
            
            builder.Property(x => x.AppType).HasConversion(appTypeConverter);

            builder.Property(x => x.Tags).HasMaxLength(256);

            builder.Property(x => x.Title).HasMaxLength(256);

            builder.Property(x => x.Description).HasMaxLength(1024);

            builder.Property(x => x.Remark).HasMaxLength(1024);

        }
    }
}
