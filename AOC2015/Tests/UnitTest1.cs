using AOC2015;

namespace Tests;

public class Tests
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
}