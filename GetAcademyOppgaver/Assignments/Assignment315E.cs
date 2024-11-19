namespace GetAcademyOppgaver.Assignments;

public class Assignment315E
{
    
    public void Run()
    {
        Console.WriteLine("Oppgaver Assignment 315E");
        Console.WriteLine("Please enter a start, end and step");
        string[] input = Console.ReadLine().Split(" ");
        int start = int.Parse(input[0]);
        int end = int.Parse(input[1]);
        int step = int.Parse(input[2]);
        
        
        int[] result = GenerateNumbers(start, end, step);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        int[] GenerateNumbers(int start, int end, int difference)
        {
            List<int> numbers = new List<int>();

            for (int number = start; number <= end; number += difference)
            {
                numbers.Add(number);
            }

            return numbers.ToArray();
        }

    }
    
}

