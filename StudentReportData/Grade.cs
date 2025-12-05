public class Grades
{
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