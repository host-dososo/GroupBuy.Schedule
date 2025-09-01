namespace GroupBuy.Schedule.Models.Schedule.Service
{

    public class AddResult
    {
        public string? JobId { get; set; }
        public string? RecurringJobId { get; set; }

        public DateTime? ExpireAt { get; set; }
    }

    public class EditResult
    {
        public string? JobId { get; set; }

        public DateTime? ExpireAt { get; set; }
    }


    public class RequeueResult
    {
        public string? JobId { get; set; }
        public string? RecurringJobId { get; set; }
    }
}
