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
    [TestCase("../../../Inputs/Task3Input.txt")]
    public void PrintResult_3(string path)
    {
        var fileStream = File.Open(path, FileMode.Open);
        var text = new StreamReader(fileStream).ReadToEnd();
        var elves = new Elves();
        var result = elves.GetNecessaryPaperArea(text);
        Console.WriteLine(result);
    }
}