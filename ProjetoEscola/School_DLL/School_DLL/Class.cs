using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_DLL
{
   public class Class
   {
        string Name { get; set; }
        int id { get; set; }

        public List<Student> students = new List<Student>();
   }
}
