using ChatAppBlazor.Data;
using ChatAppBlazor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ChatAppBlazor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FriendshipController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FriendshipController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("send-request")]
        public async Task<IActionResult> SendRequest(Friendship friendship)
        {
            friendship.Status = "Pending";
            _context.Friendships.Add(friendship);
            await _context.SaveChangesAsync();
            return Ok(friendship);
        }

        [HttpPost("respond-request")]
        public async Task<IActionResult> RespondRequest(int friendshipId, string status)
        {
            var friendship = await _context.Friendships.FindAsync(friendshipId);
            if (friendship == null)
            {
                return NotFound();
            }
            friendship.Status = status;
            await _context.SaveChangesAsync();
            return Ok(friendship);
        }
    }
}
