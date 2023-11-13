using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class Encuesta
    {
        private string descripcion;
        private DateTime fechaFinVigencia;
        private List<Pregunta> pregunta;//1..*

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaFinVigencia { get => fechaFinVigencia; set => fechaFinVigencia = value; }
        internal List<Pregunta> Pregunta { get => pregunta; set => pregunta = value; }

        public void armarEncuesta() { }
        public void esVigente() { }
        public void getDescripcionEncuesta() { }
    }
}
