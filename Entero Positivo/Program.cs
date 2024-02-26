try
{
    long menum = 0;
    long facto, numf;
    double raiz, numr;
    do
    {
        Console.Clear();
        Console.WriteLine("Bienvenido usuario, ¿Que te apatece hacer hoy?");
        Console.WriteLine();
        Console.WriteLine("1) Calcular el factorial de un numero");
        Console.WriteLine("2) Calcular la raiz cuadrada de un numero");
        Console.WriteLine("3) Salir");
        Console.WriteLine();
        Console.Write("> ");
        menum = Convert.ToInt32(Console.ReadLine());
        if (menum != 3)
        {
            switch (menum)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Ingrese un numero para sacar el factorial");
                    Console.WriteLine();
                    Console.Write("> ");
                    numf = Convert.ToInt32(Console.ReadLine());
                    facto = 1;
                    for (int i = 1; i <= numf; i++)
                    {
                        facto = facto * i;
                    }
                    Console.WriteLine();
                    Console.WriteLine("El factorial de: " + numf + " es: " + facto);
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Ingrese un numero para sacar raiz cuadrada");
                    Console.WriteLine();
                    Console.Write("> ");
                    numr = Convert.ToDouble(Console.ReadLine());
                    raiz = Math.Sqrt(numr);
                    Console.WriteLine();
                    Console.WriteLine("La raiz cuadrada de " + numr + " es " + raiz);
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Ingreso una opcion invalida");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("¿Desea repetir alguna operacion?");
            Console.WriteLine();
            Console.WriteLine("1) Repetir");
            Console.WriteLine("3) Salir del programa");
            Console.WriteLine();
            Console.Write("> ");
            menum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
    } while (menum != 3);
    Console.Clear();
    Console.WriteLine("Gracias por usar el programa :3");
}
catch (Exception error)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("El valor ingresado no es valido " + error);
}