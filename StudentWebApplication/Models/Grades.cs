namespace StudentWebApplicationAPI.Models;
public class Grades
{
  public static double GetAverage(List<int> scores)
  {
    if (scores == null || scores.Count == 0)
      return 0;
    return scores.Average();
  }
  public static string GetGrade(double average)
  {
    if (average >= 75)
      return "A";
    if (average >= 65)
      return "B";
    if (average >= 55)
      return "C";
    if (average >= 45)
      return "D";
    else
      return "F";

  }
}