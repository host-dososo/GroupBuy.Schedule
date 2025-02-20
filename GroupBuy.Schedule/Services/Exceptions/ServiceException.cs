using System.Runtime.Serialization;

namespace GroupBuy.Schedule.Services.Exceptions
{
    [Serializable] // 如果需要支援序列化，請添加此屬性
    public class ServiceException : Exception
    {
        public int Code { get; set; }
        // 預設建構子
        public ServiceException() : base() { }

        // 帶錯誤訊息的建構子
        public ServiceException(string message) : base(message) { }

        // 帶錯誤訊息和內部例外的建構子
        public ServiceException(string message, Exception innerException,int code) : base(message, innerException) {
            Code = code;
        }

        // 序列化建構子（如果需要支援序列化，請實作這個建構子）
        protected ServiceException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
