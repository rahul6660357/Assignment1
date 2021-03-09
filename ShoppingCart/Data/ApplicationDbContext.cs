using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetSettingTool.Models;

namespace ShoppingCart.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().ToTable("users");
            builder.Entity<IdentityUserClaim<string>>().ToTable("userclaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("userlogins");
            builder.Entity<IdentityUserRole<string>>().ToTable("userroles");
            builder.Entity<IdentityUserToken<string>>().ToTable("usertoken");
            builder.Entity<IdentityRole>().ToTable("roles");
            builder.Entity<AppLogger>().ToTable("AppLogger");         

        }
    }
}
