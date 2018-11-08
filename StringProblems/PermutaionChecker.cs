using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    class PermutaionChecker
    {
        public bool CheckIfOneStringIsPermutation(string strA, string strB)
        {

            // If the lenght of the strings are not equal, then the strings are not permutations anyway.
            if (strA.Length != strB.Length)
            {
                return false;
            }

            Dictionary<char, int> CharacterCount = new Dictionary<char, int>();

            // The idea is to consider the counts of distinct characters in both the strings, and if they are equal, then
            // one string is a permutation of the other.

            // Use a dictionary, with character as key, and value as integer. 
            // Increment the value if the character is encountered. 
            // If the character is not present in the dictionary, then initialize the character to 1.
            for(int i=0; i<strA.Length; i++)
            {
                char ch = strA[i];

                if (CharacterCount.ContainsKey(ch))
                {
                    CharacterCount[ch]++;
                }
                else
                {
                    CharacterCount[ch] = 1;
                }
            }

            // SImilarly, decrement the dictionary counts on every character encounter. 
            // The idea is to check if the counts of all the characters are equal to 0, which happens only if teh
            // two strings are having the same characters.
            for (int i = 0; i < strB.Length; i++)
            {
                char ch = strB[i];

                if (CharacterCount.ContainsKey(ch))
                {
                    CharacterCount[ch]--;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 0; i < strA.Length; i++)
            {
                if (CharacterCount[strA[i]] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
