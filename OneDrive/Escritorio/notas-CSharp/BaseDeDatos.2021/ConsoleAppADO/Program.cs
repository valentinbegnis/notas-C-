using System;
using Entidades;
using System.Collections.Generic;

namespace ConsoleAppADO
{
    class Program
    {
        static void Main(string[] args)
        {

            AccesoDatos ado = new AccesoDatos();

            if (ado.ProbarConexion())
            {
                Console.WriteLine("Se conectó!!!");
            }
            else
            {
                Console.WriteLine("No se conectó.");
            }

            List<Dato> lista = ado.ObtenerListaDato();

            foreach (Dato item in lista)
            {
                Console.WriteLine(item.ToString());
            }
            
            Dato obj = new Dato();
            obj.cadena = "nuevo";
            obj.entero = 100;
            obj.flotante = 33f;

            bool agrego = ado.AgregarDato(obj);

            if (agrego)
            {
                Console.WriteLine("Se agregó!!!");
            }
            else
            {
                Console.WriteLine("No se agregó.");
            }

            lista = ado.ObtenerListaDato();

            foreach (Dato item in lista)
            {
                Console.WriteLine(item.ToString());
            }

            obj.id = 3;
            obj.cadena = "modificado";
            obj.entero = 666;
            obj.flotante = 0.99f;

            bool modifico = ado.ModificarDato(obj);

            if (modifico)
            {
                Console.WriteLine("Se modificó!!!");
            }
            else
            {
                Console.WriteLine("No se modificó.");
            }

            lista = ado.ObtenerListaDato();

            foreach (Dato item in lista)
            {
                Console.WriteLine(item.ToString());
            }

            bool elimino = ado.EliminarDato(4);

            if (elimino)
            {
                Console.WriteLine("Se eliminó!!!");
            }
            else
            {
                Console.WriteLine("No se eliminó.");
            }

            lista = ado.ObtenerListaDato();

            foreach (Dato item in lista)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
