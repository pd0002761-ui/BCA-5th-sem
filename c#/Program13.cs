using System; 
using System.Windows.Forms; 
using MySql.Data.MySqlClient; 
 
public class Program13 : Form 
{ 
    TextBox t1 = new TextBox(); 
    TextBox t2 = new TextBox(); 
 
    public Program13() 
    { 
        Text = "Student Information System"; 
        Width = 350; 
        Height = 250; 
 
        Label l1 = new Label(); 
        l1.Text = "Name"; 
        l1.SetBounds(30, 30, 80, 25); 
 
        t1.SetBounds(120, 30, 150, 25); 
 
        Label l2 = new Label(); 
        l2.Text = "Age"; 
        l2.SetBounds(30, 70, 80, 25); 
 
        t2.SetBounds(120, 70, 150, 25); 
 
        Button b = new Button(); 
        b.Text = "Save"; 
        b.SetBounds(120, 120, 80, 30); 
 
        b.Click += (s, e) => 
        { 
            string cs = "server=localhost;user id=root;password=;database=studentdb;"; 
 
            using (MySqlConnection con = new MySqlConnection(cs)) 
            { 
                con.Open(); 
                string q = "INSERT INTO student(name,age) VALUES(@n,@a)"; 
                MySqlCommand cmd = new MySqlCommand(q, con); 
 
                cmd.Parameters.AddWithValue("@n", t1.Text); 
                cmd.Parameters.AddWithValue("@a", t2.Text); 
cmd.ExecuteNonQuery(); 
} 
MessageBox.Show("Student Saved Successfully"); 
}; 
  
Controls.AddRange(new Control[] { l1, t1, l2, t2, b });
}
}