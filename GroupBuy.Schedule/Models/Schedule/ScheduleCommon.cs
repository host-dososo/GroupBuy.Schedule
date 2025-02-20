namespace GroupBuy.Schedule.Models.Schedule
{
    
    public enum ScheduleName { 
        // 發布貼文至LINE記事本
        CreatePostToLine = 2,
        FBAsyncOrder = 3,
    }

    public enum ScheduleType
    {
        FireAndForget,   // 即時執行
        Recurring,       // 定期執行
        Delayed,         // 延遲執行
        DelayedToTime,   // 延遲到指定時間
    }
}
