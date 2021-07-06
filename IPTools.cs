using System;

public static class IPTools
{
    public static readonly byte[] Localhost = {127, 0, 0, 0};

    public static string IPToString(byte[] addr)
    {
        //IPv4
        if(addr.Length == 4)
            //vier Bytes als int darstellen und durch '.' voneinander trennen
            return $"{addr[0]}.{addr[1]}.{addr[2]}.{addr[3]}";
        //IPv6
        else if(addr.Length == 16)
        {
            //addrString ist der fertige String, der mit den ersten beiden Bytes initialisiert ist,
            //die jeweils zu einem Hex-String mit zwei Zeichen ("x2") konvertiert werden
            string addrString = addr[0].ToString("x2") + addr[1].ToString("x2");
            //Position im Byte-Array
            int addrIndex = 2;
            //Iteration über die 8 Blöcke mit jeweils zwei Bytes
            for(int i = 1; i < 8; i++)
            {
                //an den addrString zwei mal das Byte an der aktuellen Position hinzufügen, 
                //was zu einem Hex-String mit zwei Ziffern ("x2") konvertiert wurde
                addrString += ":" + addr[addrIndex].ToString("x2") + addr[addrIndex + 1].ToString("x2");
                //Zwei Bytes pro Block -> Position im Byte-Array um 2 erhöhen
                addrIndex += 2;
            }
            //addrString zurückgeben
            return addrString;
        }
        //weder IPv4 noch IPv6 -> null zurück geben
        return null;
    }

    public static byte[] IPToByte(string addr)
    {
        //IPv4
        if(addr.Contains('.'))
        {
            //alle einzelnen Teile/ Bytes der Adresse in einem Array bekommen
            string[] parts = addr.Split('.');
            //ausreichend großes Byte-Array anlegen
            byte[] result = new byte[4];
            //Über jedes Teil/ Byte iterieren
            for(int i = 0; i < 4; i++)
            {
                //Versuchen, den string zu einem int und dann zu einem Byte zu konvertieren und dann in
                //das Byte-Array an die richtige Position schreiben. Sonst abbrechen und Null zurück geben.
                try
                {
                    result[i] = byte.Parse(parts[i]);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Failed to parse IP Address");
                    return null;
                }
            }
            //fertiges Byte-Array zurück geben
            return result;
        }
        //IPv6
        else if(addr.Contains(':'))
        {
            byte[] result = new byte[16];

            int resultCounter = 0;

            for(int i = 0; i < addr.Length; i+=2)
            {

                /*
                addr[i] -> i

                f -> 0
                f -> 0 + 1
                e -> 2
                e -> 2 + 1
                : -> 4 -> 3
                => 3 + 2 = 5
                d -> 5 + 1

                */
                if(addr[i] == ':')
                {
                    i--;
                    continue;
                }
                
                string currentByte = $"{addr[i]}{addr[i+1]}";

                try
                {
                    result[resultCounter] = Convert.ToByte(currentByte, 16);
                    resultCounter++;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Failed to parse IP Address");
                    return null;
                }
            }
            return result;
        }
        //Weder IPv4 noch IPv6 -> Null zurück geben
        return null;
    }
}