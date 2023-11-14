using PPAI_2023.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.AccesoDatos
{
    public class BDInformacionCliente
    {

        public static List<InformacionCliente> getInfosCliente(int dni)
        {
            var infos = new List<InformacionCliente>();
            string sentenciaSql = $"SELECT * FROM INFORMACION_CLIENTE WHERE dni_cliente = {dni}";
            var tablaResultado = BDConnection.ReadData(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var inf = MapearInfoCliente(fila);
                infos.Add(inf);
            }

            return infos;
        }

        private static InformacionCliente MapearInfoCliente(DataRow fila)
        {
            string datoAValidar = fila["dato_a_validar"].ToString();
            Validacion val = BDValidacion.GetValidacion(Convert.ToInt32(fila["validacion"].ToString()));
            OpcionValidacion correcta = val.getPrimeraOpcion();


            InformacionCliente info = new InformacionCliente(datoAValidar, new TipoInformacion("Tipo de informacion generica"), correcta, val);

            return info;
        }
    }
}
