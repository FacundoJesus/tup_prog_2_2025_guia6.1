using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class RangoDniIncorrectoException:ApplicationException
    {
        public RangoDniIncorrectoException():base("DNI Incorrecto. Debe ser mayor a 1.000.000") { }
        public RangoDniIncorrectoException(string message) : base(message) { }
        public RangoDniIncorrectoException(string message, Exception innerException) : base(message, innerException) { }
    }
}
