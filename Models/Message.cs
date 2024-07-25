namespace ChatAppBlazor.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string SenderUsername { get; set; } // Yeni özellik eklendi
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
