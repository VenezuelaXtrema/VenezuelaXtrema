using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities.Product;
using Store.Domain.Entities.User;

namespace Store.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User,
                                        Role,
                                        Guid,
                                        IdentityUserClaim<Guid>,
                                        UserRole,
                                        IdentityUserLogin<Guid>,
                                        IdentityRoleClaim<Guid>,
                                        IdentityUserToken<Guid>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
                userRole.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);
                userRole.Property(p => p.IsDeleted).HasDefaultValue(false);
            }).HasDefaultSchema("Security");

            builder.Entity<Role>(role =>
            {
                role.Property(p => p.Name).IsRequired();
                role.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);
                role.Property(p => p.IsDeleted).HasDefaultValue(false);
            }).HasDefaultSchema("Security");

            builder.Entity<User>(user =>
            {
                user.Property(p => p.UserName).IsRequired();
                user.Property(p => p.CreatedAt).HasDefaultValue(DateTime.Now);
                user.Property(p => p.IsDeleted).HasDefaultValue(false);
            }).HasDefaultSchema("Security");

            builder.Entity<Product>(product =>
            {
                product.Property(product => product.Price).HasColumnType("decimal");
                product.Property(product => product.Price).HasPrecision(18);
                product.Property(product => product.IsDeleted).HasDefaultValue(false);
                product.Property(product => product.CreatedAt).HasDefaultValue(DateTime.Now);
                product.Property(product => product.ModifyAt).HasDefaultValue(DateTime.Now);
            });
        }
    }
}
