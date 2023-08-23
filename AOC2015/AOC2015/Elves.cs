namespace Tests;

public class Elves
{
    public int GetNecessaryPaperArea(int a, int b, int c)
    {
        var presentArea = 2 * a * b + 2 * b * c + 2 * a * c;
        var minimalSide = Math.Min(Math.Min(a*b, b*c), c*a);
        return presentArea + minimalSide;
    }

    public int GetNecessaryPaperArea(string presentList)
    {
        throw new NotImplementedException();
    }
}