using dadesignart.net.Domain;

namespace dadesignart.net.Application;

public interface IJwtService
{
  JwtDto GenerateToken(User user, List<string> roles);
  Task<JwtDto> GenerateTokenAsync(Guid userId, string email, CancellationToken cancellationToken);
}
