namespace Tests;

public class SantaTest
{
    //
    // An opening parenthesis, (, means he should go up one floor, and a closing parenthesis, ), means he should go down one floor.
    //
    //     The apartment building is very tall, and the basement is very deep; he will never find the top or bottom floors.
    [Test]
    [TestCase("(())", 0)]
    [TestCase("(((", 3)]
    [TestCase("(()(()(", 3)]
    [TestCase("))(((((", 3)]
    [TestCase("())", -1)]
    [TestCase("))(", -1)]
    [TestCase(")))", -3)]
    [TestCase(")())())", -3)]
    public void When_GivenFloorsSymbols_Should_Calculate(string symbols, int correctFloor)
    {
        var santa = new Santa();
        santa.Follow(symbols);
        Assert.AreEqual(santa.CurrentFloor, correctFloor);
    }

    [Test]
    [TestCase("()())", 5)]
    public void When_GivenFloorSymbols_Should_GetRememberFirstNegativeOneFloor(string symbols, int position)
    {
        var santa = new Santa();
        santa.GetToFirstNegativeFloor(symbols);
        Assert.AreEqual(santa.FirstNegativeOneFloorPosition, position);
    }
    
    // find the position of the first character
    // that causes him to enter the basement (floor -1).
    // The first character in the instructions has position 1, the second character has position 2, and so on.
    //
    //     For example:
    //
    // ) causes him to enter the basement at character position 1.
    // ()()) causes him to enter the basement at character position 5.
    // What is the position of the character that causes Santa to first enter the basement?
}