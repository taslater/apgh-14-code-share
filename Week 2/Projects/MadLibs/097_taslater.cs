// Regex 4 LYFE

using System;
using System.Text.RegularExpressions;

namespace MadlibRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            // MadLib template string
            string madlibTemplate = "[Author] wrote my favorite book [book] and sometimes I [verb] the pages [adverb].";

            // tell the user what we're doing
            Console.WriteLine("Let's do a madlib! What could possibly go wrong?!\n");

            // === REGEX EXPLAINED: ===
            //        @"\[.*?\]"
            // @ before string creates a verbatim string
            // verbatim strings let us write strings without extra escapes (backslashes)
            //
            // --- 3 Pieces of the Regex ---
            //           \[.*?\]
            //
            //              \[
            // A literal character that matches an open bracket "[",
            // escaped by backslash.
            // Some special characters need to be escaped because otherwise
            // they have special meaning in Regex
            //
            //             .*?
            // These three characters work together.
            // The dot (.) matches any one character at all.
            // The star (*) quantifies 0 or more repetitions of the dot (.)
            // That is, match 0 or more of any character.
            // The question mark (?) is greedy. It stops matching early.
            // Without the question mark, regex would just keep matching until
            // it found the very last close bracket (]).
            //
            // -- Putting these pieces together --
            //
            //              \]
            // A literal character that matches an open bracket "]",
            // escaped by backslash.

            // iterate through the matches
            foreach (Match m in Regex.Matches(madlibTemplate, @"\[.*?\]"))
            // Regex.Matches returns MatchCollection object that we iterate over
            {
                // get the string that was matched
                // Match objects have property "Value" (m.Value)
                // that stores the part of the string that matches
                // ie. "[Author]"
                string matchValue = m.Value;
                // chop off the brackets at beginning and end
                // ie. "Author"
                string matchPhrase = matchValue[1..^1];
                // ask for input
                Console.WriteLine($"Please enter a {matchPhrase}:");
                // store input to replace the stuff in brackets
                // __replaceWith__ is what we want to add to the template
                string replaceWith = Console.ReadLine();
                // make a fancy Regex object from the stuff in brackets that we matched
                // it's the same as __matchValue__ just nicely escaped
                // __replaceMe__ is what we want to replace
                Regex replaceMe = new Regex(Regex.Escape(matchValue));
                // replace the bracket stuff with the user input __replaceWith__
                // the "1" tells Replace to only replace the first matching instance
                // ie. don't replace every "[noun]" in template
                madlibTemplate = replaceMe.Replace(madlibTemplate, replaceWith, 1);
            }

            // show the user what they wrote
            Console.WriteLine($"\nHere it is, you sick sunuvagun:\n{madlibTemplate}");
        }
    }
}