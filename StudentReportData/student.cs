public class Student
{
  public string ? Name { get; set; }
  public string? Gender { get; set; }
  public List<int> Scores { get; set; } = [];
  public double Average => Scores.Average();
  public string Grade => Grades.GetGrade(Average);
}