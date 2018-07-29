using System.Text;

namespace Twitter.Models
{
    public class SearchOptions
    {
        public string Q { get; set; }
        public int? Count { get; set; }
        public string Lang { get; set; }

        public string GetSearchPartAddress()
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
                searchPart.Append("&");
            }
            if (!string.IsNullOrEmpty(Lang))
            {
                searchPart.Append("lang=" + Lang);
                searchPart.Append("&");
            }

            return searchPart.Remove(searchPart.Length - 1, 1).ToString();
        }
    }
}
