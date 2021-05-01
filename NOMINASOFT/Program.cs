using Capa._4_Persistencia.ADO_MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOMINASOFT
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GestorMySQL instance = new GestorMySQL();
            instance.AbrirConexion();
            Application.Run(new Form1());
        }
    }
}
