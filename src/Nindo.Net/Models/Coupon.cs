using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    public class Coupon
    {
        [JsonProperty("timestamp")]
        public string Views { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("terms")]
        public string? Terms { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("validUntil")]
        public string ValidUntil { get; set; }

        [JsonProperty("artistID")]
        public string ArtistId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("_artist")]
        public CouponArtist Artist { get; set; }

        [JsonProperty("_brand")]
        public CouponBrand Brand { get; set; }
    }
}