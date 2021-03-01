using System;

namespace Ejercicio_6_Prac._4_
{
    class Program
    {

        struct Ficheros
        {
            public string Fichero;
            public float tm;
            public int anpix;
            public int alpix;

        };
        static void Main(string[] args)
        {

            Ficheros[] fichas
             = new Ficheros[700];
            int n = 0;
            int i;
            int opcion;
            string Buscar;



            do
            {

                Console.WriteLine();
                Console.WriteLine("Escoja una opción:");
                Console.WriteLine("1.- Añadir una ficha nueva");
                Console.WriteLine("2.- Ver todas las fichas");
                Console.WriteLine("3.- Buscar el nombre de la ficha");
                Console.WriteLine("4.- Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        if (n < fichas.Length)
                        {
                            Console.WriteLine("Introduce el nombre de la imagen: ");
                            fichas[n].Fichero = Console.ReadLine();
                            Console.WriteLine("Introduce el ancho de píxeles: ");
                            fichas[n].anpix = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Introduce el alto de píxeles: ");
                            fichas[n].alpix = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Introduce el tamaño en KiloByte: ");
                            fichas[n].tm = float.Parse(Console.ReadLine());


                            n++;
                            Console.Clear();
                        }
                        else
                            Console.WriteLine("\nEl programa ha alcanzado su capacidad máxima (700)");

                        break;

                    case 2:

                        for (i = 0; i < n; i++)
                        {

                            Console.WriteLine("\nNombre: {0} | Tamaño: {1} Kb | Ancho: {2} x Alto: {3}",
                            fichas[i].Fichero, fichas[i].tm, fichas[i].anpix, fichas[i].alpix);

                        }

                        break;
                    case 3:

                        Console.WriteLine("Introduzca el nombre de la imagen");
                        Buscar = Console.ReadLine();

                        for (i = 0; i < n; i++)

                            if (fichas[i].Fichero == Buscar)

                                Console.WriteLine("\nNombre: {0} | Tamaño: {1} Kb | Ancho: {2} x Alto: {3}", fichas[i].Fichero, fichas[i].tm, fichas[i].anpix, fichas[i].alpix);

                        break;

                    case 4:

                        Environment.Exit(0);

                        break;
                    default:

                        break;
                }
            } while (opcion != 4);



        }
    }
}
