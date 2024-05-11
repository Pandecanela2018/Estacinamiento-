using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

class Estacionamiento
{
    public static void Main(string[] args)
    {

        int Tipovehi, horaentra = 0, horasalida = 0, minutoentra = 0, minutosalida = 0,pago;
        double Minutosesta, totalapagar = 0,Extra,fración, totalsalida, ingresopago;
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
                Console.WriteLine("jdijeijedj");

                break;

            case 2:
                Console.WriteLine("hola,como estas viejito");
                break;

            case 3:
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
            

        } while (horasalida> 24 && minutosalida > 60  || horasalida<=24 && minutosalida>60 || horasalida > 24 && minutosalida<=60);

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

        Console.WriteLine("Su hora de salida es "+horasalida+":"+minutosalida);
        do
        {
            
            Console.WriteLine(" ");
            Console.WriteLine("Su saldo a pagar por utlizar el parqueo es: $ {0} ", totalapagar);
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese la cantidad en $1, $5, $10 y $20");
            ingresopago=Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if (ingresopago<totalapagar)
            {
                Console.WriteLine("Saldo insuficiente");
                Console.WriteLine("Ingrese correctamente el dinero");
                Console.ReadKey();
                Console.Clear();
            }
        } while (ingresopago<totalapagar);

        Console.WriteLine("------------------------ ");
        Console.WriteLine("****Procesando****");
        Console.WriteLine("------------------------ ");
        Console.ReadKey();
        totalsalida = ingresopago - totalapagar;
        Console.WriteLine("Su cambio es: ${0}", totalsalida);
        Console.WriteLine(" ");
        Console.WriteLine("------------------------ ");
        Console.WriteLine("****Salida de dinero****");
        Console.WriteLine("$ " + totalsalida);







    }
}