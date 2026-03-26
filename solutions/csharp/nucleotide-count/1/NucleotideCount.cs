public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> result = new Dictionary<char, int> { {'A', 0}, {'C', 0}, {'G', 0}, {'T', 0} };
        
        if(sequence.Any(t => !result.ContainsKey(t)))
            throw new ArgumentException();
        
        foreach(char target in result.Keys)
        {
            result[target] = sequence.Count(t => t == target);
        }
        return result;
    }
}