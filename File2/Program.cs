using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs2/log.txt";

            // Создание папки
            //DirectoryInfo directory = new DirectoryInfo(path);
            //if (!directory.Exists)
            //{
            //    directory.Create();
            //}

            // Создание *.txt
            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //}
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Старт программы");
                sw.WriteLine("Ошибка");
            }
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
