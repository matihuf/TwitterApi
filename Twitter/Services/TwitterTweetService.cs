using QuickType.TweetsResponse;
using System.Threading.Tasks;
using Twitter.Models;
using Twitter.Models.Search;

namespace Twitter.Services.Tweets
{
    public class TwitterTweetService : TwitterBaseService
    {
        private const string SEARCH_URL = "search/tweets.json?";

        public TwitterTweetService(TwitterApiAccess twitterApiAccess) : base(twitterApiAccess)
        {
        }

        public async Task<TweetsResponse> SearchAsync(SearchOptions options)
        {
            string url = apiUrl + SEARCH_URL + options.GetSearchPartAddress();
            string json = await GetSearchResponseAsync(url);
            return TweetsResponse.FromJson(json);
        }
    }
}
