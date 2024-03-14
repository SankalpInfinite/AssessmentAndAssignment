using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class FileHandle
    {
        static void Main()
        {
            string fileName = "mytext.txt";
            string textToAppend = Console.ReadLine();

            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine(textToAppend);
                }

                Console.WriteLine("Text appended to the file successfully.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
