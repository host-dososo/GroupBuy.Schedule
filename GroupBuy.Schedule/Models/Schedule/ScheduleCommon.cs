namespace GroupBuy.Schedule.Models.Schedule
{
    
    public enum ScheduleName { 
        // 發布貼文至LINE社群
        CreatePostToSoc = 2,
        FBAsyncOrder = 3,
        SupplyGoods= 4,
        SysErrorLogSendMail= 5,
        UpdateFBPost= 6,
        UpdateLinePost = 7,
        DeleteFBPost= 8,
        DeleteLinePost= 9,
    }

    public enum ScheduleType
    {
        FireAndForget,   // 即時執行
        Recurring,       // 定期執行
        Delayed,         // 延遲執行
        DelayedToTime,   // 延遲到指定時間
    }
}
