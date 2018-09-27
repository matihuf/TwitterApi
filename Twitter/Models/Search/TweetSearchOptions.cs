using System.Text;

namespace Twitter.Models.Search
{
    public class TweetSearchOptions : SearchOptions
    {
        public string Lang { get; set; }

        public override string GetSearchPartAddress()
        {
            StringBuilder searchPart = new StringBuilder();
            searchPart.Append(base.GetSearchPartAddress());
            if (searchPart.Length > 0)
            {
                searchPart.Append("&");
            }

            if (!string.IsNullOrEmpty(Lang))
            {
                searchPart.Append("lang=" + Lang);
            }

            return searchPart.ToString();
        }
    }
}
