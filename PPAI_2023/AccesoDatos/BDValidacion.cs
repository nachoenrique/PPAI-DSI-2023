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
    public class BDValidacion
    {
        public static List<Validacion> GetValidacionSubOpcion(int subOrden)
        {
            var validacion = new List<Validacion>();
            string sentenciaSql = $"SELECT * FROM VALIDACIONES WHERE sub_opcion = {subOrden}";
            var tablaResultado = BDConnection.ReadData(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var val = MapearValidacion(fila);
                validacion.Add(val);
            }

            return validacion;
        }

        public static List<Validacion> GetValidacionOpcion(int opcOrden)
        {
            var validacion = new List<Validacion>();
            string sentenciaSql = $"SELECT * FROM VALIDACIONES WHERE opcion = {opcOrden}";
            var tablaResultado = BDConnection.ReadData(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var val = MapearValidacion(fila);
                validacion.Add(val);
            }

            return validacion;
        }

        public static Validacion GetValidacion(int nroOrden)
        {
            var validacion = new Validacion();
            string sentenciaSql = $"SELECT * FROM VALIDACIONES WHERE nro_orden = {nroOrden}";
            var tablaResultado = BDConnection.ReadData(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                validacion = MapearValidacion(fila);
            }

            return validacion;
        }

        private static Validacion MapearValidacion(DataRow fila)
        {
            int nro = Convert.ToInt32(fila["nro_orden"].ToString());
            string nombre = fila["nombre"].ToString();
            List<string> audio = fila["audio_mensaje_validacion"].ToString().Split('-').ToList();
            List<OpcionValidacion> opcs = new List<OpcionValidacion>();
            bool prim = true;
            foreach (string s in audio)
            {
                if (prim) 
                {
                    opcs.Add(new OpcionValidacion(true, s));
                }
                else
                {
                    opcs.Add(new OpcionValidacion(false, s));
                }
                prim = false;
            }

            Validacion val = new Validacion(audio, nombre, nro, opcs, new TipoInformacion());

            return val;
        }
    }
}
