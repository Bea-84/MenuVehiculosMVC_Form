using MenuVehiculosMVC_Form.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuVehiculosMVC_Form.View
{
    public partial class MenuView : Form
    {
        MenuController menuController;
        public MenuView(object controlador)
        {
            InitializeComponent();
            menuController = (MenuController)controlador;
        }

        private void btaltaVehiculos_Click(object sender, EventArgs e)
        {
            menuController.altaVehiculos(); 
        }

        private void btAltaClientes_Click(object sender, EventArgs e)
        {
            menuController.altaClientes();
        }

        private void btMostrarVehiculos_Click(object sender, EventArgs e)
        {
            menuController.mostrarVehiculos();
        }

        private void btMostrarClientes_Click(object sender, EventArgs e)
        {
            menuController.mostrarClientes();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //botón salir menú
            this.Dispose(); 
        }
    }
}
