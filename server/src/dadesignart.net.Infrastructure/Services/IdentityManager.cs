using dadesignart.net.Application;
using dadesignart.net.Domain;
using Microsoft.AspNetCore.Identity;

namespace dadesignart.net.Infrastructure;

public class IdentityManager : IIdentityService
{
  private readonly IJwtService _jwtService;
  private readonly UserManager<User> _userManager;
  private readonly ICurrentUserService _currentUserService;
  private readonly IApplicationDbContext _applicationDbContext;

  public IdentityManager(UserManager<User> userManager, IJwtService jwtService, ICurrentUserService currentUserService, IApplicationDbContext applicationDbContext)
  {
    _userManager = userManager;
    _jwtService = jwtService;
    _currentUserService = currentUserService;
    _applicationDbContext = applicationDbContext;
  }

  public Task<bool> CheckIfEmailVerifiedAsync(string email, CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }

  public Task<bool> CheckPasswordSignInAsync(string email, string password, CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }

  public Task<bool> IsEmailExistsAsync(string email, CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }
}
