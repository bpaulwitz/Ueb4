using System;

namespace Ueb4
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer com = new Computer();
            com.switchUser("Baldur");

            byte[] test1 = {192, 168, 0, 1};
            byte[] test2 = {192, 168, 0, 1, 192, 168, 0, 1, 192, 168, 0, 1, 192, 168, 0, 1};
            byte[] test3 = IPTools.Localhost;
            byte[] test4 = {0};
            Console.WriteLine(IPTools.IPToString(test1));
            Console.WriteLine(IPTools.IPToString(test2));
            Console.WriteLine(IPTools.IPToString(test3));
            Console.WriteLine(IPTools.IPToString(test4));
        }
    }
}
