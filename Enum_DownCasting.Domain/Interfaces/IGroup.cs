using Enum_DownCasting.Domain.Models;
using System.Data.SqlTypes;

namespace Enum_DownCasting.Helpers.Interfaces
{
    public interface IGroup
    {
        bool CheckGroupNo(string groupNo);
        void AddStudent(Student student);
        Student GetStudent(int studentId);
        Student[] GetAllStudents();
    }
}
