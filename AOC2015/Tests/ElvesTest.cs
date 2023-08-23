namespace Tests;

public class ElvesTest
{
// 2*l*w + 2*w*h + 2*h*l.
// The elves also need a little extra paper for each present:
// the area of the smallest side.
//
// A present with dimensions 2x3x4 requires 2*6 + 2*12 + 2*8 = 52 square feet of wrapping paper plus 6 square feet of slack, for a total of 58 square feet.
// A present with dimensions 1x1x10 requires 2*1 + 2*10 + 2*10 = 42 square feet of wrapping paper plus 1 square foot of slack, for a total of 43 square feet.

    [Test]
    [TestCase(2, 3, 4, 58)]
    [TestCase(1, 1, 10, 43)]
    public void When_GivenPresentDimensions_Should_CalculatePaperArea(int a, int b, int c, int paperSquare)
    {
        var elves = new Elves();
        var result = elves.GetNecessaryPaperArea(a, b, c);
        Assert.AreEqual(result, paperSquare);
    }

    [Test]
    [TestCase("2x3x4", 58)]
    public void When_GivenPresentList_Should_CalculatePaperArea(string presentList, int paperSquare)
    {
        var elves = new Elves();
        var result = elves.GetNecessaryPaperArea(presentList);
        Assert.AreEqual(result, paperSquare);
    }
}