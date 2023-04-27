using MenuVehiculosMVC_Form.Controller;
using System;
using System.Collections;
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
    public partial class AltaClienteView : Form
    {
        ClienteController clienteController;

        public AltaClienteView(Object controlador)
        {
            InitializeComponent();
            clienteController = (ClienteController)controlador;
        } 
        private void lbAltaClientes_Click(object sender, EventArgs e)
        {
            //título 
        }

        private void lbNif_Click(object sender, EventArgs e)
        {
            //nif
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //box nif
            String nombre = "";
            this.lbMensaje.Visible = false;
            nombre = clienteController.getNombre(this.textBox1.Text);
            if (!nombre.Equals(""))
            {
                this.lbMensaje.Text = "El cliente ya existe: " + nombre;
                this.lbMensaje.Visible = true;
            }  
        }

        private void lbNombre_Click(object sender, EventArgs e)
        {
           //nombre
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           //box nombre
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Hashtable clienteHash = new Hashtable();

            if (this.textBox1.Text != "" && this.textBox1.Text != "")
            {
                clienteHash.Add("Nif", this.textBox1.Text);
                clienteHash.Add("Nombre", this.textBox2.Text);
                clienteController.altaCliente(clienteHash); 
                this.lbaltaCliente.Visible = true;  
            } 
            else
            {
                this.lbMensaje.Text = "No hay datos";
                this.lbMensaje.Visible = true; 
            } 

            borrarDatos();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            borrarDatos();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();  
        }

        private void borrarDatos()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.lbMensaje.Visible = false; 
        } 

        private void lbMensaje_Click(object sender, EventArgs e)
        {
            //mensaje que muestra si existe cliente
        }
    }
}
