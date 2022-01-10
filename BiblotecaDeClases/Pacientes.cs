using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblotecaDeClases
{
    public class Pacientes : Persona
    {
        /// <summary>
        /// Atributos de Pacientes
        /// </summary>
        private int dni;
        private int edad;
        private string obraSocial;
        private string sintomas;
        private bool pacienteAtendido;

        /// <summary>
        /// Constructor para crear objetos pacientes
        /// </summary>
        public Pacientes(string nombre, string apellido, int dni, int edad, string obraSocial, string resultadoDeConsulta, bool pacienteAtendido) : base(nombre, apellido)
        {
            this.dni = dni;
            this.edad = edad;
            this.obraSocial = obraSocial;
            this.sintomas = resultadoDeConsulta;
            this.pacienteAtendido = pacienteAtendido;
        }
        /// <summary>
        /// Getters y setters para modificar o ver los atributos
        /// </summary>
        public int Dni
        {
            get 
            {
                return dni; 
            }
        }
        public int Edad
        {
            get 
            {
                return edad;
            }
        }

        public string ObraSocial
        {
            get 
            {
                return obraSocial; 
            }
        }

        public string Sintomas
        {
            get 
            {
                return sintomas; 
            }
            set
            {
                sintomas = value;
            }
        }

        public bool PacienteAtendido
        {
            get 
            {
                return pacienteAtendido;
            }
            set 
            {
                pacienteAtendido = value;
            }
        }

        
    }
}
