namespace Algorithms.Strings;

public class Permutation
{
    public static List<string> VerifyPermutation(string word)
    {
        if (word.Length < 2)
        {
            // return new List<string>
            return
            [
                word,
            ];
        }

        // HashSet to store the permutations
        var result = new HashSet<string>();

        // Loop to scroll through all the characters in the string
        for (var i = 0; i < word.Length; i++)
        {
            // Removes a character according to the iteration position
            // and the store in temp variable
            var temp = VerifyPermutation(word.Remove(i, 1));

            // Combines the removed character at the beginning
            // of all permutations made
            result.UnionWith(temp.Select(subPerm => word[i] + subPerm));
        }

        // return result.ToList();
        return [.. result];
    }
}