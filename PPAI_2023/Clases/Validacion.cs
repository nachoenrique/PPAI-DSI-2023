using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class Validacion
    {
        private List<string> audioMensajeValidacion; 
        private string nombre;
        private int nroOrden;
        private List<OpcionValidacion> listaOpcionValidacion;
        private TipoInformacion tipo; 

        public Validacion(List<string> audioMensajeValidacion, string nombre, int nroOrden, List<OpcionValidacion> listaOpcionValidacion, TipoInformacion tipo)
        {
            this.audioMensajeValidacion = audioMensajeValidacion;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.listaOpcionValidacion = listaOpcionValidacion;
            this.tipo = tipo;
        }

        public Validacion() { }

        public List<string> AudioMensajeValidacion { get => audioMensajeValidacion; set => audioMensajeValidacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        internal List<OpcionValidacion> ListaOpcionValidacion { get => listaOpcionValidacion; set => listaOpcionValidacion = value; }
        internal TipoInformacion Tipo { get => tipo; set => tipo = value; }

        public void getAudioMensajeValidacion() {
            
        }
        public List<string> getMensajeValidacion() {


            return audioMensajeValidacion;
        
        }
        public OpcionValidacion getPrimeraOpcion() { return listaOpcionValidacion[0]; }
    }
}
