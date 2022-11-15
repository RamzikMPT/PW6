using System.Reflection.Metadata;

namespace pw6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1.Init();
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (true)
            {
                Console.WriteLine("нажмите F1 для записи, F2 для открытия");
                ConsoleKey consoleKey = Console.ReadKey().Key;
                switch (consoleKey)
                {
                    case ConsoleKey.F1:
                        Console.WriteLine("В какой фомат сохранить? 1 txt. 2 json. 3 xml. Esc для выхода");
                        ConsoleKey consoleKey1 = Console.ReadKey().Key;
                            switch (consoleKey1)
                            {
                            case ConsoleKey.D1:
                                convert.InTXT(convert.class1s);
                                Console.WriteLine("Готово в TXT");
                                break;
                            case ConsoleKey.D2:
                                convert.InJson();
                                Console.WriteLine("Готово в JSON");
                                break;
                            case ConsoleKey.D3:
                                convert.InXML();
                                Console.WriteLine("Готово в XML");

                                break;
                            case ConsoleKey.Escape:
                                Environment.Exit(0);
                                break;
                        }
                        break;
                    case ConsoleKey.F2:
                        var path = Console.ReadLine();
                        if (File.Exists(path))
                        {
                            if (path.Contains(".txt"))
                            {
                                convert.FromTXT();
                            }
                            else if (path.Contains(".json"))
                            {
                                convert.FromXML();
                            }
                            else
                            {
                                convert.FromJson();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Файл не существоет, малёк абамка, переродись первак");
                        }
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;

                }
            }
        }
    }
}