using System.Text;

namespace Twitter.Models.Search
{
    public class UserSearchOptions : SearchOptions
    {
        public int? Page { get; set; }

        public override string GetSearchPartAddress()
        {
            StringBuilder searchPart = new StringBuilder();
            searchPart.Append(base.GetSearchPartAddress());
            if(searchPart.Length > 0)
            {
                searchPart.Append("&");
            }

            if (Page.HasValue)
            {
                searchPart.Append("page=" + Page.Value);
            }

            return searchPart.ToString();
        }
    }
}
