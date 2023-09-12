public class Program
{
    static void Main(string[] args)
    {
        // Check if a string is a palindrome.
        string text1 = "racecar";
        string text2 = "hello";

        bool isPalindrome1 = Palindrome.IsPalindrome(text1);
        bool isPalindrome2 = Palindrome.IsPalindrome(text2);

        Console.WriteLine($"{text1} is a palindrome: {isPalindrome1}");
        Console.WriteLine($"{text2} is a palindrome: {isPalindrome2}");
    }
}