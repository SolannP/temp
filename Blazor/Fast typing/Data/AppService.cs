using FastTypingKernel;
using System.Runtime.CompilerServices;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace Fast_typing.Data
{
    public class AppService
    {

        public async Task<TargetTextData> GetCommonAppDataAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7294/api/Common/common_data");
            request.Headers.Add("accept", "text/plain");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = JsonSerializer.Deserialize<TargetTextData>(await response.Content.ReadAsStreamAsync());
            return result;
        }

        public async Task<TargetText> GetTargetTextAsync(string id)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://localhost:7294/api/TargetText/text/{id}");
            request.Headers.Add("accept", "text/plain");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = JsonSerializer.Deserialize<TargetText>(await response.Content.ReadAsStreamAsync());
            return result;
        }
        
    }
}
