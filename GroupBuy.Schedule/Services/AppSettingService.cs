namespace GroupBuy.Schedule.Services
{
    public class AppSettingService
    {
        private static IConfigurationRoot _configuration = null!;

        public static T Get<T>(params string[] Keys)
        {
            _configuration = GetCurrentConfiguration();
            string key = string.Join(':', Keys);
            return _configuration.GetSection(key).Get<T>();
        }

        public static string Get(params string[] Keys)
        {
            _configuration = GetCurrentConfiguration();
            string key = string.Join(':', Keys);
            return _configuration.GetSection(key).Get<string>();
        }

        public static string GetConnectionString(string key = "DefaultConnection")
        {
            _configuration = GetCurrentConfiguration();
            return Get<string>("ConnectionStrings:" + key);
        }

        public static bool IsDevelopment() {
            _configuration = GetCurrentConfiguration();
            return Get<string>("Env") == "Development";
        }

        public static bool IsProduction()
        {
            _configuration = GetCurrentConfiguration();
            return Get<string>("Env") == "Production";
        }
        public static string GetJwtSecretKey()
        {
            return Get("JwtSettings", "SecretKey");
        }

        public static string GetJwtIssuer()
        {
            return Get("JwtSettings", "Issuer");
        }

        public static string GetJwtAudience()
        {
            return Get("JwtSettings", "Audience");
        }
        // Get a valued stored in the appsettings.
        // Pass in a key like TestArea:TestKey to get TestValue
        public static IConfigurationRoot GetCurrentConfiguration()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", false, false)
                            .AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true)
                            .AddEnvironmentVariables();

            IConfigurationRoot configuration = builder.Build();

            return configuration;
        }
    }
}
