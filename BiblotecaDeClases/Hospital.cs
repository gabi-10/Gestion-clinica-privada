using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblotecaDeClases
{
    public class Hospital
    {
        /// <summary>
        /// Pacientes ingresantes
        /// </summary>
        private List<Pacientes> listaDeEspera;
        /// <summary>
        /// Medicos Disponibles
        /// </summary>
        private List<Medicos> listaDeMedico;
        /// <summary>
        ///Consultas Activas
        /// </summary>
        private List<Consulta> listaDeConsultas;
        /// <summary>
        /// Lista De Pacientes
        /// </summary>
        public List<Pacientes> ListaDeEspera 
        { 
            get => listaDeEspera;
            set => listaDeEspera = value; 
        }
        public List<Medicos> ListaDeMedico 
        { 
            get => listaDeMedico;
            set => listaDeMedico = value; 
        }
        public List<Consulta> ListaDeConsultas 
        { 
            get => listaDeConsultas;
            set => listaDeConsultas = value; 
        }

        /// <summary>
        /// Constructor de hospital
        /// </summary>
        public Hospital()
        {
            ListaDeEspera = new List<Pacientes>();
            ListaDeMedico = new List<Medicos>();
            listaDeConsultas = new List<Consulta>();
        }
    }
}
