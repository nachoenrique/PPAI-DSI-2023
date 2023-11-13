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
            CambioEstado cmbioEstado = new CambioEstado(date,nvoEstado);
            llamada.agregar
        }
    }
}
