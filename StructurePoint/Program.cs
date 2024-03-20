namespace StructurePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point?[,] points = new Point?[5, 5]
            {
                { new Point() { X = 1, Y = 1 }, null, null, null, null },
                { null, new Point() { X = 2, Y = 2 }, null, null, null },
                { null, null, new Point() { X = 3, Y = 3 }, null, null },
                { null, null, null, new Point() { X = 4, Y = 4 }, null },
                { null, null, null, null, new Point() { X = 5, Y = 5 } },
            };

            //for (int i = 0; i < 5; i++)
            //{
            //    points[i, i] = new Point() { X = i + 1, Y = i + 1 };
            //}

            for (int row = 0; row < 5; row++) 
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write(points[col, row] is null ? "\t" : $"X:{points[col, row]!.Value.X}-Y:{points[col, row]!.Value.Y}");
                }
                Console.WriteLine();
            }
        }
    }
}
