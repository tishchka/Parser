using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parser
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите путь к файлу: ");
                string path = Console.ReadLine();
                if (IsValidFile(path))
                {
                    Analysis analysis = new Analysis(path);
                    analysis.Analyze();

                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Введите корректный путь к файлу.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }


        private static bool IsValidFile(string path) => string.IsNullOrWhiteSpace(path) is false &&
            path.EndsWith(".txt") && File.Exists(path);
    }
}
