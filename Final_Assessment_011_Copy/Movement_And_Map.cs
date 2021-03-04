using System;
using System.IO;
namespace Final_Assessment_011_Copy
{
    public class Environment
    {
        public  void Map()
        {
            string level = "MAP.txt";
            using (StreamReader reader = File.OpenText(level))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
    public class Movement
    {
        private const int lenght = 100;
        private const int width = 100;
        char[,] map_Array = new char[lenght, width];

        public void Map_Generation(int i, int j)
        {
            
        }

    }
}