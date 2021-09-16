using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractice
{
    public class ReverseText
    {
        public string Reverse() 
        { 

            var input = "Great race";
            var builder = new StringBuilder();

            for (int i = input.Length - 1;  i >= 0; i--)
            {
                builder.Append(input[i]);

            }

            return builder.ToString();
        }
        public bool Palindrome(string input)
        {

           // var input = "racecar";
            var builder1 = new StringBuilder();
            var builder2 = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    builder1.Append(input[i]);
                }
            }
            Console.WriteLine(builder1.ToString());
            for (int j = input.Length - 1; j >= 0; j--)            
            {
                    if (input[j] != ' ')
                    {
                        builder2.Append(input[j]);
                    }
            }
           
            Console.WriteLine(builder2.ToString());
            return builder1.Equals(builder2);
        }
    }
}

