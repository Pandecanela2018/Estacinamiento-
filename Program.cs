using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

class Estacionamiento
{
    public static void Main(string[] args)
    {

        int Tipovehi, horaentra = 0, horasalida = 0, minutoentra = 0, minutosalida = 0, pago;
        double Minutosesta, totalapagar = 0, Extra, fración, totalsalida, ingresopago;
        //string ; 
        horaentra = DateTime.Now.Hour;
        minutoentra = DateTime.Now.Minute;
        Console.WriteLine("Bienvenidos al estacionamiento");
        Console.WriteLine("  ");
        Console.WriteLine("Tome su ticket");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("------------------------------------------------------------------------------ ");
        Console.WriteLine("Hora de entrada al estacionamiento es  " + horaentra + ":" + minutoentra + " ");
        Console.WriteLine("------------------------------------------------------------------------------ ");
        Console.WriteLine(" ");
        Console.WriteLine("                                   Tarifas                                     ");
        Console.WriteLine("                                1 hora = $ 1.50                                  ");
        Console.WriteLine("                           Fracción de hora = ¢ 0.50                           ");
        Console.WriteLine("   No nos hacemos responsables de cualquier robo o daño que se haga al vehiculo");
        Console.WriteLine("                            ****Muchas Gracias****                             ");
        Console.WriteLine(" ");
        Console.WriteLine("------------------------------------------------------------------------------ ");
        Console.WriteLine(" ");
        Console.WriteLine("Presione cualquier tecla para continuar");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine(" ");
        do
        {
            Console.WriteLine("Ingrese que tipo de vehiculo cuenta");
            Console.WriteLine(" ");
            Console.WriteLine("\r\n 1.Vehiculos \r\n 2.Transporte de mayor tamaño \r\n 3.Motos \r\n 0.Salir");
            Tipovehi = Convert.ToInt32(Console.ReadLine());

                switch (Tipovehi)
                {
                    case 1:
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("Acontinuacion se le mostrara los espacios que hay en el grupo de Vehiculos");
                        Console.WriteLine("-----------------------------------------------------------------------");
                        char[] espacios = new char[100];

                        InicializarEspacios(espacios);

                        MostrarEstacionamiento(espacios);

                        IngresarAuto(espacios);

                        MostrarEstacionamiento(espacios);

                       Console.ReadLine();

                       static void InicializarEspacios(char[] espacios)
                       {
                           for (int i = 0; i < espacios.Length; i++)
                           {
                               espacios[i] = '*';
                           }
                       }

                        static void MostrarEstacionamiento(char[] espacios)
                        {
                            Console.WriteLine("Estado del Estacionamiento:");
                            for (int i = 0; i < espacios.Length; i++)
                            {
                                if (espacios[i] == '*')
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                Console.Write("* ");
                            }
                            Console.WriteLine("\n");
                            Console.ResetColor();
                        }

                        static void IngresarAuto(char[] espacios)
                        {
                            Console.WriteLine("Ingrese la cantidad de autos que han ingresado:");
                            int cantidad = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < cantidad; i++)
                            {
                                espacios[i] = 'X';
                            }
                        }

                        break;

                    case 2:
                        Console.WriteLine("-----------------------------------------------------------------------");
                        Console.WriteLine("Acontinuacion se le mostrara los espacios que hay en el grupo de Motos");
                        Console.WriteLine("-----------------------------------------------------------------------");
                        char[] espacios2 = new char[50];

                        InicializarEspacios2(espacios2);

                        MostrarEstacionamiento2(espacios2);

                        IngresarPesado(espacios2);

                        MostrarEstacionamiento2(espacios2);

                       Console.ReadLine();

                       static void InicializarEspacios2(char[] espacios)
                       {
                           for (int i = 0; i < espacios.Length; i++)
                           {
                               espacios[i] = '*';
                           }
                       }

                        static void MostrarEstacionamiento2(char[] espacios)
                        {
                            Console.WriteLine("Estado del Estacionamiento:");
                            for (int i = 0; i < espacios.Length; i++)
                            {
                                if (espacios[i] == '*')
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                Console.Write("* ");
                            }
                            Console.WriteLine("\n");
                            Console.ResetColor();
                        }

                        static void IngresarPesado(char[] espacios)
                        {
                            Console.WriteLine("Ingrese la cantidad de Vehiculos pesados que se han ingresado:");
                            int cantidad = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < cantidad; i++)
                            {
                                espacios[i] = 'X';
                            }
                        }

                        break;

                    case 3:
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine("Acontinuacion se le mostrara los espacios que hay en el grupo de Motos");
                        Console.WriteLine("------------------------------------------------------------------------");
                        char[] espacios3 = new char[200];

                        InicializarEspacios3(espacios3);

                        MostrarEstacionamiento3(espacios3);

                        Ingresarmoto(espacios3);

                        MostrarEstacionamiento3(espacios3);

                       Console.ReadLine();

                       static void InicializarEspacios3(char[] espacios)
                       {
                           for (int i = 0; i < espacios.Length; i++)
                           {
                               espacios[i] = '*';
                           }
                       }
                       static void MostrarEstacionamiento3(char[] espacios)
                       {
                           Console.WriteLine("Estado del Estacionamiento:");
                           for (int i = 0; i < espacios.Length; i++)
                           {
                               if (espacios[i] == '*')
                               {
                                   Console.ForegroundColor = ConsoleColor.Green;
                               }
                               else
                               {
                                   Console.ForegroundColor = ConsoleColor.Red;
                               }
                               Console.Write("* ");
                           }
                           Console.WriteLine("\n");
                           Console.ResetColor();
                       }

                       static void Ingresarmoto(char[] espacios)
                       {
                           Console.WriteLine("Ingrese la cantidad de Motos que se han ingresado:");
                           int cantidad = Convert.ToInt32(Console.ReadLine());

                           for (int i = 0; i < cantidad; i++)
                           {
                               espacios[i] = 'X';
                           }
                       }

                       break;
                   case 0:
                       break;


               }
        } while (Tipovehi < 0);
           Console.Clear();

           do
           {
               Console.WriteLine("Ingrese la hora de salida (horario 24 Horas) : ");
               horasalida = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Ingrese los minutos (60 minutos): ");
               minutosalida = Convert.ToInt32(Console.ReadLine());

               if (horasalida > 24 && minutosalida > 60 || horasalida <= 24 && minutosalida > 60 || horasalida > 24 && minutosalida <= 60)
               {
                   Console.WriteLine("Ingrese correctamente la hora y minuto de salida");
                   Console.ReadKey();
                   Console.Clear();
               }


           } while (horasalida > 24 && minutosalida > 60 || horasalida <= 24 && minutosalida > 60 || horasalida > 24 && minutosalida <= 60);

           Minutosesta = ((horasalida * 60) + minutosalida) - ((horaentra * 60) + minutoentra);

           if (Minutosesta <= 60)
           {
               totalapagar = 1.50;

           }
           else
           {
               totalapagar = 1.50;
               Extra = Minutosesta - 60;
               fración = Math.Ceiling(Extra / 15);
               totalapagar += (fración * 0.50);
           }

           Console.WriteLine("Su hora de salida es " + horasalida + ":" + minutosalida);
           do
           {

               Console.WriteLine(" ");
               Console.WriteLine("El saldo a pagar de los clientes es de: $ {0} ", totalapagar);
               Console.WriteLine(" ");
               Console.WriteLine("Inidique la cantidad adecuada $1, $5, $10 y $20");
               ingresopago = Convert.ToDouble(Console.ReadLine());
               Console.Clear();
               if (ingresopago < totalapagar)
               {
                   Console.WriteLine("Saldo insuficiente");
                   Console.WriteLine("Ingrese correctamente el dinero");
                   Console.ReadKey();
                   Console.Clear();
               }
           } while (ingresopago < totalapagar);

           Console.WriteLine("------------------------ ");
           Console.WriteLine("****Procesando****");
           Console.WriteLine("------------------------ ");
           Console.ReadKey();
           totalsalida = ingresopago - totalapagar;
           Console.WriteLine("El cambio es de: ${0}", totalsalida);
           Console.WriteLine(" ");
           Console.WriteLine("---------------------------------------------------- ");
           Console.WriteLine("****Salida de dinero****");
           Console.WriteLine("$ " + totalsalida);
           Console.WriteLine("---------------------------------------------------- ");
           Console.WriteLine("presione cualquier tecla para finalizar              ");
           Console.WriteLine("---------------------------------------------------- ");
           Console.ReadKey();
           Console.Clear();

      
    }
}
