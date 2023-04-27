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
    public partial class MostrarVehiculoView : Form
    {

        VehiculoController vehiculoController;
        public MostrarVehiculoView(object controlador) 
        {
            InitializeComponent();
            vehiculoController = (VehiculoController)controlador;
        }

        private void listBoxVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //list box vehiculos
            List<String> lista = vehiculoController.getlistaVehiculos(); 
           

        }

        private void textBoxmatricula_TextChanged(object sender, EventArgs e)
        {
            //box matricula
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            //botón buscar 
            String matricula = vehiculoController.getDatosVehiculo(this.textBoxmatricula.Text);
            if (matricula.Equals(""))
            {
                this.lbBuscarVehiculo.Text = "El vehiculo no existe"; 
                
            }
            else
            {
                this.lbBuscarVehiculo.Text = matricula; 
                this.listBoxVehiculos.Items.Add( matricula);
            }

            borrarDatos(); 

        }

        private void lbBuscarVehiculo_Click(object sender, EventArgs e) 
        {
            //lbBuscar vehiculo 
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //boton salir 
            this.Dispose();
        }

        private void borrarDatos()
        {
            this.textBoxmatricula.Text = ""; 
        } 


    }
}
