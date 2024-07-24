using dadesignart.net.Domain;
using Microsoft.EntityFrameworkCore;

namespace dadesignart.net.Application;

public interface IApplicationDbContext
{

  DbSet<ContactMessage> ContactMessages { get; set; }

  DbSet<Category> Categories { get; set; }

  DbSet<CategoryTranslation> CategoryTranslations { get; set; }

  DbSet<Page> Pages { get; set; }

  DbSet<PageTranslation> PageTranslations { get; set; }

  DbSet<Blog> Blogs { get; set; }

  DbSet<BlogCategory> BlogCategories { get; set; }

  DbSet<BlogTranslation> BlogTranslations { get; set; }

  DbSet<Portfolio> Portfolios { get; set; }

  DbSet<PortfolioCategory> PortfolioCategories { get; set; }

  DbSet<PortfolioTranslation> PortfolioTranslations { get; set; }

  DbSet<Image> Images { get; set; }

  DbSet<User> Users { get; set; }

  DbSet<Role> Roles { get; set; }

  Task<int> SaveChangesAsync(CancellationToken cancellationToken);

  int SaveChanges();

}
