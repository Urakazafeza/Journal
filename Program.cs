using System;
using System.IO;

namespace Journal
{
    class JournalClass
    {
        public static void Main(string[] args)
        {
            string input, journal = "";

            Console.WriteLine("do you want to start journaling, stop or exit?");
            Console.WriteLine("Type: 'start'");
            Console.WriteLine("Type: 'stop'");
            Console.WriteLine("Type: 'exit'");

            while (true)
            {
                while (true)
                {
                    input = Console.ReadLine();
                    if (input == "start")
                    {
                        Console.Write("You can start journaling!");
                        break;
                    }
                    else if (input == "exit")
                    {
                        return;
                    }
                }

                while (true)
                {
                    input = Console.ReadLine();
                    if (input == "stop")
                    {
                        break;
                    }
                    journal += input + "\n";
                }

                using (StreamWriter sw = new StreamWriter("./" + DateTime.UtcNow.Date.ToString("dd_MM_yyyy") + ".txt"))
                {
                    try
                    {
                        sw.WriteLine("Captain's log");
                        sw.WriteLine("Startingdate " + DateTime.UtcNow.Date.ToString("dd-MM-yyyy"));
                        sw.Write(journal);
                        sw.Write("Jean-Luc Picard");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Journal failed", e.Message);
                    }
                }
            }
        }
    }
}
