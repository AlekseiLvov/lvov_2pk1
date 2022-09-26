using System.ComponentModel.DataAnnotations;

namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X \t Y");
            double y;
            for (double x = -2.0; x <= 0.5; x += 0.5)
            {
                y = -2.4 * x * x + 5 * x - 3;
                Console.WriteLine(string.Format("{0} \t {1}", x, y));
            }
        }
    }
}