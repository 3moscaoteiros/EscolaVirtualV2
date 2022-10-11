using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_DLL
{
    internal abstract class User
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string EMAIL { get; set; }
        public int NIF { get; set; }
        public string ID { get; set; }
        public string PIN { get; set; }
        public bool Request { get; set; }

    }
}
