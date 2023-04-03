using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type any text");
            isPalindrome(Console.ReadLine());
        }
        static void isPalindrome(string text)
        {
            int n = 0;
            for (int index = 0, backIndex = text.Length - 1; index < text.Length; index++, backIndex--)
            {
                if (text[index] == text[backIndex]) n++;
            }
            if (n == text.Length) Console.WriteLine("This text is a palindrome");
            else Console.WriteLine("This text is not a palindrome");
        }
    }
}
