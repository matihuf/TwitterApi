using Newtonsoft.Json;

namespace Twitter.Models
{
    public class TwitterApiAccess
    {
        [JsonProperty("ApiUrl")]
        public string ApiUrl { get; set; }

        [JsonProperty("ConsumerKey")]
        public string ConsumerKey { get; set; }

        [JsonProperty("ConsumerSecret")]
        public string ConsumerSecret { get; set; }

        [JsonProperty("Token")]
        public string Token { get; set; }

        [JsonProperty("TokenSecret")]
        public string TokenSecret { get; set; }
    }
}
