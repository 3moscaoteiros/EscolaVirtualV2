using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    public class Year
    {
       public string year { get; set; }

       public List<Class> CLasses = new List<Class>();

       public List<Subject> subjects = new List<Subject>();
    }
}   
