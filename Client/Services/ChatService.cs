using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ASP.NET_Core_Web_API.Server.Services
{
    public class ChatService
    {
        private readonly HttpClient _httpClient;

        public ChatService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ChatMessage>> GetMessagesAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ChatMessage>>("api/chat");
        }

        public async Task SendMessageAsync(ChatMessage message)
        {
            await _httpClient.PostAsJsonAsync("api/chat", message);
        }
    }

}
