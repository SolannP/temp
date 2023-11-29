using FastTypingKernel;
using System.Runtime.CompilerServices;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace Fast_typing.Data
{
    public class AppService
    {
        public readonly string url;
        public AppService(IConfiguration configuration) { 
            url = configuration!.GetSection("EndPoint")!.GetValue<string>("AppService")!;
            if(url is null) throw new ArgumentNullException($"[!] Configured value {nameof(url)} cannot be null, please check configuration file");
        }
        public async Task<TargetTextData> GetCommonAppDataAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"{url}/api/target_text_data");
            request.Headers.Add("accept", "text/plain");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = JsonSerializer.Deserialize<TargetTextData>(await response.Content.ReadAsStreamAsync());
            return result;
        }

        public async Task<TargetText> GetTargetTextAsync(string id)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"{url}/api/target_text_data/{id}");
            request.Headers.Add("accept", "text/plain");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = JsonSerializer.Deserialize<TargetText>(await response.Content.ReadAsStreamAsync());
            return result;
        }
        
    }
}
