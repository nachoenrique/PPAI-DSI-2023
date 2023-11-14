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
    public class BDEstado
    {



        public static Estado getEstadoLlamada(int id)
        {
            switch (id)
            {
                case (1):
                    { return new Iniciada(); }

                case (2):
                    { return new EnCurso(); }

                case (3):
                    { return new Cancelada(); }

                default: { return new Finalizada(); }
            }
        }
    }
}