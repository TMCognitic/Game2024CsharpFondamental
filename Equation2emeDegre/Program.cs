namespace Equation2emeDegre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eq2d eq2d_1 = new Eq2d() { A = 4, B = 4, C = 1 };
            //if(eq2d_1.Resoudre(out double? x1, out double? x2))
            //{
            //    Console.WriteLine($"X1 : {x1!.Value} - X2 : {x2!.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("No result!");
            //}

            Console.WriteLine(eq2d_1.Resoudre(out double? x1, out double? x2) ? $"X1 : {x1!.Value} - X2 : {x2!.Value}" : "No result!");
        }
    }
}
