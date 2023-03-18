using System.Text.RegularExpressions;

namespace pz_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task();
            task.FirstText();
            task.SecondText();
        }

        class Task
        {
            public void FirstText()
            {
                FileStream file = new FileStream("text.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string text = reader.ReadToEnd();
                file.Close();
                string Pattern = @"([А-Я][а-я]+\s?[А-Я][а-я]+)\s[+7]";
                Regex regex = new Regex(Pattern);
                foreach (Match match in regex.Matches(text))
                {
                    Console.WriteLine(match.Value);
                }
            }

            public void SecondText()
            {
                FileStream file = new FileStream("text2.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string text = reader.ReadToEnd();
                file.Close();
                string Pattern = @"(\d+[.]\d+[.]\d+[.]\d+\s)";
                Console.WriteLine("IP-адреса:");
                Regex regex = new Regex(Pattern);
                foreach (Match match in regex.Matches(text))
                {
                    Console.WriteLine(match.Value);
                }
                Console.WriteLine("\nДаты:");
                string Date = @"(\d+[/]\w+[/]\d+)";
                Regex regex2 = new Regex(Date);
                foreach (Match match in regex2.Matches(text))
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}