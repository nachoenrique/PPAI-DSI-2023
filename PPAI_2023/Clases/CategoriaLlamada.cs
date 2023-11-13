using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
 public class CategoriaLlamada
    {
        private string audioMensajeOpciones;
        private string mensajesOpciones;
        private string nombre;
        private int nroOrden;
        private List<OpcionLlamada> opcion;//1..*

        public CategoriaLlamada(string audioMensajeOpciones, string mensajesOpciones, string nombre, int nroOrden, List<OpcionLlamada> opcion)
        {
            this.audioMensajeOpciones = audioMensajeOpciones;
            this.mensajesOpciones = mensajesOpciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.opcion = opcion;
        }

        public CategoriaLlamada() { }

        public string AudioMensajeOpciones { get => audioMensajeOpciones; set => audioMensajeOpciones = value; }
        public string MensajesOpciones { get => mensajesOpciones; set => mensajesOpciones = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        internal List<OpcionLlamada> Opcion { get => opcion; set => opcion = value; }

        public void getAudioMensajeOpciones() { }
        
        public (string nomCat, string nomOp, string nomSub) getDescripcionCategoriaYOpcion(OpcionLlamada opSelecionada, SubOpcionLlamada subOpseleccionada ) {
            opSelecionada.getAudioMensajeSubOpciones(subOpseleccionada);
            
            (string nombreOp, string nomSubOp) = opSelecionada.getDescripcionConSubOpcion(subOpseleccionada);

            return (this.nombre, nombreOp, nomSubOp);

            
        }
            
        public (List<List<string>>, List<string>) getValidaciones(OpcionLlamada opSelecionada, SubOpcionLlamada subOpseleccionada) {


            return opSelecionada.getValidaciones(subOpseleccionada);
        }
    }
}
