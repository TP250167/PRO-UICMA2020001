using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UICMA.Repository
{
    public class UICMAContext:DbContext
    {
        public UICMAContext(DbContextOptions<UICMAContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //new UserMap(modelBuilder.Entity<User>());
            //new UserProfileMap(modelBuilder.Entity<UserProfile>());
        }
    }
}
