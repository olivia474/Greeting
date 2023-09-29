namespace Greeting;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string? aFriend;
        aFriend = Console.ReadLine();

        Console.WriteLine("Hello " + aFriend + ", nice to meet you!");
        Console.ReadLine();
    
        }
}