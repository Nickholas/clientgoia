using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIServiceDemo
{

    static class Program
    {
        /// <summary>
        /// Declaramos las constantes Globales que necesitamos. En este caso se trata de la 
        /// dirección base donde se encuentran publicados los servicios WEB API de GOIA
        /// </summary>
        public static string WEB_API = "http://cooperativaws.goia.es";

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
