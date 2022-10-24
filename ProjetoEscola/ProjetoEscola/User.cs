using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    public abstract class User
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string EMAIL { get; set; }
        public int NIF { get; set; }
        public string PIN { get; set; }
        public string ID { get; set; }
        public bool Request { get; set; }
        public string RequestInfo { get; set; }

    }
}
