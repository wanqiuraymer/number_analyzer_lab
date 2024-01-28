// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello! What is your name?");
string userName = Console.ReadLine();
Console.WriteLine($"{userName}, welcome to the Number Analyzer!");
bool willRepeat = true;
while (willRepeat)
{
    Console.WriteLine("Please enter a number between 1 and 100");
    bool success = int.TryParse(Console.ReadLine(), out int userInput);
    if (success == true && userInput > 0 && userInput <= 100)
    {
        if (userInput % 2 != 0)
        {
            if (userInput < 60) { Console.WriteLine("Odd and less than 60"); }
            else { Console.WriteLine("Odd and greater than 60"); }
        }
        else
        {
            if (userInput >= 2 && userInput <= 24) { Console.WriteLine("Even and less than 25"); }
            else if (userInput >= 26 && userInput <= 60) { Console.WriteLine("Even and between 26 and 60 inclusive"); }
            else { Console.WriteLine("Even and greater than 60"); }
        }
        Console.WriteLine("Do you want to try again? Yes or No");
        string userChoice = Console.ReadLine();
        if (userChoice.ToLower().Trim() == "no")
        {
            Console.WriteLine($"Thank you for playing, {userName}! Goodbye!");
            willRepeat = false;
        }
    }
    else { Console.WriteLine($"{userName}, the value you entered has to be a number between 1 and 100. Let's try again"); }
}
Console.Read();