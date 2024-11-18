namespace GetAcademyOppgaver.Assignments;

public class Assignment315D
{
    public void Run()
    {
        Console.WriteLine("Oppgaver Assignment 315D");
        Console.WriteLine("Please enter a word or a sentence");
        string text = Console.ReadLine();
        
        int wordCount = CountWords(text);
        Console.WriteLine($"The word count is {wordCount}");

        string longestWord = FindLongestWord(text);
        Console.WriteLine($"The longest word is: {longestWord}");
        


        static int CountWords(string textInput)
        {
            return textInput.Split(" ").Length;
            
        }

        static string FindLongestWord(string textInput)
        {
            // Split the input and return the longest word
            return textInput.Split(" ").OrderByDescending(word => word.Length).FirstOrDefault();
        }
        
    }
}