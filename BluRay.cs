public class Blu_Ray
{
    private static int bluRayCounter = 0;
    public int id
    {
        get;
        private set;
    }

    public string label
    {
        get;
        private set;
    }

    public string content
    {
        get;
        private set;
    }

    public Blu_Ray(string beschriftung, string inhalt)
    {
        label = beschriftung;
        content = inhalt;
        id = bluRayCounter++;
    }
}