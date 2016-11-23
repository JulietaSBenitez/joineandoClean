using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.src
{
    class ValidacionBooleana<T>
    {
        private string ErrorMsg { get; set; }
        private Predicate<T> Lambda { get; set; }

        public ValidacionBooleana(Predicate<T> lambda, string error)
        {
            ErrorMsg = error;
            Lambda = lambda;

        }

        public bool SeCumple(T objeto)
        {
            return Lambda(objeto);
        }
        public bool NoSeCumple(T objeto)
        {
            return !SeCumple(objeto);
        }

        public string MensajeError()
        {
            return ErrorMsg;
        }
    }
}
