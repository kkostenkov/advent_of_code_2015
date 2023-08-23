namespace Tests;

public class ResultGetterTest
{
    [Test]
    [TestCase("")]
    public void PrintResult_1(string symbols)
    {
        var santa = new Santa();
        santa.Follow(symbols);
        Console.WriteLine(santa.CurrentFloor);
    }
    
    [Test]
    [TestCase("")]
    public void PrintResult_2(string symbols)
    {
        var santa = new Santa();
        santa.GetToFirstNegativeFloor(symbols);
        Console.WriteLine(santa.FirstNegativeOneFloorPosition);
    }
    
    [Test]
    [TestCase("")]
    public void PrintResult_3(string symbols)
    {
        var santa = new Santa();
        santa.GetToFirstNegativeFloor(symbols);
        Console.WriteLine(santa.FirstNegativeOneFloorPosition);
    }
    
    [Test]
    [TestCase("")]
    public void PrintResult_4(string symbols)
    {
        var elves = new Elves();
        var area = elves.GetNecessaryPaperArea(symbols);
        Console.WriteLine(area);
    }
}