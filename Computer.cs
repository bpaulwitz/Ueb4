using System;
using System.Threading;
using System.IO;

public class Computer
{
    private byte[] ipAddressArray;
    public string ipAddress
    {
        get
        {
            return IPTools.IPToString(ipAddressArray);
        }
        set
        {
            ipAddressArray = IPTools.IPToByte(value);
        }
    }
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
    //random number generator für die zufälligen Abstürze
    Random rng;

    public Computer()
    {
        UserName = "Administrator";
        rng = new Random();
        failedSaving = false;
        ipAddressArray = IPTools.Localhost;
    }

    public void switchUser(string user)
    {
        Console.WriteLine("Logging out...");
        //1 sek warten
        Thread.Sleep(1000);
        Console.WriteLine("Logging in as " + user);
        UserName = user;
    }

    public void saveFile(string path, string fileName)
    {
        Console.WriteLine("Saving file: " + Path.Combine(path, fileName));

        //Wenn im Fehlerzustand oder Zufallszahl (im Bereich [0,1]) unter 0.25 ist
        if(failedSaving || rng.NextDouble() <= 0.25)
        {
            //Fehlerzustand erreichen und InvalidOperationException werfen
            failedSaving = true;
            throw new InvalidOperationException("Failed to save file " + fileName);
        }
    }

    public void saveFile(string fileName)
    {
        //Überladene Methode mit dem Desktop Verzeichnis aufrufen
        string desktop = Path.Combine("C:", "Benutzer", UserName, "Desktop");
        this.saveFile(desktop, fileName);
    }

    public void reboot()
    {
        Console.WriteLine("Rebooting...");
        //1 sek warten
        Thread.Sleep(1000);
        Console.WriteLine("Logging in as " + UserName);
        //Fehlerzustand zurücksetzen
        failedSaving = false;
    }

    public void burn(string beschriftung, string inhalt, out Blu_Ray output)
    {
        output = new Blu_Ray(beschriftung, inhalt);
    }

    public void print()
    {
        Console.WriteLine(
            $"User: {UserName}\nIP: {ipAddress}\nSchreibabsturz: {failedSaving}"
        );
    }
    
}