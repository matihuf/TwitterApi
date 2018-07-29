namespace Twitter.Models
{
    using System;
    using Newtonsoft.Json;

    public partial class TwitterSearchResult
    {
        [JsonProperty("statuses")]
        public Status[] Statuses { get; set; }

        [JsonProperty("search_metadata")]
        public SearchMetadata SearchMetadata { get; set; }
    }

    public partial class SearchMetadata
    {
        [JsonProperty("completed_in")]
        public double CompletedIn { get; set; }

        [JsonProperty("max_id")]
        public long? MaxId { get; set; }

        [JsonProperty("max_id_str")]
        public string MaxIdStr { get; set; }

        [JsonProperty("next_results")]
        public string NextResults { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("refresh_url")]
        public string RefreshUrl { get; set; }

        [JsonProperty("count")]
        public long? Count { get; set; }

        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        [JsonProperty("since_id_str")]
        public long? SinceIdStr { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("created_at")]
        public string CreatedAtString { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt
        {
            get { return DateTime.ParseExact(CreatedAtString, "ddd MMM dd HH:mm:ss +ffff yyyy", new System.Globalization.CultureInfo("en-US")); }
        }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }

        [JsonProperty("entities")]
        public StatusEntities Entities { get; set; }

        [JsonProperty("extended_entities")]
        public ExtendedEntities ExtendedEntities { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("in_reply_to_status_id")]
        public long? InReplyToStatusId { get; set; }

        [JsonProperty("in_reply_to_status_id_str")]
        public string InReplyToStatusIdStr { get; set; }

        [JsonProperty("in_reply_to_user_id")]
        public long? InReplyToUserId { get; set; }

        [JsonProperty("in_reply_to_user_id_str")]
        public long? InReplyToUserIdStr { get; set; }

        [JsonProperty("in_reply_to_screen_name")]
        public string InReplyToScreenName { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("geo")]
        public object Geo { get; set; }

        [JsonProperty("coordinates")]
        public object Coordinates { get; set; }

        [JsonProperty("place")]
        public object Place { get; set; }

        [JsonProperty("contributors")]
        public object Contributors { get; set; }

        [JsonProperty("is_quote_status")]
        public bool IsQuoteStatus { get; set; }

        [JsonProperty("retweet_count")]
        public long? RetweetCount { get; set; }

        [JsonProperty("favorite_count")]
        public long? FavoriteCount { get; set; }

        [JsonProperty("favorited")]
        public bool Favorited { get; set; }

        [JsonProperty("retweeted")]
        public bool Retweeted { get; set; }

        [JsonProperty("possibly_sensitive")]
        public bool PossiblySensitive { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }
    }

    public partial class StatusEntities
    {
        [JsonProperty("hashtags")]
        public object[] Hashtags { get; set; }

        [JsonProperty("symbols")]
        public object[] Symbols { get; set; }

        [JsonProperty("user_mentions")]
        public UserMention[] UserMentions { get; set; }

        [JsonProperty("urls")]
        public Url[] Urls { get; set; }

        [JsonProperty("media")]
        public Media[] Media { get; set; }
    }

    public partial class Media
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("indices")]
        public long?[] Indices { get; set; }

        [JsonProperty("media_url")]
        public string MediaUrl { get; set; }

        [JsonProperty("media_url_https")]
        public string MediaUrlHttps { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("display_url")]
        public string DisplayUrl { get; set; }

        [JsonProperty("expanded_url")]
        public string ExpandedUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sizes")]
        public Sizes Sizes { get; set; }
    }

    public partial class Sizes
    {
        [JsonProperty("thumb")]
        public Large Thumb { get; set; }

        [JsonProperty("medium")]
        public Large Medium { get; set; }

        [JsonProperty("large")]
        public Large Large { get; set; }

        [JsonProperty("small")]
        public Large Small { get; set; }
    }

    public partial class Large
    {
        [JsonProperty("w")]
        public long? W { get; set; }

        [JsonProperty("h")]
        public long? H { get; set; }

        [JsonProperty("resize")]
        public string Resize { get; set; }
    }

    public partial class UserMention
    {
        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("indices")]
        public long?[] Indices { get; set; }
    }

    public partial class ExtendedEntities
    {
        [JsonProperty("media")]
        public Media[] Media { get; set; }
    }

    public partial class Metadata
    {
        [JsonProperty("iso_language_code")]
        public string IsoLanguageCode { get; set; }

        [JsonProperty("result_type")]
        public string ResultType { get; set; }
    }

    public partial class User
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public object Url { get; set; }

        [JsonProperty("entities")]
        public UserEntities Entities { get; set; }

        [JsonProperty("protected")]
        public bool Protected { get; set; }

        [JsonProperty("followers_count")]
        public long? FollowersCount { get; set; }

        [JsonProperty("friends_count")]
        public long? FriendsCount { get; set; }

        [JsonProperty("listed_count")]
        public long? ListedCount { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("favourites_count")]
        public long? FavouritesCount { get; set; }

        [JsonProperty("utc_offset")]
        public object UtcOffset { get; set; }

        [JsonProperty("time_zone")]
        public object TimeZone { get; set; }

        [JsonProperty("geo_enabled")]
        public bool GeoEnabled { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("statuses_count")]
        public long? StatusesCount { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("contributors_enabled")]
        public bool ContributorsEnabled { get; set; }

        [JsonProperty("is_translator")]
        public bool IsTranslator { get; set; }

        [JsonProperty("is_translation_enabled")]
        public bool IsTranslationEnabled { get; set; }

        [JsonProperty("profile_background_color")]
        public string ProfileBackgroundColor { get; set; }

        [JsonProperty("profile_background_image_url")]
        public string ProfileBackgroundImageUrl { get; set; }

        [JsonProperty("profile_background_image_url_https")]
        public string ProfileBackgroundImageUrlHttps { get; set; }

        [JsonProperty("profile_background_tile")]
        public bool ProfileBackgroundTile { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("profile_image_url_https")]
        public string ProfileImageUrlHttps { get; set; }

        [JsonProperty("profile_banner_url")]
        public string ProfileBannerUrl { get; set; }

        [JsonProperty("profile_link_color")]
        public string ProfileLinkColor { get; set; }

        [JsonProperty("profile_sidebar_border_color")]
        public string ProfileSidebarBorderColor { get; set; }

        [JsonProperty("profile_sidebar_fill_color")]
        public string ProfileSidebarFillColor { get; set; }

        [JsonProperty("profile_text_color")]
        public string ProfileTextColor { get; set; }

        [JsonProperty("profile_use_background_image")]
        public bool ProfileUseBackgroundImage { get; set; }

        [JsonProperty("has_extended_profile")]
        public bool HasExtendedProfile { get; set; }

        [JsonProperty("default_profile")]
        public bool DefaultProfile { get; set; }

        [JsonProperty("default_profile_image")]
        public bool DefaultProfileImage { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("follow_request_sent")]
        public bool FollowRequestSent { get; set; }

        [JsonProperty("notifications")]
        public bool Notifications { get; set; }

        [JsonProperty("translator_type")]
        public string TranslatorType { get; set; }
    }

    public partial class UserEntities
    {
        [JsonProperty("description")]
        public Description Description { get; set; }
    }

    public partial class Description
    {
        [JsonProperty("urls")]
        public Url[] Urls { get; set; }
    }

    public partial class Url
    {
        [JsonProperty("url")]
        public string UrlUrl { get; set; }

        [JsonProperty("expanded_url")]
        public string ExpandedUrl { get; set; }

        [JsonProperty("display_url")]
        public string DisplayUrl { get; set; }

        [JsonProperty("indices")]
        public long?[] Indices { get; set; }
    }
}