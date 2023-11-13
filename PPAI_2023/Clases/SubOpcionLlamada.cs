using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class SubOpcionLlamada
    {
        private string nombre;
        private int nroOrden;
        private List<Validacion> validacionRequerida;//0..*

        public SubOpcionLlamada(string nombre, int nroOrden, List<Validacion> validacionRequerida)
        {
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.validacionRequerida = validacionRequerida;
        }

        public SubOpcionLlamada() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        internal List<Validacion> ValidacionRequerida { get => validacionRequerida; set => validacionRequerida = value; }

        public void esNro() { }
        public string getNombre() {
            return nombre;
        }

        public (List<List<string>>, List<string>) getValidaciones()
        {
            List<List<string>> audios = new List<List<string>>();
            List<string> nombres = new List<string>();
            

            foreach (var validacion in validacionRequerida)
            {
                audios.Add(validacion.getMensajeValidacion());
                nombres.Add(validacion.Nombre);
                        
            }


            return (audios, nombres);
        }
    }
}
