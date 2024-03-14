namespace RangeSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "000000014245";

            Index index = new Index(value: 0, fromEnd: false);
            Index index2 = new Index(value: 10, fromEnd: false);
            Range range = new Range(index, index2);
            range = index..index2;

            Console.WriteLine(text[index..index2]);
            Console.WriteLine(text[range]);
            Console.WriteLine(text[0..10]);
            Console.WriteLine(text[..10]);

            Index index3 = new Index(value: 2, fromEnd: true);
            Console.WriteLine(text[index3..]);
            Console.WriteLine(text[^2..]);
        }
    }
}
