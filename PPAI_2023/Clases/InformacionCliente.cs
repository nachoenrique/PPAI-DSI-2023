using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class InformacionCliente
    {
        private string datoAValidar;
        private TipoInformacion tipo;
        private OpcionValidacion opcionCorrecta;
        private Validacion validacion;

        public InformacionCliente(string datoAValidar, TipoInformacion tipo, OpcionValidacion opcionCorrecta, Validacion validacion)
        {
            this.datoAValidar = datoAValidar;
            this.tipo = tipo;
            this.opcionCorrecta = opcionCorrecta;
            this.validacion = validacion;
        }

        public string DatoAValidar { get => datoAValidar; set => datoAValidar = value; }
        internal TipoInformacion Tipo { get => tipo; set => tipo = value; }
        internal OpcionValidacion OpcionCorrecta { get => opcionCorrecta; set => opcionCorrecta = value; }
        internal Validacion Validacion { get => validacion; set => validacion = value; }

        public void esInformacionCorrecta() { 
        
        
        }
        public void esValidacion() { }
    }
}
