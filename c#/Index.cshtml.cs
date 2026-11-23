using Microsoft.AspNetCore.Mvc; 
using Microsoft.AspNetCore.Mvc.RazorPages; 
using MySql.Data.MySqlClient; 
 
namespace ASP2.Pages; 
 
public class IndexModel : PageModel 
{ 
    string cs = "server=localhost;port=3306;database=College;uid=root;pwd=;"; 
 
    [BindProperty] 
    public int Id { get; set; } 
 
    [BindProperty] 
    public string Name { get; set; } = ""; 
 
    public string Message { get; set; } = ""; 
 
    public void OnGet() 
    { 
    } 
 
    public void OnPost() 
    { 
        using MySqlConnection con = new MySqlConnection(cs); 
        con.Open(); 
 
        string query = "INSERT INTO Student (Id, Name) VALUES (@id, @name)"; 
        using MySqlCommand cmd = new MySqlCommand(query, con); 
 
        cmd.Parameters.AddWithValue("@id", Id); 
        cmd.Parameters.AddWithValue("@name", Name); 
        cmd.ExecuteNonQuery(); 
 
        Message = "Record Saved Successfully!"; 
    } 
} 
