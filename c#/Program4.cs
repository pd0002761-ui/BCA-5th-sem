using System; 
 
class Student 
{ 
    // Properties 
    public int RollNo { get; set; } 
    public string Name { get; set; } 
 
    // Constructor 
    public Student(int r, string n) 
    { 
        RollNo = r; 
        Name = n; 
    } 
 
    // Method 
    public void Display() 
    { 
        Console.WriteLine("Roll No: " + RollNo + ", Name: " + Name); 
    } 
} 
 
class Program4 
{ 
    public static void Run() 
    { 
        Student s1 = new Student(101, "Rahul"); 
        Student s2 = new Student(102, "Sneha"); 
        s1.Display(); 
        s2.Display(); 
    }
}