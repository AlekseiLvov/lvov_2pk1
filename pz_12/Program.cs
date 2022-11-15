namespace pz_12
{
    internal class Program
    {
        static void PowerA3(double A, out double B)
        {
            B = A * A * A;
        }
        static void Main(string[] args)
        {
            double b;
            for (int i = 1; i < 6; i++)
            {
                PowerA3(i, out b);
                Console.WriteLine(b);
            }
        }
    }
}