using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @":\моя папка\";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                    Console.WriteLine(s);
                Console.WriteLine();
                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                    Console.WriteLine(s);
                Console.ReadKey();
            }
        }
    }
}
