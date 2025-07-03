// See https://aka.ms/new-console-template for more information
using System.Data;

Message("Hello, World!");

Message("Hey there Mr. Blue!");

TestMethod();

Message("This is a message from the Message method.");

UserMessage();

UserMathEquation();





void TestMethod()
{
    // This is a test method
    Message("This is a test method.");
}

void Message(string message)
{
    // Print the message parameter to the console
    Console.WriteLine(message);
}
void UserMessage()
{
    // Ask the user for a message and print it to the console
    Console.Write("Enter a message: ");
    string userMessage = Console.ReadLine();
    if (!string.IsNullOrEmpty(userMessage))
    {
        Message($"You entered: {userMessage}");
    }
    else
    {
        Message("No message entered.");
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
        Message($"The result of '{equation}' is: {result}");
    }
    catch (Exception ex)
    {
        Message($"Error evaluating equation: {ex.Message}");
    }
}