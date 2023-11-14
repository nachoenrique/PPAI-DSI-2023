using PPAI_2023.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class Iniciada : Estado
    {

        public Iniciada()
        {
            Nombre = "Iniciada";
        }


        public override Estado buscaEstadoActual()
        {
            Estado nvoEstado = new EnCurso();
            return nvoEstado;
        }

        public override void finalizar(DateTime date, Llamada llamada)
        {
            throw new NotImplementedException();
        }

        public override void tomadaPorOperador(DateTime date, Llamada llamada)
        {
            Estado nvoEstado = buscaEstadoActual();
            CambioEstado cambioEstado = new CambioEstado(date,nvoEstado);
            llamada.agregarCambioEstado(cambioEstado);
            llamada.setEstadoActual(nvoEstado);
            int idEstado;
            switch (nvoEstado.Nombre)
            {
                case "Iniciada": idEstado = 1; break;
                case "EnCurso": idEstado = 2; break;
                case "Cancelada": idEstado = 3; break;
                default: idEstado = 4; break;
            }
            BDLlamada.UpdateLlamada(llamada.getId(), idEstado, llamada.DescripcionOperador);
            BDCambioEstado.InsertCambioNuevo(idEstado, date, llamada.getId());
        }
    }
}
