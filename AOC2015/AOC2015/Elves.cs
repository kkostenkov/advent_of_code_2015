namespace Tests;

public class Elves
{
    public int GetPresentPaperArea(int a, int b, int c)
    {
        var presentArea = 2 * a * b + 2 * b * c + 2 * a * c;
        var minimalSide = Math.Min(Math.Min(a*b, b*c), c*a);
        return presentArea + minimalSide;
    }

    public int GetPresentPaperArea(string presentDimensions)
    {
        var dimensions = presentDimensions.Split('x');
        var a = int.Parse(dimensions[0]);
        var b = int.Parse(dimensions[1]);
        var c = int.Parse(dimensions[2]);
        return GetPresentPaperArea(a, b, c);
    }

    public int GetNecessaryPaperArea(string presentList)
    {
        var presents = presentList.Split('\n');
        int sum = 0;
        foreach (var present in presents) {
            sum += GetPresentPaperArea(present);
        }
        return sum;
    }
}