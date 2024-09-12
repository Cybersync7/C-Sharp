using System.Text.RegularExpressions;

namespace Algorithms.Strings;

/// <summary>
///      Palindrome a series of characters or a string
///      that when reversed, equals the original string.
/// </summary>
public class Palindrome
{
    /// Function to check if a string is a palindrome.
    public static bool IsPalindrome(string word) =>
        TypifyString(word).Equals(TypifyString(ReverseString(word)));

    /// Typify string to lower and remove white space.
    /// Returns original string without spaces.
    private static string TypifyString(string word) =>
        Regex.Replace(word.ToLowerInvariant(), @"\s+", string.Empty);

    /// Helper function that returns a reversed string inputed.
    private static string ReverseString(string s)
    {
        var arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}