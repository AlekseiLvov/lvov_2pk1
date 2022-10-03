namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[8];
            int[] massiv = Enumerable.Range(-10, 10).ToArray();
            Random r = new Random();
            for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = r.Next(5);
                Console.WriteLine(myArray[x]);
            }
        }
    }
}