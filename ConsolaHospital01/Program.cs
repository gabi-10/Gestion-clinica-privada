using System;
using BiblotecaDeClases;
namespace ConsolaHospital01
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicos m1 = new Medicos("Juan", "Garcia", false, "Clinico");
            Medicos m2 = new Medicos("Frey", "Vega", false, "Traumatologo");


            Console.WriteLine("***************************************");
            Console.WriteLine("++++++++++++++++-Bienvenido a la Clinica El Elfo Sanador-++++++++++++++++");
            Console.WriteLine("***************************************");
            Console.WriteLine("Ingrese el nombre del paciente");
            string nombre = (Console.ReadLine());
            Console.WriteLine("Ingrese el apellido del paciente");
            string apellido= (Console.ReadLine());
            Console.WriteLine("Ingrese el DNI del paciente");
            int dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad del paciente");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione el tipo de cobertura:");
            Console.WriteLine(" 1 Si no tiene cobertura \n 2 Si tiene cobertura basica \n 3 Si tiene cobertura completa");

            string cobertura = (Console.ReadLine());
            Console.WriteLine("Selecciona que sintomas tiene");
            Console.WriteLine(" 1 Si tiene tos  \n 2 Fractura \n 3 Dolor de espalda \n 4 Dolor de garganta");
            string sintomas = (Console.ReadLine());


            string coberturaFinal = ValidarCobertura(cobertura);
           
            string sintomasFinal = ValidarSintomas(sintomas);


            static string ValidarCobertura(string cobertura)
            {
                string coberturaRecibida = "";
                switch (cobertura)
                {
                    case "1":
                        coberturaRecibida = "No tiene";
                        break;
                    case "2":
                        coberturaRecibida = "Cobertura basica";
                        break;
                    case "3":
                        coberturaRecibida = "Cobertura completa";
                        break;
                }
                return coberturaRecibida;
            }
            static string ValidarSintomas(string sintomas)
            {
                string sintomasManifestados = "";
                switch (sintomas)
                {
                    case "1":
                        sintomasManifestados = "tos";
                        break;
                    case "2":
                        sintomasManifestados = "Fractura";
                        break;
                    case "3":
                        sintomasManifestados = "Dolor de espalda";
                        break;
                    case "4":
                        sintomasManifestados = "Dolor de garganta";
                        break;
                }
                return sintomasManifestados;
            }
            



            Pacientes p1 = new Pacientes(nombre, apellido, dni, edad, coberturaFinal, sintomasFinal, false);
            Pacientes p2 = new Pacientes("Andrea", "Hernandez", 44089780, 35, "No tiene", "Dolor de espalda", false);
            Pacientes p3 = new Pacientes("Juan", "Olguin", 332255, 15, "Cobertura completa", "tos", false);
            Consulta c1 = new Consulta(false, false, "", "", p1, m1);
            Consulta c2 = new Consulta(false, false, "", "", p2, m1);
            Consulta c3 = new Consulta(false, false, "", "", p1, m2);
            Hospital h1 = new Hospital();

            h1.ListaDeMedico.Add(m1);
            {
                Console.WriteLine($"Se agrego {m1.Nombre} {m1.Apellido} a la lista de medicos disponibles");
            }
            Console.WriteLine(h1.ListaDeMedico[0].Nombre + " " + h1.ListaDeMedico[0].Apellido);

            Console.WriteLine("---------------------------------");

            Console.WriteLine("El paciente " + p1.ObraSocial + " obra social");
            Console.WriteLine(p1.Sintomas);
            Console.WriteLine("---------------------------------");

            if (m1.Estado == false)
            {

                c1.AreaDeEspecializacion = m1.Especialidad;
                Console.WriteLine("El paciente " + c1.PacienteEnConsulta.Apellido + " de DNI " + c1.PacienteEnConsulta.Dni + " se encuentra en consulta ");
                c1.Asignada = true;
                Console.WriteLine($"En este momento el doctor {m1.Apellido} se encuentra en consultorio con el paciente {p1.Nombre} {p1.Apellido}");
            } else
            {
                Console.WriteLine("El consultorio 1 se encuentra libre");
            }
            
            if (c1.Asignada == true)
            {
                c1.Resultado = Consulta.ResultadoConsulta(p1, m1, c1);
                Console.WriteLine(c1.Resultado);
            }
            else
            {

            }

            Console.WriteLine("---------------------------------");
            h1.ListaDeConsultas.Add(c1);
            h1.ListaDeEspera.Add(p2);
            h1.ListaDeEspera.Add(p3);
            Console.WriteLine("Actualmente tenemos en lista de espera " + h1.ListaDeEspera.Count + " pacientes");



        }
    }
}
