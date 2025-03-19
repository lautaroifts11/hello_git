using System;

namespace hello_git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
    /*
     PROCEDIMIENTO GIT:
    (repositorio LOCAL)
    1- git init. (solo cuando se inicializa)
    -- bucle de trabajo --
    2- git add
    3- git commit -m "mensaje referencial a lo que voy subir :)"
    (repostorio REMOTO)
    4- git push (ENVIAR LOS CAMBIOS)
    -----------------------------------
    5- git pull (TRAERME LOS CAMBIOS)
         
     */

    public class pokemon
    {
        /* atributos */
        public string nombre;
        public int salud;
        public string raza;

        /*metodos*/
        public void atacar()
        {
            Console.WriteLine("Ataco!");
        }

        public void defender()
        {
            Console.WriteLine("Activo defensa");
        }

    }
}
