using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Klass
    {
        public Klass()
        {
            students = new List<Student>();
        }
        public Teacher teacher { get; set; }

        public List<Student> students { get; set; }

        public int klassId { get; set; }
    }
}
