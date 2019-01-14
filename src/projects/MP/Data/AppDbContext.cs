using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MP.Entities;
using MP.Entities.EntityTypeConfigurations;
using MP.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MP.Models.WxAppViewModels;

namespace MP.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<WxBox> WxBoxes { get; set; }
        
        public DbSet<WxApp> WxApps { get; set; }

        public DbSet<AppOwner> AppOwners { get; set; }

        public DbSet<WxBoxApp> WxBoxApps { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new WxAppConfiguration());

            builder.ApplyConfiguration(new AppOwnerConfiguration());

            builder.ApplyConfiguration(new WxBoxConfiguration());

            builder.ApplyConfiguration(new WxBoxAppConfiguration());
        }
 
    }
}
