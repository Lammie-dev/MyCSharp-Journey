using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentWebApplicationAPI.Data;
using StudentWebApplicationAPI.Models;
namespace StudentWebApplicationAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class StudentsController : ControllerBase
{
  private static List<Student> students = new();

  private readonly AppDbContext _context;
  public StudentsController(AppDbContext context)
  {
    _context = context;
  }

  [HttpPost]
  
  public async Task<IActionResult> AddStudent([FromBody] Student student)
  {
    // students.Add(student);
    student.Average = Grades.GetAverage(student.Scores);
    student.Grade = Grades.GetGrade(student.Average);
    _context.Students.Add(student);
    await
    _context.SaveChangesAsync();

    return Ok(new
    {
      student.Id,
      student.Name,
      student.Gender,
      student.Average,
      student.Grade
    });

  }
  [HttpGet]
  public async Task<IActionResult> GetAll()
  {
    var students = await _context.Students.ToListAsync();
    return Ok(students);

  }
}