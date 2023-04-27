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
    public partial class AltaVehiculoView : Form
    {

        VehiculoController vehiculoController;

        public AltaVehiculoView(object controlador)
        {
            InitializeComponent();
            vehiculoController = (VehiculoController)controlador;
        }
        //---------------------------------------------------------------------------------------------------
        private void lbMatricula_Click(object sender, EventArgs e)
        {
            //nombre matricula para todos
        }

        private void textBoxMatri_TextChanged(object sender, EventArgs e)
        {
            //box matricula
            String matricula = "";
            this.lbMensaje.Visible = false;
            matricula = vehiculoController.getDatosVehiculo(this.textBoxMatri.Text);
            if (!matricula.Equals(""))
            {
                this.lbMensaje.Text = "La matricula ya existe: " + matricula; 
                this.lbMensaje.Visible = true;
            } 
        }  
        private void lbMarca_Click(object sender, EventArgs e) 
        {
            //nombre marca para todos
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //box marca
        }

        private void lbModelo_Click(object sender, EventArgs e)
        {
            //nombre modelo para todos 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //box modelo
        }
        //---------------------------------------------------------------------------------------------------

        private void btCoche_Click(object sender, EventArgs e)
        {
            //boton coche
            this.pnCoche.Visible = true;
            this.pnMoto.Visible=false;
            this.pnCamion.Visible=false;
        } 
        private void btCancelar_Click(object sender, EventArgs e)
        {
            //boton cancelar coche
            borrarDatos();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            //boton aceptar coche
            Hashtable vehiculoHash=new Hashtable();
           

            if (this.textBoxMatri.Text != "" && this.textBoxMatri.Text != "") 
            {
                vehiculoHash.Add("Matricula", this.textBoxMatri.Text);
                vehiculoHash.Add("Marca", this.textBox1.Text);
                vehiculoHash.Add("Modelo", this.textBox2.Text);
                vehiculoHash.Add("Puertas",this.txPuertas.Text);
                vehiculoHash.Add("Plazas", this.txPlazas.Text); 
                vehiculoController.altaCoche(vehiculoHash);
                this.lbaltaveh.Text = "Alta vehiculo completada";
                this.lbaltaveh.Visible = true;
                
            }
            else
            {
                this.lbMensaje.Text = "No hay datos";
                this.lbMensaje.Visible = true;
            }

            borrarDatos(); 

        }

        private void txPuertas_TextChanged(object sender, EventArgs e)
        {
            //box puertas
        }

        private void txPlazas_TextChanged(object sender, EventArgs e)
        {
            //box plazas
        }

        //-------------------------------------------------------------------------------------------------

        private void btMoto_Click(object sender, EventArgs e)
        {
            //boton moto
            this.pnCoche.Visible = false;
            this.pnMoto.Visible = true;
            this.pnCamion.Visible = false;
        }

        private void btAceptarMoto_Click(object sender, EventArgs e)
        {
            //aceptar moto
            Hashtable vehiculoHash=new Hashtable();
            

            if (this.textBoxMatri.Text != "" && this.textBoxMatri.Text != "")
            {
                vehiculoHash.Add("Matricula", this.textBoxMatri.Text);
                vehiculoHash.Add("Marca", this.textBox1.Text);
                vehiculoHash.Add("Modelo", this.textBox2.Text);
                vehiculoHash.Add("cc",this.textBoxCC.Text); 
                vehiculoController.altaMoto(vehiculoHash);
                this.lbaltaveh.Text = "Alta vehiculo completada";
                this.lbaltaveh.Visible = true;
                
            }
            else
            {
                this.lbMensaje.Text = "No hay datos";
                this.lbMensaje.Visible = true;
            }

            borrarDatos(); 
        }

        private void btCancelarMoto_Click(object sender, EventArgs e)
        {
            //cancelar moto
            borrarDatos();
        }

        private void textBoxCC_TextChanged(object sender, EventArgs e)
        {
            //box cc
        } 
        //---------------------------------------------------------------------------------------------------

        private void btCamion_Click(object sender, EventArgs e)
        {
            //boton camión
            this.pnCamion.Visible = true; 
            this.pnMoto.Visible = false;
            this.pnCoche.Visible=false;

        }

        private void btAceptarCamion_Click(object sender, EventArgs e) 
        {
            //aceptar camion
            Hashtable vehiculoHash=new Hashtable();
         

            if (this.textBoxMatri.Text != "" && this.textBoxMatri.Text != "")
            {
                vehiculoHash.Add("Matricula", this.textBoxMatri.Text);
                vehiculoHash.Add("Marca", this.textBox1.Text);
                vehiculoHash.Add("Modelo", this.textBox2.Text);
                vehiculoHash.Add("kg", this.textBoxKG.Text);
                vehiculoController.altaCamion(vehiculoHash);
                this.lbaltaveh.Text = "Alta vehiculo completada"; 
                this.lbaltaveh.Visible = true;
               
            }
            else
            {
                this.lbMensaje.Text = "No hay datos";
                this.lbMensaje.Visible = true;
            }

            borrarDatos();

        }

        private void btAceptarKg_Click(object sender, EventArgs e)
        {
            //cancelar camion 
            borrarDatos();
        } 
        private void textBoxKG_TextChanged(object sender, EventArgs e)
        {
            //box KG
        }

        //------------------------------------------------------------------------------------------------------

        private void btSalir_Click(object sender, EventArgs e)
        {
            //boton salir para todos
            this.Dispose(); 
        } 
        private void lbMensaje_Click(object sender, EventArgs e)
        {
            //mensaje vehiculo no disponible
            this.lbMensaje.Visible = false;
        } 
        private void borrarDatos()
        {
            this.textBoxMatri.Text = "";
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.txPuertas.Text = "";
            this.txPlazas.Text = "";
            this.textBoxCC.Text = "";
            this.textBoxKG.Text = "";
            this.lbMensaje.Visible = false; 
            
        }

        private void lbaltaveh_Click(object sender, EventArgs e)
        {
            //mensaje alta vahiculo completada 
        }
    }
}
