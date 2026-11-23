using System; 
using System.Drawing; 
using System.Windows.Forms; 
 
public class Program8 : Form 
{ 
    Label result = new Label(); 
 
    public Program8() 
    { 
        Text = "Mouse and Keyboard Events"; 
        Size = new Size(400, 250); 
 
        result.Text = "Click mouse or press any key"; 
        result.Location = new Point(50, 80); 
        result.AutoSize = true; 
 
        Controls.Add(result); 
 
        this.MouseClick += (s, e) => 
        { 
            result.Text = "Mouse Clicked!"; 
        }; 
 
        this.KeyPreview = true; 
 
        this.KeyDown += (s, e) => 
        { 
            result.Text = "Key Pressed: " + e.KeyCode; 
        }; 
    } 
} 