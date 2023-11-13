using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class Pregunta
    {
        private string preguntaEncuesta;
        private List<RespuestaPosible> respuesta;

        public string PreguntaEncuesta { get => preguntaEncuesta; set => preguntaEncuesta = value; }
        internal List<RespuestaPosible> Respuesta { get => respuesta; set => respuesta = value; }

        public void getDescripcion() { }
        public void listarRespuestasPosibles() { }

    }
}
