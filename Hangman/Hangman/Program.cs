namespace Hangman;
class Program
{
    const int STARTING_GUESS_COUNT = 10;

    static void Main(string[] args)
    {
        Random rng = new Random();
        char[] blankWordArray = { '_', ' ' }; //maybe use += in a for loop to repeat for varied word lengths
        char lettersAlreadyUsed = ' '; //come back to this

        List<string> wordBankFiveLetters = new List<string>() { "think", "flame", "train", "clean", "great" };
        List<string> wordBankSixLetters = new List<string>();
        { };
        List<string> wordBankSevenLetters = new List<string>();
        { };

        Console.WriteLine("Let's play hangman! Would you like to guess a 5, 6, or 7 letter word?");
        int wordLength = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < wordLength; i++)
        {
            blankWordArray +=;
            Console.WriteLine(blankWordArray);
        }
        //Console.WriteLine(blankWordArray[wordLength]); //this doesn't work if using loop to generate blanks
        //Console.Write($"Guess a letter. You have made # incorrect guesses. Only # wrong guesses remaining."); //Needs variables to track number of guesses left.
        //Console.WriteLine($"You have already used these letters: {lettersAlreadyUsed}");
        //string userInput = Console.ReadLine().ToLower();
        //char guessedLetter = Convert.ToChar(userInput);

        //if (wordLength == 5)
        //{
        //    int randomListItem = rng.Next(wordBankFiveLetters.Count);
        //    foreach (char letter in wordBankFiveLetters[randomListItem])
        //    {
        //        for (int i = 0; i < blankWordArray.Length; i++)
        //        {
        //            if (wordBankFiveLetters[randomListItem][letter] = guessedLetter)
        //            //Would this be an instance to use a jagged array?
        //            {
        //                blankWordArray[i] = letter;
        //            }
        //        }
        //    }
        //}
        //if (wordLength == 6)
        //{

        //    int randomListItem = rng.Next(wordBankSixLetters.Count);
        //}
        //else
        //{

        //    int randomListItem = rng.Next(wordBankSevenLetters.Count);
        //}
    }
}