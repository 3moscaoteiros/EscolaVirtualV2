using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    public class Student : User
    {
        public double Balance { get; set; }

        public List<Grade> grades = new List<Grade>();
    }
}
