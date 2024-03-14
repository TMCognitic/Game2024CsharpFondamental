using System.Reflection;
using System.Text.RegularExpressions;

namespace BbanToIban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string account = "000-0000142-45";

            if (!Regex.IsMatch(account, @"^\d{3}-\d{7}-\d{2}$"))
            {
                Console.WriteLine("Format du compte invalide!");
                return;
            }

            account = account.Replace("-", "");

            long tenFirst = long.Parse(account[..10]);
            int twoLast = int.Parse(account[^2..]);
            int modulo = (int)(tenFirst % 97);

            if (!(twoLast == (modulo == 0 ? 97 : modulo)))
            {
                Console.WriteLine("Compte BBAN invalide!");
                return;
            }

            long tempAccount = long.Parse($"{account}111400");
            int twoDigit = (int)(98 - (tempAccount % 97));

            Console.WriteLine($"BE{twoDigit}{account}");
        }
    }
}
