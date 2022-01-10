using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblotecaDeClases
{
    
        public abstract class Persona
        {
            /// <summary>
            /// Atributos de persona
            /// </summary>
            private string nombre;
            private string apellido;
            

            public Persona(string nombre, string apellido)
            /// <summary>
            /// Constructor para crear objetos Persona
            /// </summary>
            {
                this.Nombre = nombre;
                this.Apellido = apellido;
                
            }

        /// <summary>
        /// Setters y getters para modificar o ver los atributos
        /// </summary>
        public string Nombre
            {
                get => nombre;
                set => nombre = value;
            }

            public string Apellido
            {
                get => apellido;
                set => apellido = value;
            }
            
        }
    
}
