using QuickType.UserSearchResponse;
using System.Threading.Tasks;
using Twitter.Models;
using Twitter.Models.Search;

namespace Twitter.Services.AccountsAndUsers
{
    public class TwitterUserService : TwitterBaseService
    {
        private const string USER_URL = "users/search.json?";

        public TwitterUserService(TwitterApiAccess twitterApiAccess) : base(twitterApiAccess)
        {
        }

        public async Task<UserSearchResponse[]> SearchAsync(UserSearchOptions options)
        {
            string url = apiUrl + USER_URL + options.GetSearchPartAddress();
            string json = await GetSearchResponseAsync(url);
            return UserSearchResponse.FromJson(json);
        }
    }
}
