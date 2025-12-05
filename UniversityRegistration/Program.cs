using System;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Linq;

public class Program
{
  public static void Main(string[] args)
  {
    StudentOperation studentOperation = new StudentOperation();

    studentOperation.updateStudentRecord();

   
  }
}
