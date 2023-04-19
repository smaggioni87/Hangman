namespace Hangman;
class Program
{
    const int STARTING_GUESS_COUNT = 10;

    static void Main(string[] args)
    {
        string secretWord = "cranky";

        int wordLength = secretWord.Length;
        char[] blankWordArray = new char[wordLength]; //Need to show blanks to start

        for (int i = 0; i < secretWord.Length; i++)
        {
            blankWordArray[i] = '_';
        }
        Console.WriteLine(blankWordArray);

        while (true)
        {

            for (int charIndex = 0; charIndex < secretWord.Length; charIndex++)
            {
                Console.WriteLine($"Guess a letter. You have made # incorrect guesses. Only # wrong guesses remaining."); //Needs variables to track number of guesses left.
                string userInputString = Console.ReadLine().ToLower();
                char guessedLetter = Convert.ToChar(userInputString);
                if (secretWord[charIndex] == guessedLetter)
                {
                    blankWordArray[charIndex] = guessedLetter;
                    Console.WriteLine(blankWordArray); //you end up here when you match the letter
                }
                if (secretWord == Convert.ToString(blankWordArray))
                {
                    Console.WriteLine("You win!");
                }

            }
        }
    }
}