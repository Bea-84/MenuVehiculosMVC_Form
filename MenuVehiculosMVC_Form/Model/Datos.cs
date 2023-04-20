using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuVehiculosMVC_Form.Model
{
    internal class Datos
    {

        private List<Vehiculo> vehiculos;
        private List<Cliente> clientes;

        public Datos()
        {
            vehiculos = new List<Vehiculo>();
            clientes = new List<Cliente>();
        }

        //métodos cliente

        public void addCliente(Hashtable clienteHas)
        {
            Cliente cliente = new Cliente();
            cliente.Nif = (string)clienteHas["Nif"];
            cliente.Nombre = (string)clienteHas["Nombre"];
            clientes.Add(cliente);
        }

        public List<string> listaClientes()
        {
            List<string> listaClientes = new List<string>();

            foreach (Cliente cliente in clientes)
            {
                listaClientes.Add(cliente.ToString());
            }
            return listaClientes;
        }

        public string getNombreClienteByNif(string nif)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Nif.Equals(nif))
                {
                    return cliente.Nombre;
                }
            }
            return "";
        }

        //------------------------------------------------------------------------------------------------

        //métodos vehículos

        public void addCoche(Hashtable vehiculoHash) 
        {
            Coche coche = new Coche();
            coche.Matricula = (string)vehiculoHash["Matricula"];
            coche.Marca = (string)vehiculoHash["Marca"];
            coche.Model = (string)vehiculoHash["Modelo"];
            coche.Puertas = int.Parse((string)vehiculoHash["Puertas"]);
            coche.Plazas = int.Parse((string)vehiculoHash["Plazas"]);
            vehiculos.Add(coche);
        }
        public void addMoto(Hashtable vehiculoHash)
        {
            Moto moto = new Moto();
            moto.Matricula = (string)vehiculoHash["Matricula"];
            moto.Marca = (string)vehiculoHash["Marca"];
            moto.Model = (string)vehiculoHash["Modelo"];
            moto.Cc = int.Parse((string)vehiculoHash["cc"]);

            vehiculos.Add(moto);
        }
        public void addCamion(Hashtable vehiculoHash) 
        {
            Camion camion = new Camion();
            camion.Matricula = (string)vehiculoHash["Matricula"];
            camion.Marca = (string)vehiculoHash["Marca"];
            camion.Model = (string)vehiculoHash["Modelo"];
            camion.Kg = int.Parse((string)vehiculoHash["kg"]);  

            vehiculos.Add(camion);
        } 

        public string getDatosVehiculo(string matricula)
        {
            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.Matricula.Equals(matricula))
                {
                    return vehiculo.ToString();
                }
            }
            return "";
        }

        public List<string> listaVehiculos()
        {

            List<string> listaVehiculos = new List<string>();
            foreach (Vehiculo veh in vehiculos)
            {
                listaVehiculos.Add(veh.Matricula + "\t" + veh.Marca + "\t" + veh.Model + "\t" + veh.GetType().Name);
            }
            return listaVehiculos;
        } 
    }
}
