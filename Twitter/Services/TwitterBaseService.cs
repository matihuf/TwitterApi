using System.Net.Http;
using System.Threading.Tasks;
using Twitter.Models;
using Twitter.OAuth;

namespace Twitter
{
    public abstract class TwitterBaseService
    {
        protected HttpClient httpClient;
        protected readonly string apiUrl;

        public TwitterBaseService(TwitterApiAccess twitterApiAccess)
        {
            this.apiUrl = twitterApiAccess.ApiUrl;
            this.httpClient = new HttpClient(new OAuthMessageHandler(new HttpClientHandler(), twitterApiAccess));
        }

        protected async Task<string> GetSearchResponseAsync(string url)
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
            httpResponseMessage.EnsureSuccessStatusCode();
            return await httpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
