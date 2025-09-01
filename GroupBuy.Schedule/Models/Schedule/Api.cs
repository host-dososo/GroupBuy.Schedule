using GroupBuy.Schedule.Models.Schedule.Service;

namespace GroupBuy.Schedule.Models.Schedule.Api
{

    public class ScheduleAddRequest
    {
        public string ScheduleName { get; set; } = null!;      
        public ScheduleType ScheduleType { get; set; }
        public string? Payload { get; set; } = null;
        public string? CronExpression { get; set; } = null;     // 用於 recurring 排程的 Cron 表達式
        public int? DelayInMinutes { get; set; } = null;      // 用於延遲排程的延遲時間（以分鐘為單位）
        public DateTime? ExecuteAt { get; set; } = null;     // 用於延遲到指定時間排程的時間點
    }

    public class ScheduleEditRequest
    {
        public string JobId { get; set; }
        public DateTime? ExecuteAt { get; set; } = null;     // 用於延遲到指定時間排程的時間點
    }

    public class ScheduleRemoveRequest
    {
        public string JobId { get; set; }
        public bool WithRecurringJob { get; set; }
    }
    
    public class ScheduleRequeueRequest
    {
        public string JobId { get; set; }
        public string? RecurringJobId { get; set; }
    }

    public class ScheduleAddResponse : AddResult
    {      
    }

    public class ScheduleEditResponse : EditResult
    {
    }

    public class ScheduleRequeueResponse : RequeueResult
    {
    }

    public class ScheduleRemoveResponse
    {
        public bool IsSuc { get; set; }
    }
}
