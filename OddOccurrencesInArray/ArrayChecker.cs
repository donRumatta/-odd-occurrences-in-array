namespace OddOccurrencesInArray;

public static class ArrayChecker
{
    public static int FindOddOccurrence(int[] input)
    {
        Dictionary<int, bool> storage = new();

        foreach (var elem in input)
        {
            if (!storage.TryAdd(elem, true))
            {
                storage[elem] = !storage[elem];
            }
        }

        return storage.Single(x => x.Value).Key;
    }
}