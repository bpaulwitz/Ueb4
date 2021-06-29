using System;

namespace Ueb4
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer com = new Computer();
            com.switchUser("Baldur");

            int i = 0;
            do
            {
                try
                {
                    com.saveFile($"File{i++}.txt");
                }
                catch (System.InvalidOperationException)
                {
                    com.reboot();
                }
            } while (true);
        }
    }
}
