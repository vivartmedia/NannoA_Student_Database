
using NannoA_Student_Database.Data;
using NannoA_Student_Database.Models;

namespace NannoA_Student_Database.Services.Students;

public class StudentDataService : IStudentDataService
{
    private readonly DataContext _db;
     

    public StudentDataService(DataContext db)
    {
        // studentList.Add("Ashur");
        // studentList.Add("George");
        _db = db;
    }
    public List<Student> AddStudent(string firstName, string lastName, string hobby)
    {
        Student newStudent = new()
        {
            FirstName = firstName,
            LastName = lastName,
            Hobby = hobby
        };
        _db.Students.Add(newStudent);
        _db.SaveChanges();
        return _db.Students.ToList();

    }

    public List<Student> DeleteStudent(string firstName)
    {
       var student =  _db.Students.FirstOrDefault(foundStudent => foundStudent.FirstName == firstName);
       if(student != null){
            _db.Students.Remove(student);
            _db.SaveChanges();
       }
        return _db.Students.ToList();
    }

    public List<Student> GetStudent()
    {
        return _db.Students.ToList();
    }

    // public List<Student> UpdateStudent(string oldName, string newName)
    // {
    //     var student = _db.Students.FirstOrDefault(foundStudent => foundStudent.FirstName == oldName);
    //     if (student != null)
    //     {
    //         student.FirstName = newName;
    //         _db.SaveChanges();
    //     }
    //     return _db.Students.ToList();
    // }
}
