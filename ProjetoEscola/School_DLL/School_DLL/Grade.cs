using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_DLL
{
    public class Grade
    {
      public double Val { get; set; }
      public Subject Subject = new Subject();
    }
}
