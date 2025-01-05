namespace Ultimate_Text_Writer_To_Console
{
internal class Program
        {
            static void Main(string[] args)
            {
                ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()<>?||\\:;`~1234567890" + ' ';
                string text = Console.ReadLine();

                Random rand = new Random();
                Console.Clear();
                int i = 0;
                while (i < text.Length)
                {
                    for (int j = 0; j < chars.Length && i < text.Length; j++)
                    {
                        Thread.Sleep(5);
                        int Index = rand.Next(0, colors.Length);
                        Console.ForegroundColor = colors[Index];
                        if (text[i] == ' ')
                        {
                            Console.Write(text[i]);
                            i++;
                            continue;
                        }
                        Console.Write(chars[j]);
                        if (chars[j] == text[i])
                        {
                            i++;
                        }
                        else
                        {
                            Console.Write("\b");
                        }
                    }
                }
                Console.ReadKey();
            }
        }
}
