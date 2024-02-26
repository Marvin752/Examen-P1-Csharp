try
{
    int tabla;
    int results;
    char menum = 'S';
    do
    {
        Console.Clear();
        Console.WriteLine("\tBienvenido al programa que le muestra la tabla del 1 al 10 de un numero");
        Console.WriteLine();
        Console.WriteLine("M) Calcular Tabla");
        Console.WriteLine("S) Salir");
        Console.WriteLine();
        Console.Write("> ");
        menum = Convert.ToChar(Console.ReadLine().ToUpper());
        if (menum == 'M' && menum != 'S')
        {
            Console.Clear();
            Console.WriteLine("Ingrese un numero para calcular su tabla");
            Console.WriteLine();
            Console.Write("> ");
            tabla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int t = 1; t <= 10; t++)
            {
                results = 0;
                results = tabla * t;
                Console.WriteLine(tabla + " * " + t + " = " + results);
            }
            Console.WriteLine();
            Console.WriteLine("¿Desea volver al menu principal??");
            Console.WriteLine();
            Console.WriteLine("V) Volver");
            Console.WriteLine("S) Salir");
            Console.WriteLine();
            Console.Write("> ");
            menum = Convert.ToChar(Console.ReadLine().ToUpper());
        } else if(menum !='S')
        {
            Console.Clear();
            Console.WriteLine("Ingreso una opcion invalida");
            Console.WriteLine();
            Console.WriteLine("¿Desea repetir el programa?");
            Console.WriteLine();
            Console.WriteLine("R) Repetir");
            Console.WriteLine("S) Salir");
            Console.WriteLine();
            Console.Write("> ");
            menum = Convert.ToChar(Console.ReadLine().ToUpper());

        }   
    } while (menum != 'S');
    Console.Clear();
    Console.WriteLine("Gracias por usar el programa :3");
}
catch (Exception error)
{
    Console.Clear();
    Console.WriteLine("El formato ingresado es invalido " + error);
}