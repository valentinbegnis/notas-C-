using System;


namespace Entidades
{
    public class Dato
    {
        public int id;
        public string cadena;
        public int entero;
        public float flotante;

        public override string ToString()
        {
            return  $"ID: {this.id}\n" +
                    $"CADENA: { this.cadena}\n" +
                    $"ENTERO: {this.entero}\n" +
                    $"FLOTANTE: {this.flotante}\n"; 
        }
    }
}
