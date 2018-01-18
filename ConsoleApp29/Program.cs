using System;



public class RecExercise8
{

    public static bool IsPalindrome(string text)

    {
        if (text.Length <= 1)
            return true;
        else
        {
            if (text[0] != text[text.Length - 1])
                return false;
            else
                return IsPalindrome(text.Substring(1, text.Length - 2));
        }
    }
    public static void Main()
    {       
        string word;
        bool tf;

        Console.Write(" Enter any word : ");
        word = Console.ReadLine();
        tf = IsPalindrome(word);
        if (tf == true)
        {
            Console.WriteLine(" The string is a Palindrome.");
        }
        else
        {
            Console.WriteLine(" The string is not a Palindrome.");
        }
    }
}
