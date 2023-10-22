class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv ett meddelande:");
        string[] userInput = Console.ReadLine().Split(" ");
        Console.WriteLine("Hur många steg till höger vill du att meddelandet ska skrivas?");
        int steps = Convert.ToInt32(Console.ReadLine());

        foreach (string input in userInput)
        {
            for (int i = 0; i < steps; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(input + "\n");
        }

    }
}