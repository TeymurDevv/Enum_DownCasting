using Enum_DownCasting.Helpers.Interfaces;

namespace Enum_DownCasting.Domain.Models
{
    public partial class Group
    {
        public int Id { get; set; }
        public int GroupNo { get; set; }
        public int StudentLimit { get; set; }
        public Student[] Students { get; set; }

    }

    public partial class Group : IGroup
    {
        public void AddStudent(Student student)
        {

        }

        public bool CheckGroupNo(string groupNo)
        {
            return false; //Will be corrected
        }

        public Student[] GetAllStudents()
        {
            return Students; //Will be corrected if any mistake
        }

        public Student GetStudent(int studentId)
        {
            foreach (Student student in Students) 
            {
                if (student.Id == studentId) return student;
            }
            return null;  ////Will be corrected if any mistake
        }
    }
}
