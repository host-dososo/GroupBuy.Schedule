using System.Security.Cryptography;

namespace GroupBuy.Schedule.Services
{
    public class MathService
    {
        public static int Random(int min, int max)
        {
            var rnd = new Random();
            var result = rnd.Next(min,max +1);
            return result;
        }

        public static string GenRandomNumber(int length)
        {
            // 設定要生成的長度
            var randomBytes = new byte[length];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }

            var result = "";
            foreach (var b in randomBytes)
            {
                // 每個 byte 取模 10，以確保每個數字在 0-9 之間
                result += (b % 10).ToString();
            }

            return result;
        }
    }
}
