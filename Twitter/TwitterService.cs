using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Twitter.Models;
using Twitter.OAuth;

namespace Twitter
{
    public class TwitterService
    {
        private HttpClient httpClient;
        private string apiUrl;

        public TwitterService(TwitterAccess twitterAccess)
        {
            this.httpClient = new HttpClient(new OAuthMessageHandler(new HttpClientHandler(), twitterAccess));
            this.apiUrl = twitterAccess.ApiUrl;
        }

        public async Task<TwitterSearchResult> Search(SearchOptions options)
        {
            string json = await GetSearchResponse(options);
            return JsonConvert.DeserializeObject<TwitterSearchResult>(json);
        }

        private async Task<string> GetSearchResponse(SearchOptions options)
        {
            string address = this.apiUrl + options.GetSearchPartAddress();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(address);
            httpResponseMessage.EnsureSuccessStatusCode();

            return await httpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
