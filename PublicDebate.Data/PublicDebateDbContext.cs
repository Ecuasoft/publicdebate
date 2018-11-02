using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PublicDebate.Data
{
    public class PublicDebateDbContext : IdentityDbContext<UserDbEntity, RoleDbEntity, Guid>
    {
        public PublicDebateDbContext(DbContextOptions<PublicDebateDbContext> options)
                    : base(options)
        {
        }

        public DbSet<DebateDbEntity> Debates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Debate foreign key
            modelBuilder.Entity<UserDbEntity>()
            .HasMany<DebateDbEntity>(u => u.Debates)
            .WithOne()
            .HasForeignKey(d => d.CreatedBy);
        }
    }
}