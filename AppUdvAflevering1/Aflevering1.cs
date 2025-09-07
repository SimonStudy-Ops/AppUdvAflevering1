namespace AppUdvAflevering1;

// Har selv løst opg 1-3 og så AI til opg 4 (Den var tricky synes jeg :=) )
public class Aflevering1
{
    
    public static void Run()
    {
        
        List<string> wordList = ReadWords();
        
        
        //Denne rækkefølge så det ser lækkert ude når man får resultaterne
        Console.WriteLine("\n--- Results ---");
        
        // Count returnere det totale nr af ord som den så udskriver
        Console.WriteLine($"Number of words: {wordList.Count}");

        // Funktion til at finde og udskrive en af de korteste og længste ord
        ShortAndLong(wordList);

        // Funktion til at udskrive ord med en længde på mindst 4
        WordsFour(wordList);

        // Funktion til at udskrive ord uden æ, ø, å
        WordsWithoutDanish(wordList);
        
        Console.WriteLine("\n--- Program finished ---");
    }

    /// <summary>
    /// Læser ord indtil man skriver stop
    /// </summary>
    /// <returns>Listen af ord der er tastet ind</returns>
    private static List<string> ReadWords()
    {
        Console.WriteLine("Enter some or ALOT of words.\nGet the results by writing '/stop'.");
        List<string> enteredWords = new List<string>();

        while (true)
        {
            Console.Write("Write '/stop' for results\nOrd-> ");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "/stop")
            {
                break;
            }
            if (!string.IsNullOrWhiteSpace(input))
            {
                enteredWords.Add(input);
            }
        }
        return enteredWords;
    }

    
    // Skriver det korteste og det længste ord ud i konsollen
    private static void ShortAndLong(List<string> words)
    {
        
        string shortestWord = words[0];
        string longestWord = words[0];

        
        foreach (string word in words)
        {
            if (word.Length < shortestWord.Length)
            {
                shortestWord = word;
            }
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        Console.WriteLine($"One of the shortest words: {shortestWord}");
        Console.WriteLine($"One of the longest words: {longestWord}");
    }

    
    // Skriver alle ord fra listen med en længde på mindst 4 :)
    private static void WordsFour(List<string> words)
    {
        Console.WriteLine("\nWords with a length of at least 4:");
        foreach (string word in words)
        {
            if (word.Length >= 4)
            {
                Console.WriteLine($"- {word}");
            }
        }
    }

    //Ai job den her :)
    /// <summary>
    /// Prints the words from the list that do not contain Danish vowels (æ, ø, å).
    /// </summary>
    private static void WordsWithoutDanish(List<string> words)
    {
        Console.WriteLine("\nWords that do not contain a Danish vowel (æ, ø, å):");
        foreach (string word in words)
        {
            string lowerCaseWord = word.ToLower();
            
            // The "!" at the start means "NOT".
            // So the condition reads: "IF it is NOT true that the word contains æ OR ø OR å..."
            if (!(lowerCaseWord.Contains("æ") || lowerCaseWord.Contains("ø") || lowerCaseWord.Contains("å")))
            {
                // If the condition is true (no Danish vowels found), print the word.
                Console.WriteLine($"- {word}");
            }
        }
    }
}