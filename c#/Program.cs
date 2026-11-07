using System;
class Program
{
    // Simple Method
    static int Add(int a, int b)
    {
        return a + b;
    }
    static void Main()
    {
        // Arrays
        int[] arr = { 50, 10, 30 };
        Array.Sort(arr);
        Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
        // Strings
        string str = "bca college";
        Console.WriteLine("Uppercase: " + str.ToUpper());
        Console.WriteLine("Substring: " + str.Substring(0, 3));
        // Simple Method
        int sum = Add(4, 5);
        Console.WriteLine("Sum = " + sum);
    }
}
