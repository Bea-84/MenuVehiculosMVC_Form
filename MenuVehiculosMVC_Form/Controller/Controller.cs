using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuVehiculosMVC_Form.Model;
using MenuVehiculosMVC_Form.View;
using System.Collections;
using MenuVehiculosMVC_Form;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuVehiculosMVC_Form.Controller
{
    internal class Controller
    {
        Datos datos;
     
        public Controller(Datos datos)
        {
            this.datos = datos;

        }
        public Controller()
        {
            datos = new Datos();

        }

        public void gestionMenu()
        {
            MenuController menuController = new MenuController(datos);
            MenuView menu = new MenuView(menuController);
            Application.Run(menu); 
        }
    }
}
