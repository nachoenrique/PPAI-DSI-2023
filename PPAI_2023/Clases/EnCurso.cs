using PPAI_2023.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class EnCurso : Estado
    {
        public EnCurso()
        {
            Nombre = "EnCurso";
        }
        public override Estado buscaEstadoActual()
        {
            Estado nuevo = new Finalizada();
            return nuevo;
        }

        public override void finalizar(DateTime date, Llamada llamada)
        {
            Estado nuevoE = buscaEstadoActual(); 
            CambioEstado nvoCE = new CambioEstado(date,nuevoE);
            llamada.agregarCambioEstado(nvoCE);
            llamada.setEstadoActual(nuevoE);
            int idEstado;
            switch (nuevoE.Nombre)
            {
                case "Iniciada": idEstado = 1; break;
                case "EnCurso": idEstado = 2; break;
                case "Cancelada": idEstado = 3; break;
                default: idEstado = 4; break;
            }
            BDLlamada.UpdateLlamada(llamada.getId(), idEstado, llamada.DescripcionOperador);
            BDCambioEstado.InsertCambioNuevo(idEstado, date, llamada.getId());
        }

        public override void tomadaPorOperador(DateTime date, Llamada llamada)
        {
            throw new NotImplementedException();

        }
    }
}
