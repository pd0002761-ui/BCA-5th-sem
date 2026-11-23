using System; 
using System.Windows.Forms; 
 
public class Program15 : Form 
{ 
    public Program15() 
    { 
        Text = "Login Form"; 
        Width = 350; 
        Height = 220; 
 
        Label l = new Label(); 
        l.Text = "Username"; 
        l.SetBounds(30, 30, 100, 25); 
 
        TextBox t1 = new TextBox(); 
        t1.SetBounds(130, 30, 150, 25); 
 
        Label l2 = new Label(); 
        l2.Text = "Password"; 
        l2.SetBounds(30, 70, 100, 25); 
 
        TextBox t2 = new TextBox(); 
        t2.SetBounds(130, 70, 150, 25); 
        t2.PasswordChar = '*'; 
 
        Button b = new Button(); 
        b.Text = "Login"; 
        b.SetBounds(130, 120, 100, 30); 
 
        b.Click += (s, e) => 
        { 
            if (t1.Text == "admin" && t2.Text == "1234") 
                MessageBox.Show("Login Successful"); 
            else 
                MessageBox.Show("Invalid Login"); 
        }; 
 
        Controls.AddRange(new Control[] { l, t1, l2, t2, b }); 
    } 
} 