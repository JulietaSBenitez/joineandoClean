using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.src
{
    public static class Extensiones
    {
        public static string NullIfEmpty(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) { return null; }
            return value;
        }
    }
}