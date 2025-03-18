namespace ASP.NET_Core_Web_API.Server.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private static List<ChatMessage> messages = new List<ChatMessage>();

        [HttpGet]
        public IEnumerable<ChatMessage> GetMessages()
        {
            return messages.OrderBy(m => m.Timestamp);
        }

        [HttpPost]
        public IActionResult PostMessage(ChatMessage message)
        {
            message.Timestamp = DateTime.Now;
            messages.Add(message);
            return Ok();
        }
    }
}