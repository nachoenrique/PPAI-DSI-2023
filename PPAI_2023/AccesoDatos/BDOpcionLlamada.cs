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
    public class BDOpcionLlamada
    {
        public static List<OpcionLlamada> GetOpcionesCat(int catOrden)
        {
            var opcs = new List<OpcionLlamada>();
            string sentenciaSql = $"SELECT * FROM OPCIONES_LLAMADA WHERE categoria_orden = {catOrden}";
            var tablaResultado = BDConnection.ReadData(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var op = MapearOpcion(fila);
                opcs.Add(op);
            }

            return opcs;
        }

        public static OpcionLlamada GetOpcionLlamada(int nroOrden)
        {
            var opc = new OpcionLlamada();
            string sentenciaSql = $"SELECT * FROM OPCIONES_LLAMADA WHERE nro_orden = {nroOrden}";
            var tablaResultado = BDConnection.ReadData(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                opc = MapearOpcion(fila);
            }

            return opc;
        }


        private static OpcionLlamada MapearOpcion(DataRow fila)
        {
            int nroOrden = Convert.ToInt32(fila["nro_orden"].ToString());
            string nombre = fila["nombre"].ToString();
            string mensaje = fila["mensaje_subopciones"].ToString();
            string audio = fila["audio_mensaje_subopciones"].ToString();
            List<Validacion> vals = BDValidacion.GetValidacionOpcion(nroOrden);
            List<SubOpcionLlamada> subs = BDSubOpcionLlamada.getSubDeOpcion(nroOrden);

            OpcionLlamada opc = new OpcionLlamada(audio, mensaje, nombre, nroOrden, subs, vals);

            return opc;
        }
    }
}
