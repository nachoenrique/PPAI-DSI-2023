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
        }

        public override void tomadaPorOperador(DateTime date, Llamada llamada)
        {
            throw new NotImplementedException();

        }
    }
}
