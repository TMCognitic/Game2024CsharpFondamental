namespace Equation2emeDegre
{
    struct Eq2d
    {
        public double A, B, C; // Ax² + Bx + C = 0

        public bool Resoudre(out double? x1, out double? x2)
        {
            x1 = x2 = null;

            if (A == 0)
            {
                return false;
            }

            double delta = (B * B) - (4 * A * C);

            if (delta < 0)
            {
                return false;
            }

            x1 = (-B - Math.Sqrt(delta)) / (2 * A);
            x2 = (-B + Math.Sqrt(delta)) / (2 * A);

            return true;
        }
    }
}
