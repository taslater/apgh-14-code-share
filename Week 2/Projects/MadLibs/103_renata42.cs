// imaniemanuel: Rich Stanley jallison Me

using System;

namespace TeamJagLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt V---V

            //[Author] wrote my favorite book[book] and sometimes I[verb] the pages[adverb].


            //[Date]

            //Dear[Last Name],

            // It has come to my attention that your child, [child's name], has eaten an inordinate amount of paste and is costing the school district [amount needed for football uniforms]. Please pay back this amount immediately.

            //Thank you,
            //[Your name]

            //--------------------------------------------------------------------------------------\\


            //We're gonna need a story we can cut pieces out of
            // Write a story, pick out words we want to replace after writing the story. 
            // Reader fills out the cut out pieces. 
            // Story plays out with the words the reader puts out.
            // 
            // One story at a time. Then MAYBE do more stories. 
            // 


            // "Once upon a time, there was a (adjective1) (noun1) who was very (adjective2). He (verb1) up a (noun2) to (verb2) some (noun plural).
            // He tried to (verb2) up the (noun3)) but he was too (adjective3) and (verb3) (adjective4) down the (noun4)." 


            //---------------------------------------------------------------------------------------------\\

            //Actual Stuff Do

            // Search through the strings.Write out the actual story as a string
            // Tell the computer to search through the string and look for the opening bracket []
            // Inside the opened bracket computer wants to take what's in that bracket  (Nouns, verbs, and adjectives) and save it. 
            // Ask the user to give their input (Fills into that bracket)
            // The computer will reprint that string with the user inputs.

            // After we save the story ---> We pick through the brackets[]
            // Then we replace what's in the brackets with our variables for different words 
            // Then print the new story which we will store with a different variable name with the replacements. 

            //string story = "? wrote my favorite book[book] and sometimes I[verb] the pages[adverb].";
            //foreach(Char '[' in story);


            string story = "[Author] wrote my favorite book [title] and sometimes I [verb] the pages [adverb].";

            bool offon = true;

            while (offon) // <---
            {

                int position1 = story.IndexOf('[');
                int position2 = story.IndexOf(']');
                string word1 = story.Substring(position1, position2 - position1 + 1);

                Console.WriteLine("Provide a name ");
                story = story.Replace(word1, Console.ReadLine());  // <--- Replace ?
                int position3 = story.IndexOf('[');
                int position4 = story.IndexOf(']');
                string word2 = story.Substring(position3, position4 - position3 + 1);
                Console.WriteLine("Provide a book title ");
                story = story.Replace(word2, Console.ReadLine());
                int position5 = story.IndexOf('[');
                int position6 = story.IndexOf(']');
                string word3 = story.Substring(position5, position6 - position5 + 1);
                Console.WriteLine("Provide a verb ");
                story = story.Replace(word3, Console.ReadLine());
                int position7 = story.IndexOf('[');
                int position8 = story.IndexOf(']');
                string word4 = story.Substring(position7, position8 - position7 + 1);
                Console.WriteLine("Provide an adverb ");
                story = story.Replace(word4, Console.ReadLine());

                Console.WriteLine(story);


                if (story[0] > -1)
                {
                    offon = false;
                }
            }
            //Console.ReadLine();
        }
    }
}
