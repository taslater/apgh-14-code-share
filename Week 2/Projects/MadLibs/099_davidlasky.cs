using System;

namespace MadLibs
{
    class Program
    {
        static void FindWords(string textRaw)
        {
            bool insideBrackets = false;
            string finalOutput = "";
            string questionPhrase = "";
            for (int i = 0; i < textRaw.Length; i++)
            {
                if (textRaw[i] == '[')
                {
                    insideBrackets = true;
                    //we start building a term
                }
                else if (textRaw[i] == ']')
                {
                    //we finish building a term
                    insideBrackets = false;
                    //use questionPhrase to ask user for a word, immediately dump word into final answer in correct place
                    finalOutput = finalOutput + AnswerPrompt(questionPhrase);
                    //erase questionPhrase to get ready for the next word
                    questionPhrase = "";
                }
                else if (insideBrackets)
                {
                    //building the questionPhrase, the kind of word we're gonna ask for
                    questionPhrase = questionPhrase + textRaw[i];
                }
                else
                {
                    finalOutput = finalOutput + textRaw[i];
                }
            }
            //Console.WriteLine(questionPhrase);
            Console.WriteLine(finalOutput);
        }
        static string AnswerPrompt(string request)
        {
            //ask for an input
            Console.WriteLine("Please give me a(n) " + request);
            //receive and record and input
            string input = Console.ReadLine().ToLower();
            //??tick one step up in our array to get ready for our next input??
            return input;
        }
        static void Main(string[] args)
        {

            string textRaw = "Oh about [number] days ago, I was walking in [place] when I saw a [tchotchke] and decided, you know what, I might just do a [crime] so that I can do get one! So I went ahead and [adverb] [verb] [number] times. Now, I wasn't that successful so officer [Person's Name] took me in his police car down to the station. Oh my, the things I shared a cell with! There was a [adjective] [noun], and a [adjective] [noun], and at least [number] [adjective] [plural nouns]! Anyways, I was sentenced to [time] years in prison where I spend my time [jerund] and [jerund].";
            bool playing = true;
            while (playing)
            {
                Console.WriteLine("Do you wanna get NUTSO CRAZY with madlibs????(Y/N)");
                string task = Console.ReadLine().ToUpper();
                if (task == "Y")
                {
                    //playing game
                    FindWords(textRaw);
                }
                //quit game
                else if (task == "N")
                {
                    playing = false;
                }
                //error message
                else
                {
                    Console.WriteLine("come on man, I said 'Y/N'");
                }
            }
        }
    }
}
//=========outline in english time, my dudes=====
//read a madlib string
//sort out the variables needed
//prompt user for different parts of speech (noun, pronoun, name a crime, etc)
//recieve/record answers
//write out completed madlib
//ask user if they wanna play again

//===========implementation deets==================
//Make a spot in the code to receive a madlibs text
//comb our madlibs text to find out variables
//make variables for users to fill
//prompt user for words with CodeWriteLines
//Save answers as strings with names or some way to call them
//as a class array
//concatonate (turn them into a cat) answers with story
//print concatonated concatination of concatinated story
//LOOP to play again or quit
//generate a story with holes in it