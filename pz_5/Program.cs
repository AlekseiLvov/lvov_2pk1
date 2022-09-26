namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задание №1:");           // задание №1
            for (int i = -25; i <= 25; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("задание №2:");           // задание №2
            char b = 'P';
            char sym = '#';
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(b);
                b++;
            }
            Console.WriteLine("задание №3:");           // задание №3
            for (var i = 0; i < 7; i++)
            {
                for(var j = 0; j < 4; j++)
                {
                    Console.WriteLine('#');
                }
                Console.WriteLine();
            }

        }
    }
    
}