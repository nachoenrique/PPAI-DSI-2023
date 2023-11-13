using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
public class Cliente
    {
        private int dni;
        private string nombreCompleto;
        private int nroCelular;
        private List<InformacionCliente> info;//1..*
        

        public Cliente(int dni, string nombreCompleto, int nroCelular, List<InformacionCliente> info)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.nroCelular = nroCelular;
            this.info = info;
        }

        public Cliente() { }

        public int Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int NroCelular { get => nroCelular; set => nroCelular = value; }
        internal List<InformacionCliente> Info { get => info; set => info = value; }

        public void esCliente() { }
        public string getNombre() {
            return nombreCompleto;
        }

        public bool esInformacionCorrecta(string res) {
            bool resultado = false;
            for (int i = 0; i < info.Count; i++)
            {
                if (info[i].DatoAValidar == res)
                {
                    resultado = true;
                }
            }


            return resultado;

            
            
        }
    }
}
