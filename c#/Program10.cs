using System;
using MySql.Data.MySqlClient;
class Program10
{
 public static void Run()
 {
 string cs = "server=localhost;database=College;uid=root;pwd=;";
 using (MySqlConnection con = new MySqlConnection(cs))
 {
 con.Open();
 // Create (Insert)
 MySqlCommand cmd = new MySqlCommand(
 "INSERT INTO Student VALUES (1, 'Ravi', 'BCA')", con);
 cmd.ExecuteNonQuery();
 Console.WriteLine("Record Inserted");
 // Read
 cmd = new MySqlCommand("SELECT * FROM Student", con);
 MySqlDataReader dr = cmd.ExecuteReader();
 while (dr.Read())
 {
 Console.WriteLine(
 dr["Id"] + " " +
dr["Name"] + " " +
dr["Course"]);
 }
 dr.Close();
 // Update
 cmd = new MySqlCommand(
 "UPDATE Student SET Name='Raj' WHERE Id=1", con);
 cmd.ExecuteNonQuery();
 Console.WriteLine("Record Updated");
 // Delete
 cmd = new MySqlCommand(
 "DELETE FROM Student WHERE Id=1", con);
 cmd.ExecuteNonQuery();
 Console.WriteLine("Record Deleted");
 }
 }
}