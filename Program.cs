using S10_Laboratorio10_ConsolaNET.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_Laboratorio10_ConsolaNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mPhone = 0;
            int mPad = 0;
            int mapBrook = 0;
            int mWatch = 0;
            int total = 0;
            string objeto= "";
            int opcion = 0;
            do
            {
                if (opcion == 0 || opcion > 5) opcion = InterfazConsola.menuPrincipal(); //PARTE 1
                if (opcion > 0 && opcion < 5)
                {
                    switch (opcion)
                    {
                        case 1: objeto = "mPhone 3000"; break;
                        case 2: objeto = "mPad 3500"; break;
                        case 3: objeto = "MAPBrook 3800"; break;
                        case 4: objeto = "mWatch 8000"; break;
                    }
                    int opcion2 = 0;
                    do
                    {
                        switch (opcion2)
                        {
                            default:
                                opcion2 = InterfazConsola.registrar(objeto); //PARTE 2
                                break;
                            case 1:
                                switch (opcion) //PARTE 4
                                {
                                    case 1: mPhone += InterfazConsola.registrarVenta(objeto); break;
                                    case 2: mPad += InterfazConsola.registrarVenta(objeto); break;
                                    case 3: mapBrook += InterfazConsola.registrarVenta(objeto); break;
                                    case 4: mWatch += InterfazConsola.registrarVenta(objeto); break;
                                }
                                opcion2 = 0;
                                break;
                            case 2:
                                switch (opcion) //PARTE 3
                                {
                                    case 1: mPhone -= InterfazConsola.registrarDevolucion(objeto); break;
                                    case 2: mPad -= InterfazConsola.registrarDevolucion(objeto); break;
                                    case 3: mapBrook -= InterfazConsola.registrarDevolucion(objeto); break;
                                    case 4: mWatch -= InterfazConsola.registrarDevolucion(objeto); break;
                                }
                                opcion2 = 0;
                                break;
                            case 3: break;
                        }
                    } while (opcion2 != 3);
                    opcion = 0;

                }
            } while (opcion != 5);
            total = mPhone + mPad + mapBrook + mWatch;
            InterfazConsola.cabezaFinPrograma(); //PARTE 5
            Console.Write("mPhones  " + "| ".PadLeft(12, ' ') + mPhone + "\r\n");
            Console.Write("mPads    " + "| ".PadLeft(12, ' ') + mPad + "\r\n");
            Console.Write("MAPBrooks" + "| ".PadLeft(12, ' ') + mapBrook + "\r\n");
            Console.Write("mWatches " + "| ".PadLeft(12, ' ') + mWatch + "\r\n");
            Console.Write("--------------------------------\r\n");
            Console.Write("Total    " + "| ".PadLeft(12, ' ') + total + "\r\n");
            InterfazConsola.pieFinPrograma();

            Console.ReadKey();
        }
    }
}
