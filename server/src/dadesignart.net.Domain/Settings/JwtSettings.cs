namespace dadesignart.net.Domain;

public class JwtSettings
{
  public string SecretKey { get; set; }
  public int AccessTokenExpirationInMinutes { get; set; }
  public int RefreshTokenExpirationInDays { get; set; }
  public string Issuer { get; set; }
  public string Audience { get; set; }
}
