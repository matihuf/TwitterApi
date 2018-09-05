using System.Text;

namespace Twitter.Models.Search
{
    public class SearchOptions
    {
        public string Q { get; set; }
        public int? Count { get; set; }

        public virtual string GetSearchPartAddress()
        {
            StringBuilder searchPart = new StringBuilder();
            if(!string.IsNullOrEmpty(Q))
            {
                searchPart.Append("q=");
                searchPart.Append(Q.Replace("#", string.Empty));
                searchPart.Append("&");
            }
            if(Count.HasValue)
            {
                searchPart.Append("count=" + Count.Value);
            }

            return searchPart.ToString();
        }
    }
}
