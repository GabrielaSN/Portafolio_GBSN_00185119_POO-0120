using System;
namespace PreParcial2
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            CP.IS mProxy = new CP.Proxy();
            int s = 0;
            string menu = "1) AGREGAR UNA CUENTA BANCARIA.\n" +
                          "2. VEN ALMACENADAS. \n" +
                          "3. VER ALMACENADAS Y TOTAL.\n" +
                          "4. VER ALMACENADAS, TOTAL Y CUENTAS QUE INICIEN POR VOCAL. \n" +
                          "5. TERMINAR";
            do
            {
                Console.WriteLine("BIENVENIDOS"); 
                Console.WriteLine("¿QUE DESEA EJECUTAR?");
                Console.WriteLine(menu);
                s = Convert.ToInt32(Console.ReadLine());
                mProxy.peticion(s);
            } while (s!=5);
        }
    }
}