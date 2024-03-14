namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int premier = 1;
            int second = 1;

            Console.WriteLine(premier);
            Console.WriteLine(second);

            for (int i = 0; i < 23; i++)
            {
                int addition = premier + second;
                Console.WriteLine(addition);
                premier = second;
                second = addition;
            }

            //for (int i = 0, addition = premier + second; i < 23; i++, premier = second, second = addition, addition = premier + second)
            //{
            //    Console.WriteLine(addition);
            //}
        }
    }
}
