using System;
using System.Threading;
using System.IO;

public class Computer
{
    public string UserName
    {
        get;
        private set;
    }
    public bool failedSaving
    {
        get;
        private set;
    }
    Random rng;

    public Computer()
    {
        UserName = "Administrator";
        rng = new Random();
        failedSaving = false;
    }

    public void switchUser(string user)
    {
        Console.WriteLine("Logging out...");
        Thread.Sleep(1000);
        Console.WriteLine("Logging in as " + user);
        UserName = user;
    }

    public void saveFile(string path, string name)
    {
        string fullFilePath = Path.Combine(path, name);
        Console.WriteLine("Saving file " + fullFilePath);

        if(failedSaving || rng.NextDouble() <= 0.25)
        {
            failedSaving = true;
            throw new InvalidOperationException("Failed to save file");
        }
    }

    public void saveFile(string name)
    {
        this.saveFile("C:\\Benutzer\\" + UserName + "\\Desktop", name);
    }

    public void reboot()
    {
        Console.WriteLine("Rebooting...");
        Thread.Sleep(1000);
        Console.WriteLine("Logging in as " + UserName);
        failedSaving = false;
    }
}