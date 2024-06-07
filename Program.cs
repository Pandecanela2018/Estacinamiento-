class Estacionamiento
{
    public static void Main(string[] args)
    {

        int Tipovehi;
        double Tcompleta = 0, Dinero=0; 

        static void LugarCH()
        {
            int cantidadRectangulos = 5;
            int alturaRectangulo = 3;
            int anchuraRectangulo = 2;
            

            Console.WriteLine("Selecciona uno de los espacios (1 - 5) para elegir su lugar:");
            int rectanguloRojo = int.Parse(Console.ReadLine());


            if (rectanguloRojo < 1 || rectanguloRojo > cantidadRectangulos)
            {
                Console.WriteLine("Número inválido. Por favor, selecciona un número entre 1 y " + cantidadRectangulos);
                return;
            }


            for (int i = 0; i < alturaRectangulo; i++)
            {
                for (int j = 0; j < cantidadRectangulos; j++)
                {

                    if (j + 1 == rectanguloRojo)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }


                    for (int k = 0; k < anchuraRectangulo; k++)
                    {
                        Console.Write("* ");
                    }


                    Console.Write("   ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        static void LugarGR()
        {
            int cantidadRectangulos = 5;
            int alturaRectangulo = 3;
            int anchuraRectangulo = 2;


            for (int i = 0; i < alturaRectangulo; i++)
            {
                for (int j = 0; j < cantidadRectangulos; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int k = 0; k < anchuraRectangulo; k++)
                    {
                        Console.Write("* ");
                    }

                    Console.Write("   ");
                }
                Console.WriteLine();

            }
            Console.ResetColor();
        }

        static void lugarCH2()
        {
            int cantidadRectangulos = 5;
            int alturaRectangulo = 3;
            int anchuraRectangulo = 1;


            Console.WriteLine("Selecciona uno de los espacios (1 - 5) para elegir su lugar:");
            int rectanguloRojo = int.Parse(Console.ReadLine());


            if (rectanguloRojo < 1 || rectanguloRojo > cantidadRectangulos)
            {
                Console.WriteLine("El número seleccionado es inválido. Por favor, selecciona un número entre 1 y " + cantidadRectangulos);
                return;
            }


            for (int i = 0; i < alturaRectangulo; i++)
            {
                for (int j = 0; j < cantidadRectangulos; j++)
                {

                    if (j + 1 == rectanguloRojo)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }


                    for (int k = 0; k < anchuraRectangulo; k++)
                    {
                        Console.Write("* ");
                    }


                    Console.Write("   ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        static void lugarGR2()
        {
            int cantidadRectangulos = 5;
            int alturaRectangulo = 3;
            int anchuraRectangulo = 1;


            for (int i = 0; i < alturaRectangulo; i++)
            {
                for (int j = 0; j < cantidadRectangulos; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int k = 0; k < anchuraRectangulo; k++)
                    {
                        Console.Write("* ");
                    }

                    Console.Write("   ");
                }
                Console.WriteLine();

            }
            Console.ResetColor();
        }
        static void lugarCH3()
        {
            int cantidadRectangulos = 5;
            int alturaRectangulo = 4;
            int anchuraRectangulo = 2;


            Console.WriteLine("Selecciona uno de los espacios (1 - 5) para elegir su lugar:");
            int rectanguloRojo = int.Parse(Console.ReadLine());


            if (rectanguloRojo < 1 || rectanguloRojo > cantidadRectangulos)
            {
                Console.WriteLine("Número inválido. Por favor, selecciona un número entre 1 y " + cantidadRectangulos);
                return;
            }


            for (int i = 0; i < alturaRectangulo; i++)
            {
                for (int j = 0; j < cantidadRectangulos; j++)
                {

                    if (j + 1 == rectanguloRojo)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    for (int k = 0; k < anchuraRectangulo; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        static void lugarGR3()
        {
            int cantidadRectangulos = 5;
            int alturaRectangulo = 4;
            int anchuraRectangulo = 2;
            for (int i = 0; i < alturaRectangulo; i++)
            {
                for (int j = 0; j < cantidadRectangulos; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int k = 0; k < anchuraRectangulo; k++)
                    {
                        Console.Write("* ");
                    }

                    Console.Write("   ");
                }
                Console.WriteLine();

            }
            Console.ResetColor();
        }

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
        string opci;
        Console.WriteLine("-------------------------------------------------------------------------------- ");
        Console.WriteLine("Saludos, decida en que lugar desea ingresar su auto, basado en la lista presente");
        Console.WriteLine("-------------------------------------------------------------------------------- ");
        Console.WriteLine("para selecionar uno de los espacios visibibles, coloque La Lectra del lugar");
        Console.WriteLine("(A)");
        LugarGR();
        Console.WriteLine("(B)");
        LugarGR();
        Console.WriteLine("---------------------------------------------------------------------------------------------");
        Console.WriteLine("grupo de motos");
        Console.WriteLine("(C)");
        lugarGR2();
        Console.WriteLine("(D)");
        lugarGR2();
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        Console.WriteLine("grupo de Vehiculos pesados");
        Console.WriteLine("(E)");
        lugarGR3();
        Console.WriteLine("------------------------------------------------------------------------------------------");

        opci = Convert.ToString(Console.ReadLine());
        
        switch (opci.ToUpper())
        {
             case "A":
      Console.WriteLine("---------------------------------------------------------------------------------------------");
      Console.WriteLine("grupo de autos");
      Console.WriteLine("(A)");
      LugarCH();
    
      break;
  case "B":
       Console.WriteLine("---------------------------------------------------------------------------------------------");
      Console.WriteLine("grupo de autos");
      Console.WriteLine("(B)");
      LugarCH();
    
   
      break;
  case "C":
    
      Console.WriteLine("---------------------------------------------------------------------------------------------");
      Console.WriteLine("grupo de motos");
      Console.WriteLine("(C)");
      lugarCH2();
   
      break;
  case "D":
      Console.WriteLine("-------------------------------------------------------------------------------------------");
      Console.WriteLine("grupo de motos");
      Console.WriteLine("(D)");
      lugarCH2();
 
    
      break;
  case "E":
      Console.WriteLine("-------------------------------------------------------------------------------------------");
      Console.WriteLine("grupo de Vehiculos pesados");
      Console.WriteLine("(E)");
      lugarCH3();

      break;
        }
        Console.ReadKey();
        Console.Clear();

        DateTime horaSalida = DateTime.Now;
        TimeSpan finalizado = horaSalida - horaentrada;
        Console.WriteLine("------------------------------------");
        Console.WriteLine("        Saliendo del parqueo         ");
        Console.WriteLine("------------------------------------"); 
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        Console.WriteLine("                                                 Ticket                      ");
        Console.WriteLine("                                     Su hora de ingreso fue: {0}", horaentrada.ToString("hh:mm"));
        Console.WriteLine("                                     Su hora de salida es: {0}", horaSalida.ToString("hh:mm"));
        Console.WriteLine("                  Su estadía en el parqueo fue de  {0} minutos  con  {1} segundos ", finalizado.Minutes, finalizado.Seconds);
        Console.WriteLine("                        Gracias por utilizar nuestras instalaciones, vuelva pronyo    ");
        Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Ticket de pago");

         
        if (finalizado.TotalSeconds <= 60)  //1 = 60s
        {
            Tcompleta = 1.50;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Su monto pagar es : ${0}", Tcompleta);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Presione cualquier tecla para pagar");
            Console.WriteLine("------------------------------------");
            Console.ReadKey();


        }
        else if (finalizado.TotalSeconds>60)
        {                                                                                              
            Tcompleta = 1.50;
            double Extra = finalizado.TotalSeconds  - 60;  
            double fración = Math.Ceiling(Extra / 15);
            Tcompleta += fración * 0.50;


        }
        do
        {
            Console.WriteLine("------------------------------------------------------------");
            
            Console.WriteLine(" ");
            Console.WriteLine             ("La tarifa total es: $" + Tcompleta);
            Console.WriteLine("                                              ");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Indique la cantidad a pagar adecuada $1, $5, $10, $20 , $50 y $100");
            Dinero= Convert.ToDouble(Console.ReadLine());

            if (Dinero < Tcompleta )
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine               ("Saldo insuficiente");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine        ("Ingrese correctamente el dinero");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine      ("Presione cualquier tecla para pagar");
                Console.WriteLine("-----------------------------------------------");
                Console.ReadKey();
                Console.Clear();
            }

        } while (Dinero<Tcompleta || Dinero<=Tcompleta);

        double pago = Dinero-Tcompleta;

        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Su cambio es: ");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(" $"+pago);
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("*Gracias por utilizar nuestras instalaciones.*");



    }


}




