using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstone
{
    public class Problem
    {
        public static string ReverseSentence(string input)
        {
            if (input == null || input.Length == 0)
                return "";

            string[] splitInput = input.Split(' ');
            string output = "";

            for (int i = splitInput.Length -1 ; i >= 0; i--)
            {
                string word = splitInput[i];
                if(word.Length >= 1 && word.Length <= 25)
                    output += word + ' ';
            }

            return output.Trim();
        }
    }
}
