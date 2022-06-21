using System;

namespace Delegados.Consola
{
    //DEFINO UN TIPO DE DELEGADO 'DELEGADODEMIFUNCION' CON LA FIRMA
    //QUE VAN A TENER QUE RESPETAR TODAS LAS FUNCIONES MANEJADAS POR LOS
    //OBJETOS DELEGADOS.
    public delegate void DelegadoDeMiFuncion(Int32 num1, Int32 num2);


    class Program
    {

        #region Métodos con la misma firma del Delegado

        public static void Sumar(int numero1, int numero2)
        {
            Console.WriteLine("La Suma es: {0}", numero1 + numero2);
        }

        public static void Restar(int numero1, int numero2)
        {
            Console.WriteLine("La Resta  es: {0}", numero1 - numero2);
        }

        #endregion

        static void Main(string[] args)
        {
            //INSTANCIO UN OBJETO DEL TIPO DELEGADO 'DELEGADODEMIFUNCION'
            //AL CONSTRUCTOR LE PASO COMO PARAMETRO LA DIRECCION DE MEMORIA
            //DEL METODO QUE SE VA A EJECUTAR CUANDO SEA INVOCADO

            DelegadoDeMiFuncion miDelegado = new DelegadoDeMiFuncion(Program.Sumar);
            miDelegado += Program.Restar;

            miDelegado(10, 5);

        }
    }
}
