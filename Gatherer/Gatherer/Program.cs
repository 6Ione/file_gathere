using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Gatherer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gatherer Test";

            Console.Write("Gather Info? (Y/N): ");
            string start = Console.ReadLine();

            if (start == "y" || start == "Y")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                string pathTemp = @"c:\temp\";
                if (Directory.Exists(pathTemp))
                {
                    Console.WriteLine($"{pathTemp} Has been found! Listing Files...");
                    Thread.Sleep(500);
                    Console.WriteLine("\n");

                    string[] t = Directory.GetDirectories(pathTemp);
                    foreach (string listTemp in t)
                        Console.WriteLine(listTemp);

                    Console.WriteLine($"Finished Time: {DateTime.Now}");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("\n");
                }
                else
                {
                    Console.WriteLine($"Directory: '{pathTemp}' Was not found.");
                }

                string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (Directory.Exists(pathDesktop))
                {
                    Console.WriteLine($"{pathDesktop} Has been found! Listing Files...");
                    Thread.Sleep(500);
                    Console.WriteLine("\n");

                    string[] y = Directory.GetDirectories(pathDesktop);
                    foreach (string listDesktop in y)
                        Console.WriteLine(listDesktop);
                    foreach (var listDesktop2 in y)
                        Console.WriteLine(listDesktop2);

                    Console.WriteLine($"Finished Time: {DateTime.Now}");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("\n");
                }

                string pathProgramFiles = @"c:\Program Files\";
                if (Directory.Exists(pathProgramFiles))
                {
                    Console.WriteLine($"{pathProgramFiles} Has been found! Listing Files...");
                    Thread.Sleep(500);
                    Console.WriteLine("\n");

                    string[] y = Directory.GetDirectories(pathProgramFiles);
                    foreach (string listProgramFiles2 in y)
                        Console.WriteLine(listProgramFiles2);

                    Console.WriteLine($"Finished Time: {DateTime.Now}");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("\n");
                }

                string pathAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                if (Directory.Exists(pathAppData))
                {
                    Console.WriteLine($"{pathAppData} Has been found! Listing Files...");
                    Thread.Sleep(500);
                    Console.WriteLine("\n");

                    string[] y = Directory.GetDirectories(pathAppData);
                    foreach (string listAppData in y)
                        Console.WriteLine(listAppData);

                    Console.WriteLine($"Finished Time: {DateTime.Now}");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("\n");
                }

            }

            else if (start == "n" || start == "N")
            {
                Console.WriteLine("Cancelled.");
            }

            else
            {
                Console.WriteLine("Choose a valid option.");
            }
            Thread.Sleep(-1);
        }
    }
}
