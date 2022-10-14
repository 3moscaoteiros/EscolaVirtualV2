using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_DLL;
namespace ProjetoEscola
{
    internal static class Program
    {
        public static List<Year> Anos = new List<Year>()
        {   new Year(){year = "10"},
            new Year(){year = "11"},
            new Year(){year = "12"}
        };
        
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            
        }
    }
}
