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

        public TwitterService(TwitterApiAccess twitterApiAccess)
        {
            this.httpClient = new HttpClient(new OAuthMessageHandler(new HttpClientHandler(), twitterApiAccess));
            this.apiUrl = twitterApiAccess.ApiUrl;
        }

        public async Task<TwitterSearchResult> SearchAsync(SearchOptions options)
        {
            string json = await GetSearchResponseAsync(options);
            return JsonConvert.DeserializeObject<TwitterSearchResult>(json);
        }

        private async Task<string> GetSearchResponseAsync(SearchOptions options)
        {
            string address = this.apiUrl + options.GetSearchPartAddress();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(address);
            httpResponseMessage.EnsureSuccessStatusCode();

            return await httpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
