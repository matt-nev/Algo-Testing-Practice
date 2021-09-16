using System;

namespace AlgoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var doubleChecker = new DoubleChecker();
            var test = new ReverseText();
            /*
                        int[] input = { 3, 1, 7, 11 };

                        bool result = doubleChecker.IsDouble(input);

                        Console.WriteLine(result);*/

            test.Palindrome("a man a plan a canal panama");

        }
    }
}






/*Constraints:

1 <= input.length <= 100
s consists of characters with ASCII values in the range [33, 122].
s does not contain '"' or '\'*/