using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Se3.EFC
{
    internal class Instructor
    {

        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Bio { get; set; }
        public DateTime JoinedDate { get; set; } = DateTime.UtcNow;

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
