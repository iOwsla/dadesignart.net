namespace dadesignart.net.Application;

public interface IIdentityService
{
  // Task<UserAuthRegisterResponseDto> RegisterAsync(UserAuthRegisterCommand command, CancellationToken cancellationToken);
  // Task<JwtDto> LoginAsync(UserAuthLoginCommand command, CancellationToken cancellationToken);
  // Task<JwtDto> SocialLoginAsync(UserAuthSocialLoginCommand command, CancellationToken cancellationToken);
  Task<bool> IsEmailExistsAsync(string email, CancellationToken cancellationToken);
  Task<bool> CheckPasswordSignInAsync(string email, string password, CancellationToken cancellationToken);
  // Task<bool> VerifyEmailAsync(UserAuthVerifyEmailCommand command, CancellationToken cancellationToken);
  Task<bool> CheckIfEmailVerifiedAsync(string email, CancellationToken cancellationToken);
  // Task<UserGetProfileDto> GetProfileAsync(CancellationToken cancellationToken);
}
