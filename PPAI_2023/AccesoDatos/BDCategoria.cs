using PPAI_2023.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.AccesoDatos
{
    public class BDCategoria
    {

        private static CategoriaLlamada MapearCategoria(DataRow fila)
        {
            int nroOrden = Convert.ToInt32(fila["nro_orden"].ToString());
            string nombre = fila["nombre"].ToString();
            string mensaje = fila["mensaje_opciones"].ToString();
            string audio = fila["mensaje_opciones"].ToString();
            List<OpcionLlamada> opcs = BDOpcionLlamada.GetOpcionesCat(nroOrden);

            CategoriaLlamada cat = new CategoriaLlamada(audio, mensaje, nombre, nroOrden, opcs);

            return cat;
        }
    }
}
