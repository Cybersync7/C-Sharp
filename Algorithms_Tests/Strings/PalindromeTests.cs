using Algorithms.Strings;

namespace Algorithms_Tests.Strings;

public class PalindromeTests
{
    [TestCase("Civic")]
    [TestCase("A Santa at Nasa")]
    public static void TextIsPalindrome_TrueExpected(string text)
    {
        // Arrange
        // Act
        var isPalindrome = Palindrome.IsPalindrome(text);

        // Assert
        Assert.That(isPalindrome, Is.True);
    }

    [TestCase("Hallo Welt")]
    [TestCase("Palindrome")]
    public static void TextIsNotPalindrome_FalseExpected(string text)
    {
        // Arrange
        // Act
        var isPalindrome = Palindrome.IsPalindrome(text);

        // Assert
        Assert.That(isPalindrome, Is.False);
    }
}
