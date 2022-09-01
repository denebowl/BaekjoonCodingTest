using System.Collections.Generic;
using System.IO;

class Program_11654
{
    static void Main(string[] args)
    {
        char input;
        using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
        {
            input = sr.ReadLine()[0];
        }

        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
        {
            sw.WriteLine(((byte)input).ToString());
        }
    }
}