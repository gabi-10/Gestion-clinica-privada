using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblotecaDeClases
{
    public class Medicos : Persona
    {
        /// <summary>
        /// Atributos de medicos
        /// </summary>
        private string especialidad;
        private int consultaTerminada;
        private bool estado;
        private List<Pacientes> listaDeEsperaDelMedico;

        /// <summary>
        /// Constructores para crear objetos Medicos
        /// </summary>
        public Medicos(string nombre, string apellido, bool estado) : base(nombre, apellido)
        {
            especialidad = "";
            estado = false;
        }
        
        public Medicos(string nombre, string apellido, bool estado, string especialidad) : base(nombre, apellido)
        {
            this.especialidad = especialidad;
            consultaTerminada = 0;
            estado = false;
            listaDeEsperaDelMedico = new List<Pacientes>();
        }
        /// <summary>
        /// Metodos propios del medico
        /// </summary>
        public void AgregarConsultaTerminada()
        {
            consultaTerminada++;
        }
        /// <summary>
        /// Getters y setters para modificar o ver los atributos
        /// </summary>
        public string Especialidad
        {
            get => especialidad;
        }
        public bool Estado
        {
            get => estado;
            set => estado = value;
        }
        public List<Pacientes> ListaDeEsperaDelMedico
        {
            get => listaDeEsperaDelMedico;
            set => listaDeEsperaDelMedico = value;
        }
        public int ConsultaTerminada
        {
            get => consultaTerminada;
            set => consultaTerminada = value;
        }
    }
}
