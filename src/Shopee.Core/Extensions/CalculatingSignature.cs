using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Light.Shopee.Extensions
{
    public class CalculatingSignature
    {
        public static string GenerateSignature(string secretKey, string baseString) => CalcHmac(secretKey, baseString);

        private static string CalcHmac(string secretKey, string baseString)
        {
            byte[] key = Encoding.ASCII.GetBytes(secretKey);
            var myhmacsha256 = new HMACSHA256(key);
            byte[] byteArray = Encoding.ASCII.GetBytes(baseString);
            var stream = new MemoryStream(byteArray);
            string result = myhmacsha256.ComputeHash(stream).Aggregate("", (s, e) => s + string.Format("{0:x2}", e), s => s);
            //Console.WriteLine(result);
            return result;
        }
    }
}
