using System;
class Program
{
    static void Main()
    {
        int marks = 75;
        if (marks >= 60)
        Console.WriteLine("Result: First Class");
        else 
            Console.WriteLine("Result: Second Class"); 
            char op = '+'; 
           switch (op) 
           { case '+': 
                Console.WriteLine("Operation: Addition"); 
                break; 
            case '-': 
                Console.WriteLine("Operation: Subtraction"); 
                break;
            default: 
                Console.WriteLine("Invalid");
                break; 
        }      Console.Write("For Loop: "); 
        for (int i = 1; i <= 5; i++)
            Console.Write(i + " "); 
        
           Console.Write("\nWhile Loop (Even): "); 
        int w = 2; 
        while (w <= 6) { 
            Console.Write(w + " ");
            w += 2;
        } Console.Write("\nForeach Array: "); 
        int[] arr = { 10, 20, 30 }; 
        foreach (int val in arr) 
            Console.Write(val + " "); 
            Console.WriteLine(); } }
