using dadesignart.net.Application;
using dadesignart.net.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dadesignart.net.Infrastructure;

public class ApplicationDbContext : IdentityDbContext<User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>, IApplicationDbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
  {

  }
  public DbSet<ContactMessage> ContactMessages { get; set; }
  public DbSet<Category> Categories { get; set; }
  public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
  public DbSet<Page> Pages { get; set; }
  public DbSet<PageTranslation> PageTranslations { get; set; }
  public DbSet<Blog> Blogs { get; set; }
  public DbSet<BlogCategory> BlogCategories { get; set; }
  public DbSet<BlogTranslation> BlogTranslations { get; set; }
  public DbSet<Portfolio> Portfolios { get; set; }
  public DbSet<PortfolioCategory> PortfolioCategories { get; set; }
  public DbSet<PortfolioTranslation> PortfolioTranslations { get; set; }
  public DbSet<Image> Images { get; set; }
  public DbSet<User> Users { get; set; }
  public DbSet<Role> Roles { get; set; }

  protected override void OnModelCreating(ModelBuilder builder)
  {
    base.OnModelCreating(builder);

    //builder.ApplyConfiguration(new OrderConfiguration());
    //builder.ApplyConfiguration(new UserBalanceConfiguration());
    //builder.ApplyConfiguration(new UserBalanceHistoryConfiguration());

    builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
  }
}
