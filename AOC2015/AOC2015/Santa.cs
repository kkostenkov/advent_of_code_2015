﻿
public class Santa
{
    public int CurrentFloor { get; private set; }

    public void Follow(string symbols)
    {
        var openedBracketsCount = symbols.Count(x => x.Equals('('));
        var closedBracketsCount = symbols.Count(x => x.Equals(')'));
        CurrentFloor = openedBracketsCount - closedBracketsCount;   
    }
}