

using NannoA_Student_Database.Models;

namespace NannoA_Student_Database.Services;

    public interface IStudentDataService
    {
    List<Student> GetStudent();
    List<Student> AddStudent(string firstName, string lastName, string hobby);
    List<Student> DeleteStudent(string firstName);
    // List<Student> UpdateStudent(string  oldName, string newName);
        
    }
