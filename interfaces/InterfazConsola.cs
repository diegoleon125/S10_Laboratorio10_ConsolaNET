using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_Laboratorio10_ConsolaNET.interfaces
{
    public class InterfazConsola
    {
        public static int menuPrincipal() //PARTE 1
        {
            Console.Clear();
            tituloPantalla("Productos de mPhone");
            Console.Write(
                "1: Ventas de mPhone 3000\r\n" +
                "2: Ventas de mPad 3500\r\n" +
                "3: Ventas de MAPBrook 3800\r\n" +
                "4: Ventas de mWatch 8000\r\n" +
                "5: Salir\r\n");
            return getOpcion();
        }
        public static int registrar(string objeto) //PARTE 2
        {
            Console.Clear();
            tituloPantalla("Registrar Venta de " + objeto);
            Console.Write(
                "1: Registrar Venta\r\n" +
                "2: Registrar Devolución\r\n" +
                "3: Menu Principal\r\n");
            return getOpcion();
        }
        public static int registrarDevolucion(string objeto) //PARTE 3
        {
            Console.Clear();
            tituloPantalla("Registrar devolución de:");
            Console.Write(
                "Se va a registrar la devolución de\r\n" +
                "un " + objeto + " ¿Desea Continuar?\r\n" +
                "1: Sí\r\n" +
                "2: No\r\n");
            int opcion = getOpcion();
            switch (opcion)
            {
                case 1: return 1;
                case 2: return 0;
                default: opcion = registrarDevolucion(objeto); break;
            }
            return opcion;
        }
        public static int registrarVenta(string objeto) //PARTE 4
        {
            Console.Clear();
            tituloPantalla("Registrar venta de:");
            Console.Write(
                "Se va a registrar la venta de un\r\n" +
                objeto + " ¿Desea Continuar?\r\n" +
                "1: Sí\r\n" +
                "2: No\r\n");
            int opcion = getOpcion();
            switch (opcion)
            {
                case 1: return 1;
                case 2: return 0;
                default: opcion = registrarVenta(objeto); break;
            }
            return opcion;
            
        }
        public static void cabezaFinPrograma() //PARTE 5_1
        {
            tituloPantalla("Reporte Final");
            Console.Write(
                "Productos Vendidos | Cantidad\r\n" +
                "--------------------------------\r\n");
        }
        public static void pieFinPrograma() //PARTE 5_2
        {
            Console.Write(
                "================================\r\n" +
                "¡Hasta Luego!\n\n\n\n" +
                "Diseñado Por: Diego León");
        }
        public static void tituloPantalla(string titulo)
        {
            Console.Write("================================\r\n" +
                           titulo + "\r\n" +
                           "================================\r\n");
        }
        public static int getOpcion()
        {
            Console.Write("================================\r\n" +
                "Ingrese una opción: ");
            string opcionTexto = Console.ReadLine();
            if (int.TryParse(opcionTexto,out int aa) == false) { return 10; }
            if (int.Parse(opcionTexto) < 0) { return 10; }
            return int.Parse(opcionTexto);
        }
    }
}
