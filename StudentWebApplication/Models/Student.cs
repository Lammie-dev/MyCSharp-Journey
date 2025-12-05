namespace StudentWebApplicationAPI.Models
{


public class Student
{
  public int Id { get; set; } //EF core uses Id as a primary key
  public string? Name { get; set; }
  public string? Gender { get; set; }
  public List<int> Scores { get; set; } = new List<int>();
  public double Average { get; set; }
    public string? Grade { get; set; } 
}
}