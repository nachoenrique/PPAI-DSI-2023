using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_2023.AccesoDatos;
using PPAI_2023.Clases;

namespace PPAI_2023
{
 public class InterfazIVR
    {
        
        private Llamada llamadaActual;
        private CategoriaLlamada categoriaSeleccionada;
        private OpcionLlamada opcionSeleccionada;
        private SubOpcionLlamada subOpSeleccionada;
        private Cliente clienteLlamada;
        public GestorRegistarRespuesta gestor;
        
        
        
        private DateTime duracion;


        public InterfazIVR(PantallaRegistrarRespuesta pantalla)
        {

            gestor = new GestorRegistarRespuesta(pantalla);

            /*
            List<RespuestaCliente> listaRespuesta = new List<RespuestaCliente>();
            List<CambioEstado> listacambioEstado = new List<CambioEstado>();
            Accion accionRequerida = new Accion();
            
            //usuario
            Usuario operador = new Usuario();
            Usuario auditor = new Usuario();

            TipoInformacion tipoInfoInformacion = new TipoInformacion("fecha Nacimiento");
            OpcionValidacion opV = new OpcionValidacion();
            Validacion val = new Validacion();

            InformacionCliente infoFecha = new InformacionCliente("12 de Julio de 1983", tipoInfoInformacion,opV,val);
            InformacionCliente codigo = new InformacionCliente("5986", tipoInfoInformacion, opV, val);
            
            //cliente 
            List<InformacionCliente> listaInfoCliente = new List<InformacionCliente>();
            listaInfoCliente.Add(infoFecha);
            listaInfoCliente.Add(codigo);


            clienteLlamada = new Cliente(41232131, "Lionel Andres Messi", 15632023, listaInfoCliente );
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





            
            //Primera SubOpcion
            //tipoInfoValidacion
            TipoInformacion tipoInfoSub = new TipoInformacion("fecha Nacimiento");


            //OpcionesValidacionSubOpcion
            OpcionValidacion fecha1 = new OpcionValidacion(true, "12/08/1992");
            OpcionValidacion fecha2 = new OpcionValidacion(false, "02/10/1992");
            OpcionValidacion fecha3 = new OpcionValidacion(false, "24/03/1992");
            List<OpcionValidacion> listaOpcionesVal = new List<OpcionValidacion>(); //opciones validacion de fecha
            listaOpcionesVal.Add(fecha1);
            listaOpcionesVal.Add(fecha2);
            listaOpcionesVal.Add(fecha3);

            List<string> listaMensajesFechas = new List<string>();
            listaMensajesFechas.Add("12 de Julio de 1983");
            listaMensajesFechas.Add("12 de diciembre de 1983");
            listaMensajesFechas.Add("12 octubre de 1983");

            

            //Segunda SubOpcion

            TipoInformacion tipoInfoSub2 = new TipoInformacion("Codigo postal");


            OpcionValidacion codigo1 = new OpcionValidacion(false, "3663");
            OpcionValidacion codigo2 = new OpcionValidacion(false, "6060");
            OpcionValidacion codigo3 = new OpcionValidacion(true, "5986");
            List<OpcionValidacion> listaOpcionesVal2 = new List<OpcionValidacion>();//opciones validacion de codigo postal
            listaOpcionesVal.Add(codigo1);
            listaOpcionesVal.Add(codigo2);
            listaOpcionesVal.Add(codigo3);



            List<string> listaMensajesCodigo = new List<string>();
            listaMensajesCodigo.Add("3663");
            listaMensajesCodigo.Add("6060");
            listaMensajesCodigo.Add("5986");
            //ValidacionSubOpcion


            Validacion validacionSubOp = new Validacion(listaMensajesFechas, "Fecha de Nacimiento", 1, listaOpcionesVal, tipoInfoSub);
            Validacion validacionSubOp2 = new Validacion(listaMensajesCodigo, "Codigo Postal", 2, listaOpcionesVal2, tipoInfoSub2);

            List<Validacion> listaValidacionSub = new List<Validacion>();
            listaValidacionSub.Add(validacionSubOp); //cargo la valdiacion de fecha
            listaValidacionSub.Add(validacionSubOp2);//cargo la valdiacion de codigo postal


            //SUBOPCION
            subOpSeleccionada = new SubOpcionLlamada("No cuenta con los datos de la tarjeta",1, listaValidacionSub);

            List<SubOpcionLlamada> listaSubOpciones = new List<SubOpcionLlamada>();//todas las subopciones que hay por opcion
            listaSubOpciones.Add(subOpSeleccionada);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            




            //ValidacionOpcion
           
            // las traen las opciones y subopciones cuando las materializa la llamada
            List<Validacion> listaValidacionOpcion = new List<Validacion>();
            

            //OPCION
            // lo trae la llamada
            opcionSeleccionada = new OpcionLlamada("audoMensaje","mensaje","Solicitar tarjeta nueva",1,listaSubOpciones,listaValidacionOpcion);


            // estas las levanta directamente cuando materializa la categoria (abajo)
            List<OpcionLlamada> listaOpciones = new List<OpcionLlamada>();//todas las opciones que tiene la catgoria
            listaOpciones.Add(opcionSeleccionada);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            */

            //categoria
            //categoriaSeleccionada = new CategoriaLlamada("audio","mensaje","Robo",1,listaOpciones);//esta lista opciones esta vacia xq no la vamos a llamar ya que sabemos cual es la opcion seleccionada



            //llamada
            //int duracion = 150;
            //Iniciada estado = new Iniciada();
            //llamadaActual = new Llamada(15,"descripcion","detalle",duracion,"encuesta","observacion", listaRespuesta, listacambioEstado,accionRequerida,
            //estado, clienteLlamada, auditor, operador,subOpSeleccionada,opcionSeleccionada);


            categoriaSeleccionada = BDCategoria.GetCategoria(1);
            llamadaActual = BDLlamada.GetLlamada(15);

            //le paso la inforamcion al gestor
            gestor.nuevaRtaOperador(llamadaActual, categoriaSeleccionada, llamadaActual.OpcionSeleccionada, llamadaActual.SubOpcionSeleccionada);

        }
    }
}
