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
        {
            new Year(){year = "5"},
            new Year(){year = "6"},
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




            Program.Anos.Find(s => s.year == "5").subjects.AddRange(new Subject[]

                {
                 new Subject() {id = 0 , Name = "Português" ,
                                         teacher = new Teacher(){ID="t0001", } } ,
                 new Subject() {id = 1 , Name = "Matemática",
                                         teacher = new Teacher(){ID="t0002", } } ,
                 new Subject() {id = 2 , Name = "Música" ,
                                         teacher = new Teacher(){ID="t0003", } } ,
                 new Subject() {id = 3 , Name = "Ciências",
                                         teacher = new Teacher(){ID="t0004", } } ,
                 new Subject() {id = 4 , Name = "Fisico-quimica",
                                         teacher = new Teacher(){ID="t0005", } } });

            Program.Anos.Find(s => s.year == "6").subjects.AddRange(new Subject[]

                 {
                 new Subject() {id = 0 , Name = "Português" , 
                                         teacher = new Teacher(){ID="t0001"} } ,
                 new Subject() {id = 1 , Name = "Matemática",
                                         teacher = new Teacher(){ID="t0002", } } ,
                 new Subject() {id = 2 , Name = "Música" ,
                                         teacher = new Teacher(){ID="t0003", } } ,
                 new Subject() {id = 3 , Name = "Ciências",
                                         teacher = new Teacher(){ID="t0004", } } ,
                 new Subject() {id = 4 , Name = "Fisico-quimica",
                                         teacher = new Teacher(){ID="t0005", } } });
        }
    }
}
