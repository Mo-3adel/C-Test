namespace FizzBuzz;
using System;   
    
class Program
{
    // This is the main entry point for the application.
    // It prompts the user to enter a sentence 
    // and then calls the FizzBuzzDetector class and its method getOverlappings
    // It gives the sentence to the method getOverlappings
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a sentence:");
        String Sentence=Console.ReadLine()??string.Empty;
        FizzBuzzDetector.getOverlappings(Sentence);    
    }
}

