namespace ChatAppBlazor.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty; // Boş bir string ile başlatılıyor
        public string Email { get; set; } = string.Empty; // Boş bir string ile başlatılıyor
        public string PasswordHash { get; set; } = string.Empty; // Boş bir string ile başlatılıyor
    }
}
