using PPAI_2023.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.AccesoDatos
{
    public class BDCambioEstado
    {

        public static List<CambioEstado> GetCambiosLlamada(int id)
        {
            var cams = new List<CambioEstado>();
            string sentenciaSql = $"SELECT * FROM CAMBIOS_ESTADO WHERE llamada = {id}";
            var tablaResultado = BDConnection.ReadData(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var cam = MapearCambioEstado(fila);
                cams.Add(cam);
            }

            return cams;
        }

        private static CambioEstado MapearCambioEstado(DataRow fila)
        {

            Estado estado = BDEstado.getEstadoLlamada(Convert.ToInt32(fila["estado"].ToString()));
            DateTime fechaHoraInicio = Convert.ToDateTime(fila["fecha_hora_inicio"].ToString());

            CambioEstado cam = new CambioEstado(fechaHoraInicio, estado);

            return cam;
        }
    }
}
