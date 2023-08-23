
public class Santa
{
    public int CurrentFloor { get; private set; }
    public int FirstNegativeOneFloorPosition { get; private set; }

    public void Follow(string symbols)
    {
        var openedBracketsCount = symbols.Count(x => x.Equals('('));
        var closedBracketsCount = symbols.Count(x => x.Equals(')'));
        CurrentFloor = openedBracketsCount - closedBracketsCount;   
    }

    public void GetToFirstNegativeFloor(string symbols)
    {
        var currentPosition = 1;
        var currentFloor = 0;
        foreach (var symbol in symbols) {
            var moveDirection = 0;
        }
    }
}