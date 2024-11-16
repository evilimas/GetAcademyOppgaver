namespace GetAcademyOppgaver.Assignments;

public class Assignment315C
{
    public void Run()
    {
        Console.WriteLine("Oppgaver Assignment 315C");
        string text = "Terje";
        Console.WriteLine(text);
        ReverseString(text);
        return;


        static void ReverseString(string text)
        {
            var array = text.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(string.Join("", array));
            
        } 
        
    }
}