// (C) ASML 2022 Submitted for Interview assignment

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using ASML.InterviewTest.ProblemStrategy;

namespace ASML.InterviewTest.SequenceAnalysis
{
    public class SequenceAnalysis : IStrategy
    {
        /// <summary>
        ///Sorts the capital lettered words in a sentence
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public object ExecuteAlgorithm(object data)
        {
            var statement = data as string;
            if (string.IsNullOrEmpty(statement)) return string.Empty;

            //Splits the string by using space as separator
            string[] words = statement.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var upperCaseWords = new List<string>();

            foreach (var word in words)
            {
                //ignore any special characters or numbers
                var enumerableLetters = word.Where(char.IsLetter).Select(c => c);
               
                //get the word which contains only letters
                var letterWord = new string(enumerableLetters.ToArray());

                //If all letters in a word are upperCase then add it to upperCaseWords list
                if (letterWord.All(char.IsUpper))
                {
                    upperCaseWords.Add(letterWord);
                }
            }

            //If no capital letter words are available then return empty
            if (upperCaseWords.Count == 0) return string.Empty;

            //Combine all upperCase letter words into a string
            var stringBuilder = new StringBuilder();
            foreach (var upperCaseWord in upperCaseWords)
            {
                stringBuilder.Append(upperCaseWord);
            }

            var upperCaseString = stringBuilder.ToString();

            //sort the string and return it
            var sortedUpperCaseString = string.Concat(upperCaseString.OrderBy(x => x));
            return sortedUpperCaseString;
        }

    }
}
