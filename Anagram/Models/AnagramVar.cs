using System.Collections.Generic;
using System.Linq;
using System;
using Anagram;

namespace Anagram.Models
{
    public class AnagramModel
    {
        public bool CheckAnagram(string userInput, string anagramOfUserInput)
        {
            string tempUserInput = anagramOfUserInput;
            Console.WriteLine(tempUserInput);
            foreach(var letter in userInput)
            {
                int index = tempUserInput.IndexOf(letter);
                //IndexOf returns -1 which broke my program forever, till I figured it out.
                Console.WriteLine(index); 
                if (index >= 0)
                {
                tempUserInput = tempUserInput.Remove(index, 1);
                }
                Console.WriteLine(tempUserInput);
                if (tempUserInput.Count() == 0)
                {
                    return true;
                }
            }
            if (tempUserInput.Count() == 0)
            {
                return true;
            }
            else
            {
            return false;
            }
        }
    }
}
