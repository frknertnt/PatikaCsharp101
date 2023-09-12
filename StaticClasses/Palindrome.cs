using System;
public static class Palindrome
{
    public static bool IsPalindrome(string text)
    {
        
        text = text.Replace(" ", "").ToLower(); //Remove spaces and convert to lowercase for case-insensitive comparison.

        
        string reversedText = ReverseString(text); //Compare the original string with its reverse.

        return text.Equals(reversedText);
    }
  
    private static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}