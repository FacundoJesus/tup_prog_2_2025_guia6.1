using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class DepartamentoVehicular
    {
        public int CantidadRegistros { 
            get
            {
                if(registros.Count  == 0)
                {
                    throw new VerRegistroException();
                }
                return registros.Count;
            }
        }

        private int serie;

        private List <RegistroVehiculo> registros = new List<RegistroVehiculo>();

        public RegistroVehiculo RegistrarVehiculo(Persona propietario, string patente)
        {
            RegistroVehiculo nuevoRegistro = new RegistroVehiculo(patente, propietario, serie++);
            registros.Add(nuevoRegistro);
            OrdenarVehiculosPorPatente();
            return nuevoRegistro;
        }

        public RegistroVehiculo VerRegistro(int idx)
        {
            RegistroVehiculo registro = null;
            if(idx >= 0 && idx < CantidadRegistros) {
                registro =  registros[idx];
            }
            return registro;
        }

        private void OrdenarVehiculosPorPatente()
        {
            registros.Sort();
        }
    }
}
