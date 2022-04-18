// Writing a Mad Libs 

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

            Console.WriteLine("Welcome to Mad Libs, bucko! \n Feelin' lazy? (a) \n Feelin' creative? (b)  ");
            string option = Console.ReadLine().ToLower();
            //Ask the user to play our game or make their game

            if (option == "a")
            {

                //written out our story in an array
                string[] story =   {"I have a ","*adjective"," ", "*type of animal",
                ". It ","*verb that ends in 's'", " down the ", "*location", " and upsets the ", "*group","."};
                //our words array is the same length as our story array
                Word[] words = new Word[story.Length];


                for (int i = 0; i < story.Length; i++)
                {
                    string phrase = story[i];
                    if (phrase[0] == '*')
                    //using a for loop, we search the story for places the user should fill in
                    {
                        words[i] = new Word();
                        words[i].PartOfSpeech = phrase;

                        Console.WriteLine("give me a " + phrase);
                        //identifies which *phrase is needed and asks for it 
                        string input = Console.ReadLine();
                        //user enters their input for each *phrase
                        words[i].UserInput = input;
                        story[i] = words[i].UserInput;
                        //repeats until all *phrases have inputs
                    }

                }
                Console.WriteLine(string.Join("", story));
                //writes out the story from array with the user inputs 
            }

            if (option == "b")
            {
                Console.WriteLine("So ya wanna write your own story \nYou'll input below \nA little something like this \nEx) [type of animal] was going to the [place]");
                string UserStory = Console.ReadLine();
                int startPlace = 0;
                int endPlace = 0;
                //explain the rules to the user and have them write us a mad libs story 



                for (int i = 0; i < UserStory.Length; i++)
                {
                    if (UserStory[i] == '[')
                    {
                        startPlace = i;
                    }
                    //designating the begining of our substring/space to fill in
                    else if (UserStory[i] == ']')
                    {
                        endPlace = i + 1;
                        string ThisBlank = UserStory.Substring(startPlace, (endPlace - startPlace));
                        //designate the ending of our substring

                        ThisBlank = ThisBlank.Replace("[", "").Replace("]", "");
                        //remove the brackets to ask for prettier inputs

                        Console.WriteLine("give me a " + ThisBlank);
                        string thisinput = Console.ReadLine();
                        //ask user for mad lib inputs for their designated blankspaces

                        UserStory = UserStory.Remove(startPlace, (endPlace - startPlace)).Insert(startPlace, thisinput);
                        //inserts the user inputs into their designated blankspaces

                    }
                }
                Console.WriteLine(UserStory);
                //write the completed story
            }
        }
    }

    class Word
    //for option a
    {
        public string PartOfSpeech;
        //storing what we are asking the user to replace
        public string UserInput;
        //storing what the user enters into the mad lib
    }
}

// Yemi Truechild (she/her) Tobias Tobak (he/him) Spenser Greeley