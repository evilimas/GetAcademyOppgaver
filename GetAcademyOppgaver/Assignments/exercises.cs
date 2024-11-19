namespace GetAcademyOppgaver.Assignments;

public class exercises
{
    public void Run()
    {
                /*1. Print a Greeting
                Description: Write a program that asks the user for their name and prints a personalized greeting.
                Steps:
                Ask the user to input their name.
                Print a message like: Hello, [name]! Welcome to the program!.
                */
                
                // Console.WriteLine("Please enter your Name! ");
                // string name = Console.ReadLine();
                //
                // Console.WriteLine($"Hello {name}! ");
                // Console.WriteLine($"How old are you");
                // string ageInput = Console.ReadLine();
                // int age = int.Parse(ageInput);
                //
                // Print(age);
                //    
                //
                // static void Print( int age, string name = "With No Name")
                // {
                //     if (!string.IsNullOrWhiteSpace(name) && age < 18)
                //     {
                //         Console.WriteLine($"You {name} are not old enough to vote!");
                //         
                //     }  
                //     else
                //     {
                //         Console.WriteLine($"You {name} are old enough to vote!"); 
                //     }
                // }
                // ------
                
                
                /*2. Reverse a String
                Description: Write a program that reverses a given string.
                Steps:
                Ask the user to input a string.
                Reverse the string manually or using string methods.
                Print the reversed string.*/
                                
                // Console.WriteLine("Please enter a word you want to turn arround ");
                // var word = Console.ReadLine();
                // ReverseString(word);
                // static void ReverseString(string word)
                // {
                //     var array = word.ToCharArray();
                //     Array.Reverse(array);
                //     Console.WriteLine(string.Join("" , array));
                // }
                // ------
                
                
                /*3. List Favorite Items
                    Description: Ask the user to input a list of their favorite items, separated by commas, and print them one per line.
                    Steps:
                    Ask the user to input a comma-separated list of items.
                    Split the string into an array using .Split(',').
                    Use a loop to print each item.*/
                
                // Console.WriteLine("Please enter a list of your favorite items, separated by commas.");
                // string favoriteItems = Console.ReadLine();
                // string[] items = favoriteItems.Split(',');
                // int index = 1;
                //
                // foreach (string item in items)
                // {
                //     Console.WriteLine($"{index}. {item.ToUpper().Trim()}");
                //     index++;
                // }
                // ------
                
                
                /*4. Check for a Word in a Sentence
                Description: Ask the user for a sentence and a word. Check if the word is in the sentence.
                Steps:
                Ask the user to input a sentence.
                Ask the user to input a word to search for.
                Use .Contains() to check if the word is in the sentence.
                Print whether the word was found or not.*/

    }
}