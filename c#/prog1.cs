  using System; 
  class Program 
    {

    static void Main() { 
    int a = 10, b = 3; 
    double pi = 3.14; 
    char ch = 'A'; 
    string name = "BCA"; 
    bool status = true; 
    Console.WriteLine("Data Types &Variables:"); 
    Console.WriteLine("Int: " + a + ", Double:" + pi + ",Char: " + ch + ", String: " + name + ", Bool:" + status);
    Console.WriteLine("\nOperators:"); 
    Console.WriteLine("Addition (a + b) : " + (a + b)); 
    Console.WriteLine("Division (a / b) : " + (a / b)); 
    Console.WriteLine("Modulus (a %b) : " + (a % b)); 
    Console.WriteLine("Relational (a > b) : " + (a > b)); 
    Console.WriteLine("Logical (a >5 && b < 5): " + (a > 5 && b < 5)); 
    Console.WriteLine("Ternary Check : " + (a % 2 == 0 ? "Even" : "Odd")); } }