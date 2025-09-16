using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Persona
    {

        private int dni;
        public int DNI { 
            get
            {
                return dni;
            }
            set {

                /*2. Validar que el dni sea mayor a un millón y lanzar excepción especializada
                RangoDniIncorrectoException desde el setter de DNI.*/
                if (value <= 1000000)
                {
                    throw new RangoDniIncorrectoException();
                }
                dni = value; 
            }
        }

        public string Nombre { get; private set; }

        public Persona(int dni, string nombre) {
            this.DNI = dni;
            this.Nombre = nombre;
        }
    }
}
