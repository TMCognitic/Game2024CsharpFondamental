using System.Text.RegularExpressions;

namespace BbanAccountValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string account1 = "000-0000142-43";
            string account2 = "000-0000142-45";
            string account3 = "000-0000000-97";

            string account = account3;

            if (!Regex.IsMatch(account, @"^\d{3}-\d{7}-\d{2}$"))
            {
                Console.WriteLine("Format du compte invalide!");
                return;
            }

            account = account.Replace("-", "");

            long tenFirst = long.Parse(account[..10]);
            int twoLast = int.Parse(account[^2..]);
            int modulo = (int)(tenFirst % 97);

            Console.WriteLine(twoLast == (modulo == 0 ? 97 : modulo) ? "OK" : "KO");

        }
    }
}
