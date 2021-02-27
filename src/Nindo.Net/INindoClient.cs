using System.Threading.Tasks;
using Nindo.Net.Models;
using Nindo.Net.Models.Enums;
using Refit;

namespace Nindo.Net
{
    public interface INindoClient
    {
        #region Artist

        [Get("/artist/{userId}")]
        Task<Artist> GetArtistInformationAsync(string userId);

        #endregion

        #region Channel

        [Get("/channel/youtube/{userId}")]
        Task<YoutubeChannel> GetYouTubeChannelInformationAsync(string userId);

        [Get("/channel/instagram/{userId}")]
        Task<InstagramChannel> GetInstagramChannelInformationAsync(string userId);

        [Get("/channel/tiktok/{userId}")]
        Task<TiktokChannel> GetTikTokChannelInformationAsync(string userId);

        [Get("/channel/twitch/{userId}")]
        Task<TwitchChannel> GetTwitchChannelInformationAsync(string userId);

        [Get("/channel/twitter/{userId}")]
        Task<TwitterChannel> GetTwitterChannelInformationAsync(string userId);


        [Get("/channel/historic/youtube/{userId}")]
        Task<YoutubeChannel[]> GetYouTubeChannelHistoryAsync(string userId);

        [Get("/channel/historic/instagram/{userId}")]
        Task<InstagramChannel[]> GetInstagramChannelHistoryAsync(string userId);

        [Get("/channel/historic/tiktok/{userId}")]
        Task<TiktokChannel[]> GetTikTokChannelHistoryAsync(string userId);

        [Get("/channel/historic/twitch/{userId}")]
        Task<TwitchChannel[]> GetTwitchChannelHistoryAsync(string userId);

        [Get("/channel/historic/twitter/{userId}")]
        Task<TwitterChannel[]> GetTwitterChannelHistoryAsync(string userId);

        #endregion

        #region Viral

        [Get("/viral/")]
        Task<Viral[]> GetViralsAsync();

        #endregion

        #region Search

        [Get("/search/smart/{term}")]
        Task<Search[]> SearchUserAsync(string term);

        #endregion

        #region Ranks

        [Get("/ranks/charts/{platform}/rankViews/{size}")]
        Task<Rank[]> GetViewsScoreboardAsync(RankViewsPlatform platform, Size size);

        [Get("/ranks/charts/twitch/rankViewer/{size}")]
        Task<Rank[]> GetViewersScoreboardAsync(Size size);

        [Get("/ranks/charts/{platform}/rank/{size}")]
        Task<Rank[]> GetScoreboardAsync(RankAllPlatform platform, Size size);

        [Get("/ranks/charts/{platform}/rankSubGain/{size}")]
        Task<Rank[]> GetSubGainScoreboardAsync(RankAllPlatform platform, Size size);

        [Get("/ranks/charts/{platform}/rankLikes/{size}")]
        Task<Rank[]> GetLikesScoreboardAsync(RankLikesPlatform platform, Size size);

        [Get("/ranks/charts/twitch/rankPeakViewer/{size}")]
        Task<Rank[]> GetPeakViewersScoreboardAsync(Size size);

        [Get("/ranks/charts/twitch/rankWatchtime/{size}")]
        Task<Rank[]> GetWatchtimeScoreboardAsync(Size size);

        [Get("/ranks/charts/twitter/rankRetweets/{size}")]
        Task<Rank[]> GetRetweetsScoreboardAsync(Size size);

        [Get("/ranks/charts/{platform}/subscribers/{size}")]
        Task<Subscriber[]> GetSubscribersAsync(RankAllPlatform platform, Size size);

        [Get("/ranks/milestones")]
        Task<Milestone[]> GetMilestonesAsync();

        [Get("/ranks/pastMilestones")]
        Task<Milestone[]> GetPastMilestonesAsync();

        #endregion

        #region Posts

        [Get("/posts/{platform}/{userId}")]
        Task<PostBase[]> GetUserPostsAsync(PostsPlatform platform, string userId);

        #endregion

        #region Coupons

        [Get("/coupons/?offset={offset}")]
        Task<Coupons> GetCouponsAsync(int offset = 0);

        [Get("/coupons/branches")]
        Task<string[]> GetCouponBranchesAsync();

        [Get("/coupons/brands")]
        Task<CouponBrands[]> GetCouponBrandsAsync();

        [Get("/coupons/by/{category}/?offset={offset}")]
        Task<Coupons> GetCouponsByCategoryAsync(string category, int offset = 0);

        [Get("/coupons/for/{branch}/?offset={offset}")]
        Task<Coupons> GetCouponsByBranchAsync(string branch, int offset = 0);

        #endregion
    }
}