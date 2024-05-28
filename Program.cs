
class Estacionamiento
{
    public static void Main(string[] args)
    {

        int Tipovehi;

        DateTime horaentrada = DateTime.Now;
       
        Console.WriteLine("Bienvenidos al estacionamiento");
        Console.WriteLine("  ");
        Console.WriteLine("Tome su ticket");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("------------------------------------------------------------------------------ ");
        Console.WriteLine("Hora de entrada al estacionamiento es : {0} ", horaentrada.ToString("hh:mm"));
        Console.WriteLine("------------------------------------------------------------------------------ ");
        Console.WriteLine("                                                                               ");
        Console.WriteLine("                                   Tarifas                                     ");
        Console.WriteLine("                                1 hora = $ 1.50                                ");
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

        char[] espaciosSedan = new char[50];
        static void InicializarEspacios(char[] espaciosSedan)
        {
            for (int sedan = 0; sedan < espaciosSedan.Length; sedan++)
            {
                espaciosSedan[sedan] = '*';
            }
        }
        static void MostrarEstacionamiento(char[] espaciosSedan)
        {
            Console.WriteLine("Estado del Estacionamiento:");
            Console.ReadKey();
            for (int sedan = 0; sedan < espaciosSedan.Length; sedan++)
            {
                if (espaciosSedan[sedan] == '*')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.WriteLine("Ingreso de vehiculo sedan");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write("* ");
            }
            Console.WriteLine("\n");
            Console.ResetColor();

            int cantidad = 1;

            for (int sedan = 0; sedan < cantidad; sedan++)
            {
                espaciosSedan[sedan] = 'X';
            }
        }


        char[] espaciosMoto = new char[30];

        static void InicializarEspaciosMotos(char[] espaciosMoto)
        {
            for (int Moto = 0; Moto < espaciosMoto.Length; Moto++)
            {
                espaciosMoto[Moto] = '*';
            }
        }
        static void MostrarEstacionamientoMotos(char[] espaciosMoto)
        {
            Console.WriteLine("Estado del Estacionamiento:");
            Console.ReadKey();
            for (int Moto = 0; Moto < espaciosMoto.Length; Moto++)
            {
                if (espaciosMoto[Moto] == '*')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.WriteLine("Ingreso de Moto");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write("* ");
            }
            Console.WriteLine("\n");
            Console.ResetColor();

            int cantidad = 1;

            for (int Moto = 0; Moto < cantidad; Moto++)
            {
                espaciosMoto[Moto] = 'X';
            }
        }


        char[] espaciosVehiculosPesado = new char[25];
        static void InicializarEspaciosPesado(char[] espaciosVehiculosPesado)
        {
            for (int Pesado = 0; Pesado < espaciosVehiculosPesado.Length; Pesado++)
            {
                espaciosVehiculosPesado[Pesado] = '*';
            }
        }
        static void MostrarEstacionamientoPesado(char[] espaciosVehiculosPesado)
        {
            Console.WriteLine("Estado del Estacionamiento:");
            Console.ReadKey();
            for (int Pesado = 0; Pesado < espaciosVehiculosPesado.Length; Pesado++)
            {
                if (espaciosVehiculosPesado[Pesado] == '*')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.WriteLine("Ingreso de vehiculo sedan");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write("* ");
            }
            Console.WriteLine("\n");
            Console.ResetColor();

            int cantidad = 1;

            for (int Pesado = 0; Pesado < cantidad; Pesado++)
            {
                espaciosVehiculosPesado[Pesado] = 'X';
            }
        }
        Console.WriteLine("Ingrese que tipo de vehiculo cuenta");
        Console.WriteLine(" ");
        Console.WriteLine("1.Vehiculos sedan \r\n 2.Moto \r\n 3.Vehiculos Pesado");
        Tipovehi = Convert.ToInt32(Console.ReadLine());

        switch (Tipovehi)
        {
            case 1:
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(" Acontinuacion se le mostrara los espacios que hay en el grupo de Vehiculos");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine(" Nivel 1 ");
                InicializarEspacios(espaciosSedan);
                MostrarEstacionamiento(espaciosSedan);
                MostrarEstacionamiento(espaciosSedan);
                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(" Acontinuacion se le mostrara los espacios que hay en el grupo de Motos ");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine(" Nivel 2 ");
                InicializarEspaciosMotos(espaciosMoto);
                MostrarEstacionamientoMotos(espaciosMoto);
                MostrarEstacionamientoMotos(espaciosMoto);
                Console.ReadKey();
                break;
            case 3:
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine(" Acontinuacion se le mostrara los espacios que hay en el grupo de Vehiculos Pesado");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine(" Nivel 3 ");
                InicializarEspacios(espaciosVehiculosPesado);
                MostrarEstacionamientoPesado(espaciosVehiculosPesado);
                MostrarEstacionamientoPesado(espaciosVehiculosPesado);
                Console.ReadKey();
                break;

        }
        Console.Clear();

        DateTime horaSalida = DateTime.Now;
        TimeSpan finalizado = horaSalida - horaentrada;
        Console.WriteLine("Salida del parqueo");
        Console.ReadKey();
        Console.WriteLine(" ");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        Console.WriteLine("                                           Ticket                      ");
        Console.WriteLine("                     Su hora de ingreso fue: {0}",horaentrada.ToString("hh:mm"));
        Console.WriteLine("                      Su hora de salida es: {0}", horaSalida.ToString("hh:mm"));
        Console.WriteLine("                  Su estadía en el parqueo fue de  {0} minutos  con  {1} segundos ", finalizado.Minutes, finalizado.Seconds);
        Console.WriteLine("                          Gracias por utilizar nuestras instalaciones    ");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        Console.WriteLine("");

        Console.WriteLine("Ticket de pago");


        if (finalizado.TotalSeconds > 60)
        {
            Console.WriteLine("Ha excedido una hora de estadía. Debe pagar la tarifa completa.");

        }
        else
        {
            double tarifaFraccion = 0.50;
            double tarifaTotal = (finalizado.TotalSeconds / 60) * 1.50;

            Console.WriteLine("La tarifa total es: $" + ((short)tarifaTotal));
        }

        //if (finalizado.TotalSeconds > 60)
        //{
        //    Console.WriteLine("Ha excedido una hora de estadía. Debe pagar la tarifa completa.");
        //    Console.WriteLine("Su saldo es");
        //    Console.WriteLine(" ");
        //    double tarifaFraccion = 0.50;
        //    double Pago = finalizado.TotalSeconds/ 
        //    Console.ReadKey();

        //}
        //else
        //{

        //    double tarifaTotal = (finalizado.TotalSeconds / 60) * 1.50;

        //    Console.WriteLine("La tarifa total es: $" + tarifaTotal);
    }

       




}

