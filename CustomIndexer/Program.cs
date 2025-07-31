
using System;

namespace CustomIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var namesList = new NameList();
            Console.WriteLine(namesList[0]);

            Console.WriteLine(namesList[1]);
            namesList[2] = "Thomas";
            Console.WriteLine(namesList[2]);

            namesList[0] = "James";
            Console.Write(namesList[0]);
        }
    }
}
