using System;

namespace EstudoSharp
{
    class Palindromo
    {
        public Palindromo()
        {
            string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};
            Console.WriteLine("É um Palindromo");
            foreach (string word in words){
                Console.WriteLine($"{word}: {IsPalindrome(word.Trim())}");
            }

            bool IsPalindrome(String word){
                if (word == reverseWord(word))
                {
                    return true;
                }
                return false;
            }

            String reverseWord(String word){

                String reverse = "";
                for (int i = word.Length -1; i >= 0; i--)
                {
                    reverse += word[i];
                }
                return reverse.Trim();
            }
        }
    }
}
