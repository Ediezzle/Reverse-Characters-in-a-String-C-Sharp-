using System;
using System.Collections;

namespace ReverseCharactersInString
{
        class Program
        {
            public static void ReverseCharsInMyString(String str)
            {
                /* The split() method of String class splits
                 * a string in several strings based on the
                 * delimiter passed as an argument to it
                 */
                string[] words = str.Split(" ");

            ArrayList al = new ArrayList();
            for (int i = words.Length-1; i >=0; i--)
                al.Add(words[i]);
            foreach(string s in al)
                Console.Write(s + " ");
            /*
            Array.Reverse(w);
                //return words;
                string arrayString = "";
                for (int i = 0; i < chars.Length; i++)
                    arrayString += chars[i] + " ";
                return arrayString + "."; */
            }
            static void Main(string[] args)
            {
                string st = "I am happy";
                ReverseCharsInMyString(st);
                //Console.Write(str);

                   

            }
        }

}
