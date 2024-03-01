try
{
    int opp;
    do
    {
        Console.Clear();
        Console.WriteLine("Bienvenido a los programas del examen");
        Console.WriteLine();
        Console.WriteLine("1) Entero positivo");
        Console.WriteLine("2) Operadores Matematicos");
        Console.WriteLine("3) Tabla de Multiplicar");
        Console.WriteLine("4) Numero random");
        Console.WriteLine("0) Salir del programa");
        Console.WriteLine();
        Console.Write("> ");
        opp = Convert.ToInt32(Console.ReadLine());
        if( opp != 0 )
        {
            switch (opp)
            {
                case 1:
                    long menum = 0;
                    long facto, numf;
                    double raiz, numr;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\tBienvenido usuario, ¿Que te apatece hacer hoy?");
                        Console.WriteLine();
                        Console.WriteLine("1) Calcular el factorial de un numero");
                        Console.WriteLine("2) Calcular la raiz cuadrada de un numero");
                        Console.WriteLine("3) Regresar al menu principal");
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
                            Console.WriteLine("3) Regresar al menu principal");
                            Console.WriteLine();
                            Console.Write("> ");
                            menum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                        }
                    } while (menum != 3);
                    Console.Clear();
                    Console.WriteLine("Gracias por usar el programa :3");
                    Console.WriteLine();
                    Console.Write("> ");
                    Console.ReadKey();
                    break;
                case 2:
                    char menuc = 'S';
                    double num1p, num2p;
                    double resulp;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\tBienvenido al programa para usar operaciones matematicas ¿Qué desea hacer hoy?");
                        Console.WriteLine("+) Suma");
                        Console.WriteLine("-) Resta");
                        Console.WriteLine("*) Multiplicación");
                        Console.WriteLine("/) Division");
                        Console.WriteLine("S) Regresar al menu principal");
                        Console.WriteLine();
                        Console.Write("> ");
                        menuc = Convert.ToChar(Console.ReadLine().ToUpper());
                        if (menuc != 'S')
                        {
                            switch (menuc)
                            {
                                case '+':
                                    Console.WriteLine();
                                    Console.WriteLine("Ingrese un numero para sumar");
                                    Console.WriteLine();
                                    Console.Write("> ");
                                    num1p = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine();
                                    Console.WriteLine("Ingrese un segundo numero para sumar");
                                    Console.WriteLine();
                                    Console.Write("> ");
                                    num2p = Convert.ToDouble(Console.ReadLine());
                                    resulp = num1p + num2p;
                                    Console.WriteLine();
                                    Console.WriteLine("El resultado de la suma es: " + resulp);
                                    break;
                                case '-':
                                    Console.WriteLine();
                                    Console.WriteLine("Ingrese un numero para restar");
                                    Console.WriteLine();
                                    Console.Write("> ");
                                    num1p = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine();
                                    Console.WriteLine("Ingrese un segundo numero para restar");
                                    Console.WriteLine();
                                    Console.Write("> ");
                                    num2p = Convert.ToDouble(Console.ReadLine());
                                    resulp = num1p - num2p;
                                    Console.WriteLine();
                                    Console.WriteLine("El resultado de la resta es: " + resulp);
                                    break;
                                case '*':
                                    Console.WriteLine();
                                    Console.WriteLine("Ingrese un numero para multiplicar");
                                    Console.WriteLine();
                                    Console.Write("> ");
                                    num1p = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine();
                                    Console.WriteLine("Ingrese un segundo numero para multiplicar");
                                    Console.WriteLine();
                                    Console.Write("> ");
                                    num2p = Convert.ToDouble(Console.ReadLine());
                                    resulp = num1p * num2p;
                                    Console.WriteLine();
                                    Console.WriteLine("El resultado de la multiplicación es: " + resulp);
                                    break;
                                case '/':
                                    Console.WriteLine();
                                    Console.WriteLine("Ingrese un numero para dividir");
                                    Console.WriteLine();
                                    Console.Write("> ");
                                    num1p = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine();
                                    Console.WriteLine("Ingrese un segundo numero para dividir");
                                    Console.WriteLine();
                                    Console.Write("> ");
                                    num2p = Convert.ToDouble(Console.ReadLine());
                                    resulp = num1p / num2p;
                                    Console.WriteLine();
                                    Console.WriteLine("El resultado de la división es: " + resulp);
                                    break;
                                default:
                                    Console.WriteLine();
                                    Console.WriteLine("Ingreso una opcion invalida");
                                    break;
                            }
                            Console.WriteLine();
                            Console.WriteLine("¿Desea repetir alguna operacion?");
                            Console.WriteLine();
                            Console.WriteLine("R) Repetir");
                            Console.WriteLine("S) Regresar al menu principal");
                            Console.WriteLine();
                            Console.Write("> ");
                            menuc = Convert.ToChar(Console.ReadLine().ToUpper());
                            Console.WriteLine();
                        }
                    } while (menuc != 'S');
                    Console.Clear();
                    Console.WriteLine("Gracias por usar el programa :3");
                    Console.WriteLine();
                    Console.Write("> ");
                    Console.ReadKey();
                    break;
                case 3:
                    int tabla;
                    int results;
                    char menum1 = 'S';
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\tBienvenido al programa que le muestra la tabla del 1 al 10 de un numero");
                        Console.WriteLine();
                        Console.WriteLine("M) Calcular Tabla");
                        Console.WriteLine("S) Regresar al menu principal");
                        Console.WriteLine();
                        Console.Write("> ");
                        menum1 = Convert.ToChar(Console.ReadLine().ToUpper());
                        if (menum1 == 'M' && menum1 != 'S')
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
                            Console.WriteLine("S) Regresar al menu principal");
                            Console.WriteLine();
                            Console.Write("> ");
                            menum1 = Convert.ToChar(Console.ReadLine().ToUpper());
                        }
                        else if (menum1 != 'S')
                        {
                            Console.Clear();
                            Console.WriteLine("Ingreso una opcion invalida");
                            Console.WriteLine();
                            Console.WriteLine("¿Desea repetir el programa?");
                            Console.WriteLine();
                            Console.WriteLine("R) Repetir");
                            Console.WriteLine("S) Regresar al menu principal");
                            Console.WriteLine();
                            Console.Write("> ");
                            menum1 = Convert.ToChar(Console.ReadLine().ToUpper());

                        }
                    } while (menum1 != 'S');
                    Console.Clear();
                    Console.WriteLine("Gracias por usar el programa :3");
                    Console.WriteLine();
                    Console.Write("> ");
                    Console.ReadKey();
                    break;
                case 4:
                    Random random = new Random();
                    int rak, op;
                    int cont;
                    do
                    {
                        Console.Clear();
                        cont = 0;
                        Console.WriteLine("\t¡Hola! ¿Quieres jugar un juego?");
                        Console.WriteLine();
                        Console.WriteLine("1) Si");
                        Console.WriteLine("0) Regresar al menu principal");
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
                                    cont++;
                                    while (rak != roky)
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
                                    }
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
                            Console.WriteLine("0) Regresar al menu principal");
                            Console.WriteLine();
                            Console.Write("> ");
                            op = Convert.ToInt32(Console.ReadLine());
                        }
                    } while (op != 0);
                    Console.Clear();
                    Console.WriteLine("Gracias por usar el programa :3");
                    Console.WriteLine();
                    Console.Write("> ");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Usted ingreso una opcion invalida");
                    Console.WriteLine();
                    Console.WriteLine("1) Regresar al menu principal");
                    Console.WriteLine("0) Salir");
                    Console.WriteLine();
                    Console.Write("> ");
                    opp = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
    } while (opp != 0);
    Console.WriteLine();
    Console.WriteLine("Gracias por utilizar el programa :3");
}
catch(Exception error)
{
    Console.WriteLine("El dato ingresado no es del tipo correcto " + error);
}