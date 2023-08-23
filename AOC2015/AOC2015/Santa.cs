
public class Santa
{
    public int CurrentFloor { get; private set; }
    public int FirstNegativeOneFloorPosition { get; private set; } = Int32.MaxValue;

    public void Follow(string symbols)
    {
        var openedBracketsCount = symbols.Count(x => x.Equals('('));
        var closedBracketsCount = symbols.Count(x => x.Equals(')'));
        CurrentFloor = openedBracketsCount - closedBracketsCount;   
    }

    public void GetToFirstNegativeFloor(string symbols)
    {
        var currentPosition = 0;
        var currentFloor = 0;
        var hasBeenOnNegativeFloor = false; 
        foreach (var symbol in symbols) {
            if (hasBeenOnNegativeFloor)
            {
                break;
            }

            switch (symbol)
            {
                case '(':
                    currentFloor++;
                    break;
                case ')':
                    currentFloor--;
                    break;
            }

            currentPosition++;
            if (currentFloor == -1)
            {
                hasBeenOnNegativeFloor = true;
                FirstNegativeOneFloorPosition = currentPosition;
            }
        }
    }
}