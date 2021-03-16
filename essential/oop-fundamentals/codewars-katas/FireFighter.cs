using System.Text;

namespace codewars_katas
{
    public class FireFighter
    {
        public static string FireFight(string s)
        {
            StringBuilder input = new StringBuilder(s);
            input.Replace("Fire", "~~");
            return input.ToString();
        }
    }
}
