using PPAI_2023.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.AccesoDatos
{
    public class BDLlamada
    {
        public static Llamada GetLlamada(int id)
        {
            var llamada = new Llamada();
            string sentenciaSql = $"SELECT * FROM LLAMADAS WHERE id = {id}";
            var tablaResultado = BDConnection.ReadData(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                llamada = MapearLlamada(fila);
            }

            return llamada;
        }

        private static Llamada MapearLlamada(DataRow fila)
        {
            int id = Convert.ToInt32(fila["id"].ToString());
            string descOp = fila["descripcion_operador"].ToString();
            string detalle = fila["detalle_accion_requerida"].ToString();
            string encuesta = fila["encuesta_enviada"].ToString();
            string obsAu = fila["observacion_auditor"].ToString();
            int duracion = Convert.ToInt32(fila["duracion"].ToString());
            OpcionLlamada opc = BDOpcionLlamada.GetOpcionLlamada(Convert.ToInt32(fila["opcion_seleccionada"]));
            SubOpcionLlamada sub = BDSubOpcionLlamada.GetSubOpcionLlamada(Convert.ToInt32(fila["subopcion_seleccionada"]));
            Cliente cliente = BDCliente.GetCliente((int)Convert.ToInt64(fila["cliente"]));
            Estado estado = BDEstado.getEstadoLlamada(Convert.ToInt32(fila["estado"]));
            List<CambioEstado> cambios = BDCambioEstado.GetCambiosLlamada(id);

            Llamada llamada = new Llamada(id, descOp, detalle, duracion, encuesta, obsAu, null, cambios, 
                new Accion(), estado, cliente, new Usuario(), new Usuario(), sub, opc);

            return llamada;
        }
    }
}
