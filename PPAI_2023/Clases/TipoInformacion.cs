using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class TipoInformacion
    {
        private string descripcion;

        public TipoInformacion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public TipoInformacion() { }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public void getDescripcion() { }
        public void setDescripcion() { }
    }
}
