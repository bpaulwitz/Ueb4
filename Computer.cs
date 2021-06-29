using System;
using System.Threading;

public class Computer
{
    public string UserName
    {
        get;
        private set;
    }

    public Computer()
    {
        UserName = "Administrator";
    }

    public void switchUser(string user)
    {
        Console.WriteLine("Logging out...");
        Thread.Sleep(1000);
        Console.WriteLine("Logging in as " + user);
        UserName = user;
    }
}