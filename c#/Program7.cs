using System; 
using System.Drawing; 
using System.Windows.Forms; 
 
public class Program7 : Form 
{ 
    TextBox t1 = new TextBox(); 
    TextBox t2 = new TextBox(); 
    Label result = new Label(); 
 
    public Program7() 
    { 
        Text = "Arithmetic Operations"; 
        Size = new Size(400, 300); 
 
        Label l1 = new Label(); 
        l1.Text = "First Number:"; 
        l1.Location = new Point(30, 30); 
 
        t1.Location = new Point(150, 30); 
 
        Label l2 = new Label(); 
        l2.Text = "Second Number:"; 
        l2.Location = new Point(30, 70); 
 
        t2.Location = new Point(150, 70); 
 
        Button b1 = new Button(); 
        b1.Text = "Add"; 
        b1.Location = new Point(30, 120); 
 
        Button b2 = new Button(); 
        b2.Text = "Subtract"; 
        b2.Location = new Point(120, 120); 
 
        Button b3 = new Button(); 
        b3.Text = "Multiply"; 
        b3.Location = new Point(220, 120); 
 
        Button b4 = new Button(); 
        b4.Text = "Divide"; 
        b4.Location = new Point(120, 160); 
 
        result.Text = "Result:"; 
        result.Location = new Point(30, 210); 
        result.AutoSize = true; 
 
        b1.Click += (s, e) => Calculate('+'); 
        b2.Click += (s, e) => Calculate('-'); 
        b3.Click += (s, e) => Calculate('*'); 
        b4.Click += (s, e) => Calculate('/'); 
 
        Controls.AddRange(new Control[] 
        { l1, t1, l2, t2, b1, b2, b3, b4, result }); 
    } 

    void Calculate(char op) 
    { 
        if (!double.TryParse(t1.Text, out double a) || 
            !double.TryParse(t2.Text, out double b)) 
        { 
            MessageBox.Show("Enter valid numbers"); 
            return; 
        } 
 
        if (op == '/' && b == 0) 
        { 
            MessageBox.Show("Cannot divide by zero"); 
            return; 
        } 
 
        double answer = 0; 
 
        switch (op) 
        { 
            case '+': answer = a + b; break; 
            case '-': answer = a - b; break; 
            case '*': answer = a * b; break; 
            case '/': answer = a / b; break; 
        } 
 
        result.Text = "Result: " + answer; 
    } 
} 