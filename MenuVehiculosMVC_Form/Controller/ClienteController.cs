using MenuVehiculosMVC_Form.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuVehiculosMVC_Form.Controller
{
    internal class ClienteController
    {
        Datos datos;

        public ClienteController(Datos pDatos)
        {
            datos = pDatos;
        }

        //métodos cliente controller

        public void altaCliente(Hashtable clienteHash)
        {
            datos.addCliente(clienteHash);
        }
        public string getNombre(string nif)
        {
            string nombre = datos.getNombreClienteByNif(nif);
            return nombre;
        }
        public List<String> getlistaClientes()
        {
            return datos.listaClientes(); 
        }
    }
}
