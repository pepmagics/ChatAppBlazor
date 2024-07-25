namespace ChatAppBlazor.Models
{
    public class Friendship
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendId { get; set; }
        public string Status { get; set; } = string.Empty; // Boş bir string ile başlatılıyor
    }
}
