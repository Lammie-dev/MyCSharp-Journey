using System.IO;
using System;

public class CsvHandler
{
  public static void writeToCSV(string filePath)
  {
    var lines = new List<string> { "ID, NAME", "1, Alice", "2, James", "3, John" };
    File.WriteAllLines(filePath, lines);
  }

  public static void readCSV(string filePath)
  {
  foreach (var line in File.ReadLines(filePath))
  {
      Console.WriteLine(line);
  }
 }
}
