using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;
using Refit;

namespace Nindo.Net
{
    public sealed class NindoClient : INindoClient
    {
        private static readonly RefitSettings Settings = new RefitSettings
        {
            ContentSerializer = new NewtonsoftJsonContentSerializer(new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            })
        };

        private readonly INindoClient _service;

        public NindoClient()
        {
            _service = RestService.For<INindoClient>("https://api.nindo.de", Settings);
        }

        public Task<Artist> GetArtistInformationAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));

            return _service.GetArtistInformationAsync(userId);
        }

        public Task<YoutubeChannel> GetYouTubeChannelInformationAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));

            return _service.GetYouTubeChannelInformationAsync(userId);
        }

        public Task<InstagramChannel> GetInstagramChannelInformationAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));

            return _service.GetInstagramChannelInformationAsync(userId);
        }

        public Task<TiktokChannel> GetTikTokChannelInformationAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));

            return _service.GetTikTokChannelInformationAsync(userId);
        }

        public Task<TwitchChannel> GetTwitchChannelInformationAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));

            return _service.GetTwitchChannelInformationAsync(userId);
        }

        public Task<TwitterChannel> GetTwitterChannelInformationAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));

            return _service.GetTwitterChannelInformationAsync(userId);
        }

        public Task<YoutubeChannel[]> GetYouTubeChannelHistoryAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));

            return _service.GetYouTubeChannelHistoryAsync(userId);
        }

        public Task<InstagramChannel[]> GetInstagramChannelHistoryAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));

            return _service.GetInstagramChannelHistoryAsync(userId);
        }

        public Task<TiktokChannel[]> GetTikTokChannelHistoryAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));

            return _service.GetTikTokChannelHistoryAsync(userId);
        }

        public Task<TwitchChannel[]> GetTwitchChannelHistoryAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));

            return _service.GetTwitchChannelHistoryAsync(userId);
        }

        public Task<TwitterChannel[]> GetTwitterChannelHistoryAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));

            return _service.GetTwitterChannelHistoryAsync(userId);
        }

        public Task<Viral[]> GetViralsAsync()
        {
            return _service.GetViralsAsync();
        }

        public Task<Search[]> SearchUserAsync(string term)
        {
            if (string.IsNullOrEmpty(term))
                throw new ArgumentNullException(nameof(term));

            return _service.SearchUserAsync(term);

        }

        public Task<Rank[]> GetViewsScoreboardAsync(RankViewsPlatform platform, Size size)
        {
            return _service.GetViewsScoreboardAsync(platform, size);
        }

        public Task<Rank[]> GetViewersScoreboardAsync(Size size)
        {
            return _service.GetViewersScoreboardAsync(size);
        }

        public Task<Rank[]> GetScoreboardAsync(RankAllPlatform platform, Size size)
        {
            return _service.GetScoreboardAsync(platform, size);
        }

        public Task<Rank[]> GetSubGainScoreboardAsync(RankAllPlatform platform, Size size)
        {
            return _service.GetSubGainScoreboardAsync(platform, size);
        }

        public Task<Rank[]> GetLikesScoreboardAsync(RankLikesPlatform platform, Size size)
        {
            return _service.GetLikesScoreboardAsync(platform, size);
        }

        public Task<Rank[]> GetPeakViewersScoreboardAsync(Size size)
        {
            return _service.GetPeakViewersScoreboardAsync(size);
        }

        public Task<Rank[]> GetWatchtimeScoreboardAsync(Size size)
        {
            return _service.GetWatchtimeScoreboardAsync(size);
        }

        public Task<Rank[]> GetRetweetsScoreboardAsync(Size size)
        {
            return _service.GetRetweetsScoreboardAsync(size);
        }

        public Task<Subscriber[]> GetSubscribersAsync(RankAllPlatform platform, Size size)
        {
            return _service.GetSubscribersAsync(platform, size);
        }

        public Task<Milestone[]> GetMilestonesAsync()
        {
            return _service.GetMilestonesAsync();
        }

        public Task<Milestone[]> GetPastMilestonesAsync()
        {
            return _service.GetPastMilestonesAsync();
        }

        public Task<PostBase[]> GetUserPostsAsync(PostsPlatform platform, string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));

            return _service.GetUserPostsAsync(platform, userId);
        }

        public Task<Coupons> GetCouponsAsync(int offset = 0)
        {
            return _service.GetCouponsAsync(offset);
        }

        public Task<string[]> GetCouponBranchesAsync()
        {
            return _service.GetCouponBranchesAsync();
        }

        public Task<CouponBrands[]> GetCouponBrandsAsync()
        {
            return _service.GetCouponBrandsAsync();
        }

        public Task<Coupons> GetCouponsByCategoryAsync(string category, int offset = 0)
        {
            if (string.IsNullOrEmpty(category))
                throw new ArgumentNullException(nameof(category));

            return _service.GetCouponsByCategoryAsync(category, offset);
        }

        public Task<Coupons> GetCouponsByBranchAsync(string branch, int offset = 0)
        {
            if (string.IsNullOrEmpty(branch))
                throw new ArgumentNullException(nameof(branch));

            return _service.GetCouponsByBranchAsync(branch, offset);
        }
    }
}
