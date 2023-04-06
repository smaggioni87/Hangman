namespace Hangman;
class Program
{
    const int STARTING_GUESS_COUNT = 10;

    static void Main(string[] args)
    {
        string[] blankWordArray = { "_____" };
        string lettersAlreadyUsed = ""; //string of letters already used

        var wordBank = new List<string>() { "think", "flame", "train", "clean", "great" };

        //Random word from list - Will need to go in a loop
        Random rng = new Random();
        int randomListItem = rng.Next(wordBank.Count);

        Console.WriteLine("Let's play hangman!");
        Console.WriteLine(blankWordArray);
        Console.Write($"Guess a letter. You have made # incorrect guesses. Only # wrong guesses remaining."); //Needs variables to track number of guesses left.
        Console.WriteLine($"You have already used these letters: {lettersAlreadyUsed}");
        string userGuess = Console.ReadLine().ToLower();
        char userGuessConvertedToChar = Convert.ToChar(userGuess);

        //Determine if character is part of the string
       
        foreach (char letter in wordBank[randomListItem])
        {
            if (userGuessConvertedToChar == letter)
            {
                //How can I specify the location to write
                blankWordArray[letter] = userGuess;
                Console.WriteLine(blankWordArray);
            }
        }
        
    }
}

