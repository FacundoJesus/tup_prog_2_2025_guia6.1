using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class RegistroVehiculo : IComparable
    {

        public string Patente { get; set; }

        public string Serie { get; set; }

        public Persona Propietario { get; set; }

        public RegistroVehiculo(string patente, Persona propietario, int serie)
        {
            this.Patente = patente;
            this.Propietario = propietario;
            this.Serie = Convert.ToString(serie);

            //1. Realizar la validación y lanzamiento de la excepción en el constructor de RegistroVehiculo.
            Regex regex = new Regex(@"^[A-Z]{3}\s*[0-9]{3}$",RegexOptions.IgnoreCase);
            Match matchPatente = regex.Match(patente);
            if (matchPatente.Success == false)
            {
                throw new FormatoPatenteNoValidaException();
            }
        }

        public int CompareTo(object obj)
        {
            RegistroVehiculo nuevoRegistro = obj as RegistroVehiculo;
            if(nuevoRegistro != null ) {
                return this.Patente.CompareTo(nuevoRegistro.Patente);
            }
            return -1;

        }

        public override string ToString()
        {
            return $"Patente: {this.Patente} - Propietario: {this.Propietario.Nombre} ({this.Propietario.DNI}) ";
        }
    }
}
