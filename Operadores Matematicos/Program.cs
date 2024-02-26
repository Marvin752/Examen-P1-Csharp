using System;
using System.Timers;

try
{
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
        Console.WriteLine("S) Salir");
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
            Console.WriteLine("S) Salir del programa");
            Console.WriteLine();
            Console.Write("> ");
            menuc = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine();
        }
    } while (menuc != 'S');
    Console.Clear();
    Console.WriteLine("Gracias por usar el programa :3");
}
catch (Exception error)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("El formato ingresado es incorrecto " + error);
}