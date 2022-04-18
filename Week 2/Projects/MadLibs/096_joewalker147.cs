// current functional mad libs

using System;

namespace MadLibs_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mad Libs Project
            //================
            //question and concerns and CHALLeemgESs
            //how do we handled multiple nouns,blanks, etc and place them in the correct spots
            //setting specific variables for specific spots
            //editing the story issues
            //chronological order/in order??
            //user --> 10 year old playing the game
            //multiple prompts (user made prompt??)
            //simple prompt -->> build out --->> SAD LIBS
            //I went to the {{noun}} store and bought a {{adjective}} {{noun}}

            //======== process ==========
            //ask user for inputs
            //variety of inputs (nouns,adjects,etc)
            //store inputs
            // store multiple inputs 
            //handle inputs - replace {input spaces} in prompt with {user inputs}
            //place inputs into story
            //print out completed story with {user inputs}

            //===stretch goals===
            //loop the mad lib
            //storing multiple prompts
            //place same inputs into multiple prompts

            Console.WriteLine("Welcome to Mad Libs, bucko");
            string[] partsofSpeech = { "noun", "verb", "adjective" };
            Word[] words = new Word[partsofSpeech.Length];
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = new Word();
                words[i].PartOfSpeech = partsofSpeech[i];
            }

            for (int i = 0; i < words.Length; i++)
            {
                string tempPartOfSpeech = words[i].PartOfSpeech;
                Console.WriteLine("Give me a " + tempPartOfSpeech);
                string input = Console.ReadLine();
                words[i].UserInput = input;

            }
            Console.WriteLine($"{words[0].UserInput} is {words[1].UserInput}ing at the {words[2].UserInput} place");

        }
    }

    class Word
    {
        public string PartOfSpeech; //nouns, verbs, adjs, etc
        public string UserInput;

    }
}

// Yemi Truechild (she/her) Tobias Tobak (he/him) Spenser Greeley 