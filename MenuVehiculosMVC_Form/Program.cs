using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuVehiculosMVC_Form.Controller;

namespace MenuVehiculosMVC_Form
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controller.Controller controlador = new Controller.Controller();
            controlador.gestionMenu();
        }
    }
}
