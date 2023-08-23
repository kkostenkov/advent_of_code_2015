using AOC2015;

namespace Tests;

public class Tests
{
    //
    // An opening parenthesis, (, means he should go up one floor, and a closing parenthesis, ), means he should go down one floor.
    //
    //     The apartment building is very tall, and the basement is very deep; he will never find the top or bottom floors.
    //
    
    // (()) and ()() both result in floor 0.
    [Test]
    public void Test1()
    {
        var a = new Class1();
        Assert.Pass();
    }
    
    // ((( and (()(()( both result in floor 3.
    // ))((((( also results in floor 3.
    // ()) and ))( both result in floor -1 (the first basement level).
    // ))) and )())()) both result in floor -3.
}