namespace HelloWeb.Models;

public class Employee
{
    public int Id { get; set; }
   public  string FirstName { get; set; }
    public string LastName { get; set; }
    public  string Designaton { get; set; }
    public byte  Level { get; set; }
    public DateTime JoinDate { get; set; }
    public string Department { get; set; }
}
