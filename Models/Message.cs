namespace ChatAppBlazor.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string SenderUsername { get; set; } = string.Empty; // Boş bir string ile başlatılıyor
        public string Content { get; set; } = string.Empty; // Boş bir string ile başlatılıyor
        public DateTime Timestamp { get; set; }
    }
}
