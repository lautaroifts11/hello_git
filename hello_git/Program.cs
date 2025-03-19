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
