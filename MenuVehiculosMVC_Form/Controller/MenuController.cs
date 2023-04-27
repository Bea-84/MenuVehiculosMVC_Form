using MenuVehiculosMVC_Form.Model;
using MenuVehiculosMVC_Form.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuVehiculosMVC_Form.Controller
{
    internal class MenuController
    {
        public Datos datos;

        public MenuController(Datos pDatos)
        {
            datos = pDatos; 
        } 

        //métodos menú

        public void altaClientes()
        {
            ClienteController clienteController=new ClienteController(datos);

            lbaltaClienteCompletada clienteview = new lbaltaClienteCompletada(clienteController);

            clienteview.Show();
        }

        public void mostrarClientes()
        {
            ClienteController clienteController = new ClienteController(datos);

            MostrarClienteView clienteView = new MostrarClienteView(clienteController);

            clienteView.Show();
        }

        //-------------------------------------------------------------------------------------------------

        public void altaVehiculos()
        {
            VehiculoController vehiculoController =new VehiculoController(datos);   

            AltaVehiculoView vehiculoView=new AltaVehiculoView(vehiculoController);

            vehiculoView.Show(); 
        }

        public void mostrarVehiculos()
        {
            VehiculoController vehiculoController=new VehiculoController(datos);

            MostrarVehiculoView vehiculoView=new MostrarVehiculoView(vehiculoController);

            vehiculoView.Show();
        }



   
    }
}
