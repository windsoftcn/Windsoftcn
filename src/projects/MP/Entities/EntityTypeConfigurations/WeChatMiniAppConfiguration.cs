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
    public class WeChatMiniAppConfiguration : IEntityTypeConfiguration<WeChatMiniApp>
    {
        public void Configure(EntityTypeBuilder<WeChatMiniApp> builder)
        {
            var appTypeConverter = new ValueConverter<AppType, int>(
                v => v.Id,
                v => Enumeration.FromValue<AppType>(v));
        }
    }
}
