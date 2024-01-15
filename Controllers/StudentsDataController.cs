
using Microsoft.AspNetCore.Mvc;
using NannoA_Student_Database.Models;
using NannoA_Student_Database.Services;


namespace NannoA_Student_Database.Controllers;
[ApiController]
[Route("[controller]")]
public class StudentsDataController : ControllerBase
{
    // public List<string> studentList = new();
    private readonly IStudentDataService _studentDataService;

    public StudentsDataController(IStudentDataService studentDataService)
    {
        // studentList.Add("Ashur");
        // studentList.Add("George");
        _studentDataService = studentDataService;
    }

    [HttpGet]
    [Route("GetStudent")]
    public List<Student> GetStudent()
    {
        return _studentDataService.GetStudent();
    }

    [HttpPost]
    [Route("AddStudent/{firstName}/{lastName}/{hobby}")]
    public List<Student> AddStudent(string firstName, string lastName, string hobby)
    {
        return _studentDataService.AddStudent(firstName, lastName, hobby);
    }

    [HttpDelete]
    [Route("DeletStudent/{firstName}")]
    public List<Student> DeletStudent(string firstName)
    {
        return _studentDataService.DeleteStudent(firstName);
    }

    // [HttpPut]
    // [Route("UpdateStudent/{oldName}/{newName}")]
    // public List<Student> UpdateStudent(string oldName, string newName)
    // {
    //     return _studentDataService.UpdateStudent(oldName, newName);
    // }

}
