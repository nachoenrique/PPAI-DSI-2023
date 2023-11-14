using PPAI_2023.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_2023.AccesoDatos
{
    public class BDCliente
    {
        public static Cliente GetCliente(int dni)
        {
            var cliente = new Cliente(-1, null, -1, null);
            string sentenciaSql = $"SELECT * FROM CLIENTES WHERE dni = \"{dni}\"";
            var tablaResultado = BDConnection.ReadData(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                cliente = MapearCliente(fila);
            }

            return cliente;
        }

        private static Cliente MapearCliente(DataRow fila)
        {
            int dni = Convert.ToInt32(fila["dni"].ToString());
            string nombre = fila["nombre_completo"].ToString();
            int tel = Convert.ToInt32(fila["nro_celular"].ToString());
            List<InformacionCliente> infs = BDInformacionCliente.getInfosCliente(dni);

            Cliente cli = new Cliente(dni, nombre, tel, infs);

            return cli;
        }
    }
}
