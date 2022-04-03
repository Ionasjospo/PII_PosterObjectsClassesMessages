using System;

namespace Person
{
    public class Person
    {
        /// <summary>
        /// Atributo privado nombre.
        /// </summary>
        /// <value>Nombre de la persona.</value>
        private string name { get; set;}
        /// <summary>
        /// Atributo privado id.
        /// </summary>
        /// <value>Id ó cédula de la persona.</value>
        private string id { get; set;}

        /// <summary>
        /// Constructor de la clase Person que verifica que los atributos sean validos.
        /// </summary>
        /// <param name="nombre">Nombre de la persona a verificar</param>
        /// <param name="cedula">Cédula de la persona a verificar</param>
        public Person(string nombre, string cedula)
        {
            if (nameItsValid(nombre) == true)
            {
               this.name = nombre; 
            }
            else 
            {
                 this.name = "";
            } 

            if (IdUtils.IdIsValid(cedula) == true)
            {
                this.id = cedula;
            }
            else 
            {
                this.id = "";
            } 
        }

        /// <summary>
        /// Método que verifica que el nombre sea valido.
        /// </summary>
        /// <param name="nombre">Nombre a verificar.</param>
        /// <returns>true or false.</returns>
        public bool nameItsValid (string nombre)
        {
            if (nombre.Length == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método que presenta a la persona si su nómbre y cédula son ambos validos, sino 
        /// imprime un error.
        /// </summary>
        public void IntroduceYourself()
        {
            if (IdUtils.IdIsValid(this.id) == false || nameItsValid(this.name) == false)
            {
                Console.WriteLine("Error, nombre ó cédula invalida");
            }
            else
            {
                Console.WriteLine($"Hola soy {this.name} y mi número de cédula es {this.id}");
            }
        }
    }
}