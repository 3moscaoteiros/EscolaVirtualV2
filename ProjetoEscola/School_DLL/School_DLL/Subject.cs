using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_DLL
{
    public class Subject
    {
        public int id { get; set; }
        public string Name { get; set; }

        public Teacher teacher;
    }
}
