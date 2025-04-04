namespace FizzBuzz;
using System;   

// My main class as requested


public class FizzBuzzDetector
{
    // it has the method getOverlappings
    // This method takes a string as an argument
    
    public static void getOverlappings(string args)
    {
        int WordCount = 0; 
        int WordChanged = 0;
        //splitting the string into words and store them in array 
        string[] args1 = args.Split(' ');
        //getting the length of the array
        WordCount =  args1.Length;
        //printing the length of the array
        Console.WriteLine("Word Count: " + WordCount); 
        //adding +1 to the word count to Avoid Index 0
        WordCount++;
        
        // looping through the array and seeing where the index is either divisible by 3 or 5 or both
        for (int i = 1; i < WordCount; i++)
        {
            
            if (i%3==0 && i%5==0)
            {
                // if the index is divisible by both 3 and 5, replace the word with "FizzBuzz"
                // and increment the word changed counter   
                args1[i-1] = "FizzBuzz";
                WordChanged++;  
            
            }
            else if (i%3==0)
            {
                // if the index is divisible by 3, replace the word with "Fizz"
                // and increment the word changed counter
                args1[i-1] = "Fizz";
                WordChanged++;
            }
            else if (i%5==0)
            {
                // if the index is divisible by 5, replace the word with "Buzz"
                // and increment the word changed counter   
                args1[i-1] = "Buzz";
                WordChanged++;
            }
            else    
            {
              
            }
        }
    
    // joining the array back into a string
    string result = string.Join(" ", args1);
    
    // printing the result
    Console.WriteLine(result);
    // printing the changed words count 
    Console.WriteLine("Word Changed: " + WordChanged);  
    }
}
