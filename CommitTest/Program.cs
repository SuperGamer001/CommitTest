// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hey there Mr. Blue!");

TestMethod();

Message("This is a message from the Message method.");

UserMessage();

UserMathEquation();





void TestMethod()
{
    // This is a test method
    Console.WriteLine("This is a test method.");
}

void Message(string Message)
{
    // Print the message parameter to the console
    Console.WriteLine(Message);
}
void UserMessage()
{
    // Ask the user for a message and print it to the console
    Console.Write("Enter a message: ");
    string userMessage = Console.ReadLine();
    if (!string.IsNullOrEmpty(userMessage))
    {
        Console.WriteLine($"You entered: {userMessage}");
    }
    else
    {
        Console.WriteLine("No message entered.");
    }
}
void UserMathEquation()
{
    Console.Write("Enter a Math Equation (only uses these symbols: + - * /): ");
    string equation = Console.ReadLine();
    // Evaluate a simple math equation provided by the user
    try
    {
        var result = new DataTable().Compute(equation, null);
        Console.WriteLine($"The result of '{equation}' is: {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error evaluating equation: {ex.Message}");
    }
}