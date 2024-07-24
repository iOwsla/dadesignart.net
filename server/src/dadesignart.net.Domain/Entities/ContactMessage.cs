namespace dadesignart.net.Domain;

public class ContactMessage : BaseEntity<Guid>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public bool IsRead { get; set; }
}
