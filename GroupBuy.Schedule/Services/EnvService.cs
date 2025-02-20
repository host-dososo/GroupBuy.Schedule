namespace GroupBuy.Schedule.Services
{
    public class EnvService
    {
        public static IWebHostEnvironment WebHostEnvironment { get; private set; }

        public static void Initialize(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public static string ContentRootPath => WebHostEnvironment?.ContentRootPath;
        public static string WebRootPath => WebHostEnvironment?.WebRootPath;
    }
}
