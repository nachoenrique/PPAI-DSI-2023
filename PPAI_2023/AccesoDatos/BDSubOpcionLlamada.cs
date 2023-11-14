using PPAI_2023.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.AccesoDatos
{
    public class BDSubOpcionLlamada
    {
        public static List<SubOpcionLlamada> getSubDeOpcion(int opcOrden)
        {
            var subs = new List<SubOpcionLlamada>();
            string sentenciaSql = $"SELECT * FROM SUBOPCIONES_LLAMADA WHERE opcion_orden = {opcOrden}";
            var tablaResultado = BDConnection.ReadData(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var sub = MapearSubOpcion(fila);
                subs.Add(sub);
            }

            return subs;
        }
        public static SubOpcionLlamada GetSubOpcionLlamada(int nroOrden)
        {
            var sub = new SubOpcionLlamada();
            string sentenciaSql = $"SELECT * FROM SUBOPCIONES_LLAMADA WHERE nro_orden = {nroOrden}";
            var tablaResultado = BDConnection.ReadData(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                sub = MapearSubOpcion(fila);
            }

            return sub;
        }

        private static SubOpcionLlamada MapearSubOpcion(DataRow fila)
        {
            int nroOrden = Convert.ToInt32(fila["nro_orden"].ToString());
            string nombre = fila["nombre"].ToString();
            List<Validacion> vals = BDValidacion.GetValidacionSubOpcion(nroOrden);

            SubOpcionLlamada subop = new SubOpcionLlamada(nombre, nroOrden, vals);

            return subop;
        }
    }
}
