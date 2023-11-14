using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_2023.Clases;

namespace PPAI_2023
{
public class GestorRegistarRespuesta
    {
        private PantallaRegistrarRespuesta pantallaRegistarRespuesta;
        

        private Llamada llamadaActual;
        private CategoriaLlamada categoriaLlamadaActual;
        private OpcionLlamada opcionLlamadaActual;
        private SubOpcionLlamada subOpcionLlamadaActual;
        
        private Estado estadoEnCurso;
        private Estado estadoFinalizado;
        private Estado estadoCancelado;
        private List<Validacion> mensajesValidacion;
        private OpcionValidacion opcionDeValidacionSeleccionada;
        private List<RespuestaCliente> respuestaSeleccionadas;
        private int duracionLlmada;
        private DateTime fechaHoraActual;
        private string nombreCliente;
        private List<Estado> listaEstados;
        private List<Validacion> listaValidacion;
        private string descripcion;
        


        public int DuracionLlmada { get => duracionLlmada; set => duracionLlmada = value; }
        public DateTime FechaHoraActual { get => fechaHoraActual; set => fechaHoraActual = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        internal Llamada LlamadaActual { get => llamadaActual; set => llamadaActual = value; }
        internal CategoriaLlamada CategoriaLlamadaActual { get => categoriaLlamadaActual; set => categoriaLlamadaActual = value; }
        internal OpcionLlamada OpcionLlamadaActual { get => opcionLlamadaActual; set => opcionLlamadaActual = value; }
        internal SubOpcionLlamada SubOpcionLlamadaActual { get => subOpcionLlamadaActual; set => subOpcionLlamadaActual = value; }
        internal Estado EstadoEnCurso { get => estadoEnCurso; set => estadoEnCurso = value; }
        internal List<Validacion> MensajesValidacion { get => mensajesValidacion; set => mensajesValidacion = value; }
        internal OpcionValidacion OpcionDeValidacionSeleccionada { get => opcionDeValidacionSeleccionada; set => opcionDeValidacionSeleccionada = value; }
        internal List<RespuestaCliente> RespuestaSeleccionadas { get => respuestaSeleccionadas; set => respuestaSeleccionadas = value; }
        internal List<Estado> ListaEstados { get => listaEstados; set => listaEstados = value; }
        internal Estado EstadoFinalizado { get => estadoFinalizado; set => estadoFinalizado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Estado EstadoCancelado { get => estadoCancelado; set => estadoCancelado = value; }

        public GestorRegistarRespuesta() { }
        public GestorRegistarRespuesta(PantallaRegistrarRespuesta pantalla)
        {


            
            pantallaRegistarRespuesta = pantalla;
            //listaEstados = new List<Estado>();
            //Estado estado1 = new Estado("EnCurso");
            //Estado estado2 = new Estado("Finalizada");
            //Estado estado3 = new Estado("Cancelada");
            //listaEstados.Add(estado1);
            //listaEstados.Add(estado2);


        }

        //PASO 1-llamada, categoria, opcion, sub-opcion recibias por CU1
        public void nuevaRtaOperador(Llamada llamada, CategoriaLlamada cat, OpcionLlamada op, SubOpcionLlamada subOp) {
    
            LlamadaActual = llamada;
            categoriaLlamadaActual = cat;
            opcionLlamadaActual = op;
            subOpcionLlamadaActual = subOp;


            //PASO 2-Actualziamos llamada identificada a EnCurso
            //estadoEnCurso = buscarEstadoEnCurso();
            getFechaHoraActual();
            //tomadaPorOperador() metodo llamado igual que en la ME que hace cambiar el estado de la llamada a EnCurso
            llamadaActual.tomadaPorOperador(fechaHoraActual);

            //PASO 3-busacamos los datos de la llamada para mostrarlos y a sus validaciones
            buscarDatosLlamada();


        }

        //recorre la lista de estados hasta encontrar el estado EnCurso
        //public Estado buscarEstadoEnCurso() {

        //     estadoEnCurso = new Estado();          
        //    foreach(Estado estado in listaEstados)
        //    {
        //        if (estado.esEnCurso())
        //        {
        //            estadoEnCurso = estado;
        //        }              
        //    }
        //    return estadoEnCurso;
        //}

        //obtenemos la fecha y hora actual para registrarla en el cambio de estado
        public void getFechaHoraActual() {
            fechaHoraActual = DateTime.Now;
        }


        //hacemos la busqueda de los datos de llamada
        public void buscarDatosLlamada() {
            nombreCliente = llamadaActual.getCliente();
    
            (string nomCat, string nomOp, string nomSub)=categoriaLlamadaActual.getDescripcionCategoriaYOpcion(opcionLlamadaActual,subOpcionLlamadaActual);

            pantallaRegistarRespuesta.mostrarLLamada(nombreCliente,nomCat,nomOp,nomSub);

            (List<List<string>> audios, List<string> nombres)= categoriaLlamadaActual.getValidaciones(opcionLlamadaActual, subOpcionLlamadaActual);


            //mostramos al operador la llamada y las validaciones
            pantallaRegistarRespuesta.mostrarOPValidacion(audios, nombres);
        }


        //tomamos la opcion de la validacion ingresada y verificamos si es la correcta
        public bool tomarOpValidacion(string res) {

            return LlamadaActual.validarInformacionCliente(res);
        }

        //tomamos la respuesta de la descricpion de lo que el cliente quiere consultar
        public void tomarRespuestas(string des) {
            this.descripcion = des;
            pantallaRegistarRespuesta.solicitarConfirmacionDeLaOperacion();
            
        }
        //tomamos la confirmacion de la operacion, debemos llamar al CU28 y generar un nuevo cambio de estado
        public void tomarConfirmacion() {
            llamarCURegistrarAccionRequerida();
        //    this.estadoFinalizado = buscarEstadoFinalizada();     
            this.duracionLlmada = llamadaActual.getDuracion(fechaHoraActual);
            getFechaHoraActual();
            llamadaActual.DescripcionOperador = descripcion;
            llamadaActual.finalizar(fechaHoraActual);
            finCU();
        }
        public void llamarCURegistrarAccionRequerida() {
                //extend
        }

        //recorre la lista de estados hasta encontrar el estado Finalizada
        //public Estado buscarEstadoFinalizada()
        //{
        //    estadoFinalizado = new Estado();

        //    foreach (Estado estado in listaEstados)
        //    {
        //        if (estado.esFinalizada())
        //        {
        //            estadoFinalizado = estado;
        //        }

        //    }

        //    return estadoFinalizado;
        //}

        public void finCU() {
            pantallaRegistarRespuesta.Close();
        }


        //ALTERNATIVAS


        //se cancela la llamada ya sea porque el cliente corto o ingreso una opcion de validacion incorrecta
        public void tomarCancelacion()
        {
            
            getFechaHoraActual();
            //estadoCancelado = buscarEstadoCancelada();
            llamadaActual.cancelarLlamada(fechaHoraActual,estadoFinalizado);
            finCU();
            
        }

        //recorre la lista de estados hasta encontrar el estado Cancelada
        //public Estado buscarEstadoCancelada()
        //{
        //    estadoCancelado = new Estado();

        //    foreach (Estado estado in listaEstados)
        //    {
        //        if (estado.esCancelada())
        //        {
        //            estadoFinalizado = estado;
        //        }

        //    }

        //    return estadoCancelado;
        //}

    }
}
