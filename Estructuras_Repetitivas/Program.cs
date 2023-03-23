// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

class Ejercicios
{

    public void numeroPar()
    {
        int n = 0;

        do
        {

            Console.WriteLine("Ingrese un numero entero positivo");
            n = Convert.ToInt32(Console.ReadLine());


            if ((n % 2) == 0)
            {
                Console.WriteLine(n);

                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                Console.ReadKey();
                Console.Clear();
            }
        } while (n != 99);


    }

    public void numeroFilas()
    {
        Console.WriteLine("Ingrese un numero de filas");
        int n1 = Convert.ToInt32(Console.ReadLine());
        string fil = " ";
        for (int i = 1; i <= n1; i++) {

            fil = fil + i;

            Console.WriteLine(fil);




        }



    }

    public void resulSuma()
    {
        int suma = 0;
        
        for (int i = 100; i <= 200; i++)
        {


            if (i % 9 == 0)
            {
                Console.WriteLine(i);

                suma = i + suma;






            }
            else
            {

            }



        }

        Console.WriteLine("el resultado es: " + suma);
          
    }

    public void tablaMult()
    {
        Console.WriteLine("Ingrese un numero entero del 1 al 10: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.ReadKey();
        Console.Clear();

        for (int i = 1; i <= n2; i++)
        {
            Console.Write(i + " ");
            for (int j = 1; j <= n2; j++)
            {
                Console.Write((i * j) + "\t");
            }
            Console.Write('\n');
        }






    }





    static void  Main()
    {

        while (true)
        {
            try
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Hector Flores, Carnet: 1199923");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Grande, Pablo");

                Console.WriteLine("Ingrese el numero de ejercicio");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Ejercicios e = new Ejercicios();

                if (opcion == 1)
                {

                    e.numeroPar();
                    break;
                }
                else if (opcion == 2)
                {

                    e.numeroFilas();
                    break;
                }
                else if (opcion == 3)
                {

                    e.resulSuma();
                    break;
                }
                else if (opcion == 4)
                {

                    e.tablaMult();

                    break;

                }
                else
                {
                    Console.WriteLine("Ingrese el numero correcto de ejercicio");
                }

                Console.ReadKey();
                Console.Clear();

            }
            catch (Exception)
            {
                Console.WriteLine("Ingrese un numero de ejercicio valido");

            }

        }


    }
















}