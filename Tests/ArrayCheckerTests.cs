using OddOccurrencesInArray;

namespace Tests;

public class Tests
{
    [Test]
    public void ArrayChecker_1()
    {
        var result = ArrayChecker.FindOddOccurrence([9, 3, 9, 3, 9, 7, 9]);
        
        Assert.AreEqual(7, result);
    }
}