try
{
    Random random = new Random();
    int rak, op;
    int cont;
    do
    {
        Console.Clear();
        cont = 0;
        Console.WriteLine("Hola! ¿Quieres jugar un juego?");
        Console.WriteLine();
        Console.WriteLine("1) Si");
        Console.WriteLine("0) Salir");
        Console.WriteLine();
        Console.Write("> ");
        op = Convert.ToInt32(Console.ReadLine());
        int roky = random.Next(101);
        if (op != 0)
        {
            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Adivina el numero aleatorio entre 0 y 100");
                    Console.WriteLine();
                    Console.Write("> ");
                    rak = Convert.ToInt32(Console.ReadLine());
                    cont ++;
                    do
                    {
                        if (rak > roky)
                        {
                            Console.Clear();
                            Console.WriteLine("Demasiado alto");
                            Console.WriteLine();
                            Console.Write("> ");
                            rak = Convert.ToInt32(Console.ReadLine());
                            cont++;
                        }
                        else 
                        {
                            Console.Clear();
                            Console.WriteLine("Demasiado bajo");
                            Console.WriteLine();
                            Console.Write("> ");
                            rak = Convert.ToInt32(Console.ReadLine());
                            cont++;
                        }
                    } while (rak != roky);
                    Console.Clear();
                    Console.WriteLine("Felicidades, encontraste el numero aleatroio que era: " + roky);
                    Console.WriteLine();
                    Console.WriteLine("Tu numero de intentos fue de: " + cont);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("La opcion ingresada es invalida");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("¿Desea repetir el programa?");
            Console.WriteLine();
            Console.WriteLine("1) Si");
            Console.WriteLine("0) No");
            Console.WriteLine();
            Console.Write("> ");
            op = Convert.ToInt32(Console.ReadLine());
        }
    } while (op != 0);
    Console.Clear();
    Console.WriteLine("Gracias por usar el programa :3");
}catch(Exception error)
{
    Console.Clear();
    Console.WriteLine("El formato ingresado no es valido " + error);
}