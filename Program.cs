using System;

namespace Ueb4
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer com = new Computer();
            com.switchUser("Baldur");

            //2)
            /*
            int i = 0;
            do
            {
                try
                {
                    mainComputer.saveFile($"file{i++}.txt");
                }
                catch (System.InvalidOperationException)
                {
                    mainComputer.reboot();
                }
            }
            while(true);
            */

            //3)
            /*
            byte[] test1 = {192, 168, 0, 1};
            byte[] test2 = {192, 168, 0, 1, 192, 168, 0, 1, 192, 168, 0, 1, 192, 168, 0, 1};
            byte[] test3 = IPTools.Localhost;
            byte[] test4 = {0};
            Console.WriteLine("Test byte[] to string");
            Console.WriteLine(IPTools.IPToString(test1));
            Console.WriteLine(IPTools.IPToString(test2));
            Console.WriteLine(IPTools.IPToString(test3));
            Console.WriteLine(IPTools.IPToString(test4));
            byte[] test5 = IPTools.IPToByte("127.0.0.0");
            byte[] test6 = IPTools.IPToByte("ffee:ddcc:bbaa:9988:7766:5544:3322:1100");
            Console.WriteLine("Test string to byte[]");
            Console.WriteLine(IPTools.IPToString(test5));
            Console.WriteLine(IPTools.IPToString(test6));
            */

            //4)
            /*
            Blu_Ray disk1, disk2;
            com.burn("Absatz von Smartphones", 
                "173.5, 304.7, 494.5, 725.3, 1019.4, 1301.7, 1437.6, 1469, 1465.5, 1402.6, 1372.6, 1280",
                out disk1);
            com.burn("Impfbereitschaft", "7, 6, 11, 75", out disk2);

            //disk1
            Console.WriteLine("Disk 1:");
            Console.WriteLine($"ID: {disk1.id}");
            Console.WriteLine($"Label: {disk1.label}");
            Console.WriteLine($"Content: {disk1.content}");

            //disk2
            Console.WriteLine("Disk 2:");
            Console.WriteLine($"ID: {disk2.id}");
            Console.WriteLine($"Label: {disk2.label}");
            Console.WriteLine($"Content: {disk2.content}");
            */

            //5)
            com.switchUser("Gast");
            com.ipAddress = "ffee:ddcc:bbaa:9988:7766:5544:3322:1100";

            com.print();
        }
    }
}
