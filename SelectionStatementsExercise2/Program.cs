namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string subject;
            Console.Write("What is your favorite subject in school? >");
            subject = Console.ReadLine();

            switch (subject)
            {
                case "History": 
                    {
                        Console.WriteLine($"{subject}...Nothing new here.");
                        break;
                    }
                case "Math":
                    {
                        Console.WriteLine($"{subject}...It was hard!");
                        break;
                    }
                case "Geography":
                    {
                        Console.WriteLine($"{subject}...Cool places to go.");
                        break;
                    }
                case "English":
                    {
                        Console.WriteLine($"{subject}...Learned to write and speak correctly.");
                        break;
                    }
                case "PE":
                    {
                        Console.WriteLine($"{subject}...I could live without it.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"{subject} was something else...");
                        break;
                    }
            }



            
        }
    }
}