using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Text;

namespace CH3Studio
{
    class Scorecard
    {
        

        public static void Scorer (char[] arr)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                char letter = Char.ToLower(arr[i]);
                if (Char.IsLetter(letter))
                {
                    if (characterCount.ContainsKey(letter))
                    {
                        characterCount[letter]++;
                    }
                    else
                    {
                        characterCount.Add(letter, 1);
                    }
                }
               
            }

            foreach (KeyValuePair<char, int> score in characterCount)
            {
                Console.WriteLine(score.Key + ": " + score.Value);
            }
        }
    }
}
