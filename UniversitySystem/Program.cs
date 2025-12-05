// using System.IO;
// class OperateFile
// {
//   public static void Main()
//   {
//     string Message = "welcome home";

//     File.WriteAllText("textfile.txt", Message);
//     Message= File.ReadAllText("message.txt" );
//     Console.WriteLine(Message);
//  } 
// }


CsvHandler.writeToCSV("files/student.csv");
CsvHandler.readCSV("files/customer.csv"); 