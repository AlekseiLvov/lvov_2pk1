namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string concat = String.Concat(x, y, z);
            Console.WriteLine(concat);
        }
    }

}