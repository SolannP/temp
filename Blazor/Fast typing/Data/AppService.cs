using Fast_typing_Kernel;
using FastTypingKernel;
using System.Runtime.CompilerServices;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace Fast_typing.Data
{
    public class AppService
    {

        public async Task<CommonApplicationData> GetCommonAppDataAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7294/api/Common/common_data");
            request.Headers.Add("accept", "text/plain");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = JsonSerializer.Deserialize<CommonApplicationData>(await response.Content.ReadAsStreamAsync());
            return result;
        }

        public async Task<TargetTextData> GetTargetTextDataAsync(string id)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://localhost:7294/api/TargetText/text/{id}");
            request.Headers.Add("accept", "text/plain");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = JsonSerializer.Deserialize<TargetTextData>(await response.Content.ReadAsStreamAsync());
            return result;
        }
        
    }
}
