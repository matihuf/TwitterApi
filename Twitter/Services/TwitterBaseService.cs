using System.Net.Http;
using System.Threading.Tasks;
using Twitter.Models;
using Twitter.OAuth;

namespace Twitter
{
    public abstract class TwitterBaseService
    {
        protected HttpClient httpClient;
        protected static string BASE_URL = "https://api.twitter.com/1.1/";

        public TwitterBaseService(TwitterApiAccess twitterApiAccess)
        {
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
