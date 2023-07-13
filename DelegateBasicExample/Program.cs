﻿namespace DelegateBasicExample
{
    class Program
    {
        delegate void LogDel(string text);
        static void Main(string[] args)
        {
            LogDel logDel = new LogDel(LogTextToFile);
            Console.WriteLine("Please enter you name");
            var name = Console.ReadLine();
            if (name != null && name != "")
            {
                logDel(name);
            }
            else
            {
                Console.WriteLine("The name was empty!");
            }
        }

        static void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

        static void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }
    }
}