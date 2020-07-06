namespace Common
{
    using System.Security.Cryptography;
    using System.Text;

    public class Encriptador
    {
        public static string GetSha256(string str)
        {
            SHA256 sha256 = SHA256.Create();

            ASCIIEncoding encoding = new ASCIIEncoding();

            StringBuilder sb = new StringBuilder();

            var stream = sha256.ComputeHash(encoding.GetBytes(str));

            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);

            return sb.ToString();
        }
    }
}