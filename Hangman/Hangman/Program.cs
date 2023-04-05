namespace Hangman;
class Program
{
    const int STARTING_GUESS_COUNT = 10;

    static void Main(string[] args)
    {
        string blankWord = "_ _ _ _ _";
        string lettersAlreadyUsed = ""; //array of letters already used

        
        List<string> wordBank = new List<string>() {"think", "flame", "train", "clean", "great"};

        //Random word from list - Will need to go in a loop
        Random rng = new Random();
        int randomListItem = rng.Next(wordBank.Count);

        Console.WriteLine("Let's play hangman!");
        Console.WriteLine(blankWord);
        Console.Write($"Guess a letter. You have made # incorrect guesses. Only # wrong guesses remaining."); //Needs variables to track number of guesses left.
        Console.WriteLine($"You have already used these letters: {lettersAlreadyUsed}");
        string userGuess = Console.ReadLine();

        Console.WriteLine(wordBank[randomListItem]);

        //Use a function to help determine if character is part of the string
        //foreach (string item in randomListItem)
        //{

        //}
        
    }
}

