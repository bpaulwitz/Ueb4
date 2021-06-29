using System;

public static class IPTools
{
    public static readonly byte[] Localhost = {127, 0, 0, 0};

    public static string IPToString(byte[] addr)
    {
        //IPv4
        if(addr.Length == 4)
        {
            return $"{addr[0]}.{addr[1]}.{addr[2]}.{addr[3]}";
        }
        //IPv6
        else if(addr.Length == 16)
        {
            int counter = 0;
            string addrString = addr[counter].ToString("x2") + addr[counter + 1].ToString("x2");
            counter += 2;

            for (int i = 1; i < 8; i++)
            {
                addrString += ":" + addr[counter].ToString("x2") + addr[counter + 1].ToString("x2");
                counter += 2;
            }
            return addrString;
        }
        else
        {
            return "";
        }
    }

    public static byte[] IPToByte(string addr)
    {
        //IPv4
        if(addr.Contains('.'))
        {
            string[] parts = addr.Split('.');
            byte[] result = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                try
                {
                    result[i] = byte.Parse(parts[i]);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Failed to parse IPv4 address " + addr);
                    return null;
                }
            }
            return result;
        }
        //IPv6
        else if(addr.Contains(':'))
        {

        }
        //sonst
        else
        {
            return null;
        }
    }
}