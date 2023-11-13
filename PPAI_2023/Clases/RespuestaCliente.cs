using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class RespuestaCliente
    {
        private DateTime fechaEncuesta;
        private RespuestaPosible respuestaSeleccionada;

        public DateTime FechaEncuesta { get => fechaEncuesta; set => fechaEncuesta = value; }
        internal RespuestaPosible RespuestaSeleccionada { get => respuestaSeleccionada; set => respuestaSeleccionada = value; }

        public void getDescripcionRta() { }
    }
}
