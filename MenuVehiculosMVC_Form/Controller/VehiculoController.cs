using MenuVehiculosMVC_Form.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuVehiculosMVC_Form.Controller
{
    internal class VehiculoController
    {
        Datos datos;
        public VehiculoController(Datos pDatos)
        {
            datos = pDatos; 
        }

        //métodos vehiculo controller 

        public string getDatosVehiculo(string matricula)
        {
            string datosVehiculo;
            datosVehiculo = datos.getDatosVehiculo(matricula);
            return datosVehiculo;  
        }
        public List<String> getlistaVehiculos()
        {
            return datos.listaVehiculos(); 
        } 

        public void altaCoche(Hashtable vehiculoHash)
        {
            datos.addCoche(vehiculoHash); 
        }

        public void altaMoto(Hashtable vehiculoHas)
        {
            datos.addMoto(vehiculoHas);
        }

        public void altaCamion(Hashtable vehiculoHash)
        {
            datos.addCamion(vehiculoHash);
        }
    }
}
