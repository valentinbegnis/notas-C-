using System;

namespace Delegados.Predefinidos
{
    class Program
    {
        public void VoidSinParametros()
        {
            Console.WriteLine("Método de instancia sin parámetros y retorno void");
        }
        public static void VoidConUnParametro(string cadena)
        {
            Console.WriteLine("Método de clase con un parámetro y retorno void");
            Console.WriteLine(cadena);
        }

        public static void VoidConVariosParametros(string cadena, int entero)
        {
            Console.WriteLine("Método de clase con parámetros y retorno void");
            Console.WriteLine("{0} - {1}", cadena, entero);
        }

        public static string ConRetornoSinParametros()
        {
            return "Método de clase sin parámetros y retorno string";
        }

        public static string ConRetornoConParametros(double doble, bool booleano)
        {
            return $"Método de clase con parámetros ({doble.GetType().Name} - {booleano.GetType().Name}) y retorno string.";
        }

        public static bool RetornoBooleanoUnParametroEntero(int entero)
        {
            Console.WriteLine("Método de clase con un parámetro {0}) y retorno bool.", entero);
            return true;
        }

        public static bool RetornoBooleanoUnParametroObject(object obj)
        {
            return obj is string ? true : false;
        }

        static void Main(string[] args)
        {
            #region Action
            ///Action: Representa métodos que retornan Void y tienen entre 0 y 16 parámetros de entrada.
            ///

            #region Action - ejemplo 1

            Program objProgram = new Program();

            Action delVoidSinParametros = objProgram.VoidSinParametros;

            delVoidSinParametros();

            #endregion

            #region Action - ejemplo 2

            Action<string> delVoidConUnParametro = Program.VoidConUnParametro;

            delVoidConUnParametro.Invoke("Hola mundo");

            #endregion

            #region Action - ejemplo 3

            Action<string, int> delVoidConVariosParametros;

            delVoidConVariosParametros = Program.VoidConVariosParametros;

            delVoidConVariosParametros("cadena de texto", 66);

            #endregion

            #endregion

            #region Func
            ///Func: Representa métodos que retornan algo distinto de Void y tienen entre 0 y 16 parámetros de entrada.
            ///

            #region Func - ejemplo 1

            Func<string> delConRetornoSinParametros;

            delConRetornoSinParametros = Program.ConRetornoSinParametros;

            string resultado = delConRetornoSinParametros();

            Console.WriteLine(resultado);

            #endregion

            #region Func - ejemplo 2

            Func<double, bool, string> delConRetornoConParametros = Program.ConRetornoConParametros;

            delConRetornoConParametros.Invoke(33.9, true);

            #endregion

            #endregion

            #region Predicate

            ///Predicate: Representa métodos que retornan Boolean y reciben un parámetro de entrada.
            ///

            #region Predicate - ejemplo 1

            Predicate<int> delRetornoBooleanoUnParametroEntero = Program.RetornoBooleanoUnParametroEntero;

            bool retorno = delRetornoBooleanoUnParametroEntero(77);

            #endregion

            #region Predicate - ejemplo 2

            Predicate<object> delRetornoBooleanoUnParametroObject;

            delRetornoBooleanoUnParametroObject = Program.RetornoBooleanoUnParametroObject;

            if(delRetornoBooleanoUnParametroObject("tipo cadena")) 
            {
                Console.WriteLine("Contiene un string.");
            }
            else
            {
                Console.WriteLine("No contiene un string.");
            }

            #endregion

            #endregion


            #region Expresiones Lambda
            ///Expresión lambda (función flecha): Permiten crear funciones anónimas. 
            ///Una función anónima es una función que no tiene nombre ni declaración formal.
            ///

            #region Funciones flecha y Delegados - Ejemplo 1

            //string Método(double a)

            Func<double, string> a = doble => doble.ToString() ;

            string res = a(2.99);

            Console.WriteLine(a);

            #endregion

            #region Funciones flecha y Delegados - Ejemplo 2

            //string ConRetornoConParametros(double doble, bool booleano)

            Func<double, bool, string> b;
            
            b = (doble, booleano) => $"Método de clase con parámetros ({doble.GetType().Name} - {booleano.GetType().Name}) y retorno string.";

            res = b(8.88, false);

            Console.WriteLine(res);

            #endregion

            #endregion

        }
    }
}
