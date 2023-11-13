using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.Clases
{
    public class Cancelada : Estado
    {
        public override Estado buscaEstadoActual()
        {
            throw new NotImplementedException();
        }

        public override void finalizar(DateTime date, Llamada llamada)
        {
            throw new NotImplementedException();
        }

        public override void tomadaPorOperador(DateTime date, Llamada llamada)
        {
            throw new NotImplementedException();
        }
    }
}
