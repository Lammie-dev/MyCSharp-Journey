// See https://aka.ms/new-console-template for more information



using System.Runtime.Intrinsics.Arm;

var students = new[]
{
    new {studentId = 1, Name = "Alice"},
    new { studentId = 2, Name = "Bob"}
};

var enrollment = new[]
{
   new {studentId =1, course = "Math"},
    new {studentId = 1, course = "Science"},
    new {studentId = 2, course = "History"}

};

var results = students.GroupJoin(enrollment,
student => student.studentId,
enrollment => enrollment.studentId,
(students, studentEnrollment) => new
{
    students.Name,
    courses = studentEnrollment.Select(e => e.course)
});

foreach (var result in results)
{
    Console.WriteLine($"{result.Name}: {string.Join(",", result.courses)}");
}

var numbers = new[] { 1, 2, 3, 4, 5 };
var words = new[] { "one", "two", "three", "four", "five" };

var zipped = numbers.Zip(words, (n, w) => $"{n} = {w}");

foreach (var zip in zipped)
{
    Console.WriteLine(zip);
   
}