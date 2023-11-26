using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_DownCasting.Domain.Models
{
    public partial  class Student : User
    {
        public int Point { get; set; }

    }

    public partial class Student : User
    {
        public Student(string fullName, int point) : base(fullName)
        {
            Point = point;
        }


        public override void Info()
        {
            Console.WriteLine($"Id: {Id}\n Fullname:{FullName}\n Point: {Point}");
        }

    }
}
