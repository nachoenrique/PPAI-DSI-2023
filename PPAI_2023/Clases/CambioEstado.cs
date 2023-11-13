using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
public class CambioEstado
    {
        private DateTime fechaHoraInicio;
        private Estado estado;

        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }


        public CambioEstado() { }

        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        internal Estado Estado { get => estado; set => estado = value; }

        public void getNombreEstado() { }

        public void getFechaHoraInicio() { }

        


    }
}
