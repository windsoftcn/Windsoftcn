﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MP.Entities;
using MP.Entities.EntityTypeConfigurations;
using MP.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MP.Models.WeChatAppsViewModels;

namespace MP.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<WeChatApp> WeChatApps { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new WeChatMiniAppConfiguration());
        }
 
    }
}
