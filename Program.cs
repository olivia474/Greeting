namespace Greeting;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?: ");
        string? firstName = Console.ReadLine();

        Console.Write("What is your surname?: ");
        string? lastName = Console.ReadLine();
        
         if(string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName)){
            Console.WriteLine("Hey, looks like you forgot to enter your first name!");
        }

        else if (!string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName)) {
            Console.WriteLine("Oops! You didn't enter your last name. Mind filling that in?");
        }

        else if(string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName)) {
            
            Console.WriteLine("Uh oh! It seems like you forgot to enter both your first name and your last name. Can you please provide them?");
        }
        
        else {
            Console.WriteLine("Great! Thank you for entering your first name and last name.");
        }

        Console.ReadLine();
     
    }
}