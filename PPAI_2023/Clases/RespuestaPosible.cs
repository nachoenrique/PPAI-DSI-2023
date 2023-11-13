using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class RespuestaPosible
    {
        private string descripcion;
        private string valor;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Valor { get => valor; set => valor = value; }

        public void getDescripcionRta() { }
    }
}
