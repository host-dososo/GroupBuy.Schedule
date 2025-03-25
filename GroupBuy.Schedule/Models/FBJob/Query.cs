using GroupBuy.Schedule.Models.Schedule.Service;

namespace GroupBuy.Schedule.Models.FBJob.Query
{
    public class FBAsyncOrderRequest
    {
        public int MerchantId { get; set; }
        public string? JobId { get; set; }
        public bool WithPhotos { get; set; }
        public List<string> FeedCodes { get; set; }
        public List<string> GroupIds { get; set; }
        public List<string> ExcludeCommentIds { get; set; }
        public string? GroupTimeType { get; set; }  // end/start (結團時間/開團時間)
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public bool? IsScheduled { get; set; }
    }

    public class FBAsyncOrderRequestWithNotice : FBAsyncOrderRequest
    {
        public decimal MerNoticeId { get; set; }
    }
}
