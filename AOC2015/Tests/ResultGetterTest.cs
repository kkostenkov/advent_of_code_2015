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
}