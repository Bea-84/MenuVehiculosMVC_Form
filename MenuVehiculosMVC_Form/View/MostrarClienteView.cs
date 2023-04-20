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
    public partial class MostrarClienteView : Form
    {

        ClienteController clienteController; 
        public MostrarClienteView(object controlador)
        {
            InitializeComponent();
            clienteController=(ClienteController)controlador;
        }

        private void lbMostrarClientes_Click(object sender, EventArgs e)
        {
            //título
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //caja para mostrar clientes
            List<String> lista = clienteController.getlistaClientes();
            this.listBox1.DataSource = lista;  
        }

        private void lbBucarCliente_Click(object sender, EventArgs e)
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
        }

        private void btBuscar_Click(object sender, EventArgs e) 
        {
            String nombre = clienteController.getNombre(this.textBox1.Text);
            if (nombre.Equals(""))
            {
                this.lbBuscarCliente.Text = "El cliente no existe";
                this.listBox1.Items.Add(this.textBox1.Text);
            }
            else
            {
                this.lbBuscarCliente.Text = nombre;
                this.listBox1.Items.Add(this.textBox1.Text + " " + nombre);   
            }

            borrarDatos();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //boton salir 
            this.Dispose();
        }

        private void borrarDatos()
        {
            this.textBox1.Text = ""; 
        }
    }
}
