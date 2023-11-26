using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_DownCasting.Domain.Models
{
    public  abstract partial class User
    {
        public int Id { get;}

        private static int _LastId = 0;
        public string FullName { get; set; }

    }
    public abstract partial class User
    {
        public User(string fullName)
        {
            FullName = fullName;
            _LastId++;
            Id = _LastId;
        }
        public abstract void Info();
    }
}
