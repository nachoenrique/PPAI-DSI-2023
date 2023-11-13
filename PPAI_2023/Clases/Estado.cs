using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class Estado
    {
        private string nombre;

        public Estado(string nombre)
        {
            this.nombre = nombre;
        }

        public Estado() { }

        public string Nombre { get => nombre; set => nombre = value; }

        public bool esFinalizada() {
            bool resultado = false;

            if (nombre == "Finalizada")
            {
                resultado = true;
            }

            return resultado;
        }
        public void esIniciada() { }
        public bool esEnCurso() {
            bool resultado = false;

            if (nombre == "EnCurso")
            {
                resultado = true;
            }

            return resultado;
        }

        //ALTERNATIVAS
        public bool esCancelada()
        {
            bool resultado = false;

            if (nombre == "Cancelada")
            {
                resultado = true;
            }

            return resultado;
        }



    }
}
