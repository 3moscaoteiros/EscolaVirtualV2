using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProjetoEscola
{
    internal static class Program
    {
        public static List<Year> Anos = new List<Year>()
        {
            new Year(){year = "5"},
            new Year(){year = "6"},
        };

       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
