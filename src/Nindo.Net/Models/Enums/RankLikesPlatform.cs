﻿using System.Runtime.Serialization;

namespace Nindo.Net.Models.Enums
{
    public enum RankLikesPlatform
    {
        [EnumMember(Value = "youtube")]
        Youtube = 0,

        [EnumMember(Value = "instagram")]
        Instagram = 1,

        [EnumMember(Value = "tiktok")]
        TikTok = 2,

        [EnumMember(Value = "twitter")]
        Twitter = 3
    }
}