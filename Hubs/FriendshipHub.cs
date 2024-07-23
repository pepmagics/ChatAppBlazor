using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatAppBlazor.Hubs
{
    public class FriendshipHub : Hub
    {
        public async Task SendFriendRequest(int userId, int friendId)
        {
            await Clients.User(friendId.ToString()).SendAsync("ReceiveFriendRequest", userId);
        }

        public async Task RespondFriendRequest(int userId, int friendId, string status)
        {
            await Clients.User(userId.ToString()).SendAsync("ReceiveFriendResponse", friendId, status);
        }
    }
}
