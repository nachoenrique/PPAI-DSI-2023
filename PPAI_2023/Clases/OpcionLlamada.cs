using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class OpcionLlamada
    {
        private string aundioMensaSubOpciones;
        private string mensajeSubOpciones;
        private string nombre;
        private int nroOrden;
        private List<SubOpcionLlamada> subOpcionLlamada;//0..*
        private List<Validacion> validacionesRequeridas;//0..*

        public OpcionLlamada(string aundioMensaSubOpciones, string mensajeSubOpciones, string nombre, int nroOrden, 
            List<SubOpcionLlamada> subOpcionLlamada, List<Validacion> validacionesRequeridas)
        {
            this.aundioMensaSubOpciones = aundioMensaSubOpciones;
            this.mensajeSubOpciones = mensajeSubOpciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.subOpcionLlamada = subOpcionLlamada;
            this.validacionesRequeridas = validacionesRequeridas;
        }

        public OpcionLlamada() { }

        public string AundioMensaSubOpciones { get => aundioMensaSubOpciones; set => aundioMensaSubOpciones = value; }
        public string MensajeSubOpciones { get => mensajeSubOpciones; set => mensajeSubOpciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        internal List<SubOpcionLlamada> SubOpcionLlamada { get => subOpcionLlamada; set => subOpcionLlamada = value; }
        internal List<Validacion> ValidacionesRequeridas { get => validacionesRequeridas; set => validacionesRequeridas = value; }
            
        public void getAudioMensajeSubOpciones(SubOpcionLlamada subOp) {
            subOp.getNombre();
        }
        public (string nombreOp, string nomSubOp) getDescripcionConSubOpcion(SubOpcionLlamada subOp) {

            string nombreOpcion = this.nombre;
            string nombreSubOpcion = subOp.getNombre();

            return (nombreOpcion, nombreSubOpcion);
        }
        public (List<List<string>>, List<string>) getValidaciones(SubOpcionLlamada subOp) {
            return subOp.getValidaciones();
        }

    }
}
