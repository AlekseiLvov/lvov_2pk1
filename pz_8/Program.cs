namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int r;

            const int n = 3;
            const int m = 3;
            const int maxValue = 44;
            const int minValue = 0;

            int[,] mas = new int[n, m];
            int min = 1;
            int max = minValue;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    r = rand.Next(minValue, maxValue);
                    mas[i, j] = r;
                }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(mas[i, j] + "\t");
                Console.WriteLine();
            }

            for (int i = 0; i < m; i++)
            {
                min = mas[0, i];
                for (int j = 0; j < n - 1; j++)
                    if (min > mas[j + 1, i])
                        min = mas[j + 1, i];
                if (min > max) max = min;
            }

            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}