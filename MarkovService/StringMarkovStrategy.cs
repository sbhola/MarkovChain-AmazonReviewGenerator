using MarkovSharp;
using MarkovSharp.TokenisationStrategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarkovService
{
    // This model will use a phrase type of string, and also token type of string.
    public class StringMarkov : GenericMarkov<string, string>, IMarkovStrategy<string, string>
    {
        public StringMarkov(int level = 2)
            : base(level)
        { }

        // Define how to split a phrase to collection of tokens
        public override IEnumerable<string> SplitTokens(string input)
        {
            if (input == null)
            {
                return new List<string>() { GetPrepadUnigram() };
            }

            return input?.Split(' ');
        }

        // Define how to join the generated tokens back to a phrase
        public override string RebuildPhrase(IEnumerable<string> tokens)
        {
            return string.Join(" ", tokens);
        }


        //public override string GetTerminatorGram()
        //{
        //    return null;
        //}


        //public override string GetPrepadGram()
        //{
        //    return "";
        //}

        // Define the value to signify the end of a phrase in the model
        public override string GetTerminatorUnigram()
        {
            return null;
        }

        // Define a default padding value to use when no value is available
        public override string GetPrepadUnigram()
        {
            return "";
        }
    }
}
