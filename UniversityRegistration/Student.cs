public class Student
{
  public string Firstname { get; set; }
  public string Lastname { get; set; }

  public string Gender { get; set; }
  public string Matric { get; set; }

  public Student(string fname, string lname, string gender, string matric)
  {
    Firstname = fname;
    Lastname = lname;
    Gender = gender;
    Matric = matric;

  }

 
  public override string ToString()
  {
    return Firstname + "" + Lastname;
  }
    
}