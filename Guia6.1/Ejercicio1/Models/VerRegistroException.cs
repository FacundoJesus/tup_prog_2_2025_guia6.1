using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class VerRegistroException:ApplicationException
    {
        public VerRegistroException():base("No hay Registros. Debes por lo menos ingresar un Registro.") { }
        public VerRegistroException(string message):base(message) { }
        public VerRegistroException(string message, Exception innerException):base(message, innerException) { }
    }
}
