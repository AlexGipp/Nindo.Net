﻿using System;
using Newtonsoft.Json;

namespace Nindo.Net.Models
{
    class PostBase
    {
        [JsonProperty("postID")]
        public string PostID { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("published")]
        public string Published { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("analytics")]
        public PostAnalytics[] Analytics { get; set; }
    }
}
