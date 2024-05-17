
class EstacionamientoProyecto
{
    public static void Main(string[] args)
    {

        int Tipovehi, horaentra = 0, horasalida = 0, minutoentra = 0, minutosalida = 0, pago;
        double Minutosesta, totalapagar = 0, Extra, fración, totalsalida, ingresopago;

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
