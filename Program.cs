using System;

namespace Ueb4
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer com = new Computer();
            Console.WriteLine(com.UserName);
            com.switchUser("Baldur");
            Console.WriteLine(com.UserName);
        }
    }
}
