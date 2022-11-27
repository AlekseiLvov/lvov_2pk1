namespace pz_13
{
    internal class Program
    {
        static int met(float[] array, int n)
        {
            return array.Where(x => x > n).ToArray().Length;
        }
        static void Main(string[] args)
        {
            float[] arr = { 1.2f, 123, 324, 23, 1 };
            Console.WriteLine(met(arr, 5));
        }
    }
}