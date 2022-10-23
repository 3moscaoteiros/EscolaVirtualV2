using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_DLL
{
   public class Class
   {
        public string Name { get; set; }
        
        public List<Subject> Subjects = new List<Subject>();
        
        public List<Student> students = new List<Student>();
   }
}
