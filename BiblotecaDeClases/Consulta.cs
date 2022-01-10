using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblotecaDeClases
{
    public class Consulta
    {
        /// <summary>
        /// Atributos de clase consulta
        /// </summary>
        private bool finalizada;
        private bool asignada;
        private string resultado ;
        private string areaDeEspecializacion;
        private Pacientes paciente;
        private Medicos medico;
        public bool Finalizada
        {
            /// <summary>
            /// Atributos de medicos
            /// </summary>
            get
            { 
                return finalizada; 
            }
            set
            {
                finalizada = value; 
            }
        }
        /// <summary>
        /// Setters y Getters<
        /// </summary>
        public bool Asignada
        {
            get
            {
                return asignada;
            }
            set 
            {
                asignada = value;
            }
        }

        public string Resultado
        {
            get 
            { 
                return resultado;
            }
            set
            { 
                resultado = value; 
            }
        }

        public string AreaDeEspecializacion
        {
            get 
            { 
                return areaDeEspecializacion; 
            }
            set
            {
                areaDeEspecializacion = value;
            }
        }

        public Pacientes PacienteEnConsulta
        {
            get 
            {
                return paciente;
            }
        }

        public Medicos MedicoEnConsulta
        {
            get 
            {
                return medico;
            }
        }
        /// <summary>
        /// Constructor para crear objetos
        /// </summary>
        /// <param name="finalizada"></param>
        /// <param name="asignada"></param>
        /// <param name="resultado"></param>
        /// <param name="areaDeEspecializacion"></param>
        /// <param name="paciente"></param>
        /// <param name="medico"></param>
        public Consulta(bool finalizada, bool asignada, string resultado, string areaDeEspecializacion, Pacientes paciente, Medicos medico)
        {
            this.asignada = asignada;
            this.resultado = resultado;
            this.areaDeEspecializacion = areaDeEspecializacion;
            this.paciente = paciente;
            this.medico = medico;
        }
        /// <summary>
        /// Switch para instanciar las clases y los atributos
        /// </summary>
        /// <param name="p"></param>
        /// <param name="m"></param>
        /// <param name="c"></param>
        /// <returns></returns>

        public static string ResultadoConsulta(Pacientes p, Medicos m, Consulta c)
        {
            switch (p.Sintomas)
            {
                case "Tos":
                    c.Resultado = $"El paciente {p.Apellido} en consulta con el doctor {m.Apellido} tiene que Hisoparse";
                    break;
                case "Fractura":
                    c.Resultado = $"El paciente {p.Apellido} en consulta con el doctor {m.Apellido} tiene que ser trasladado a cirugia";
                    break;
                case "Dolor de espalda":
                    c.Resultado = $"El paciente {p.Apellido} en consulta con el doctor {m.Apellido} tiene que tomar un calmante";
                    break;
                case "Dolor de garganta":
                    c.Resultado = $"El paciente {p.Apellido} en consulta con el doctor {m.Apellido} tiene que tomar amoxicilina";
                    break;
            }
            return c.Resultado;
        }
    }

}
