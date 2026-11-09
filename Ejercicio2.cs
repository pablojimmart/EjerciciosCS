using System.Collections;

public static class Ejercicio2
{
    // ej1
    static void Ej1()
    {
        Console.Write("Introduce el primer número: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"El mayor es {(a > b ? a : b)}");
    }

    // ej2
    static void Ej2()
    {
        Console.Write("Introduce los kilowatios consumidos: ");
        double kwh = Convert.ToDouble(Console.ReadLine());

        double precio;
        if (kwh > 1800)
        {
            precio = 0.8;
        }
        else if (kwh >= 1000)
        {
            precio = 0.12;
        }
        else
        {
            precio = 0.14;
        }

        Console.WriteLine($"Total a pagar: {kwh * precio:C}");
    }

    // ej3
    static void Ej3()
    {
        Console.Write("Introduce tu estado civil (C, S, V o D): ");
        string estado = Console.ReadLine().ToUpper();

        switch (estado)
        {
            case "C":
                Console.WriteLine("Tu estado civil es Casad@");
                break;
            case "S":
                Console.WriteLine("Tu estado civil es Solter@");
                break;
            case "V":
                Console.WriteLine("Tu estado civil es Viud@");
                break;
            case "D":
                Console.WriteLine("Tu estado civil es Divorciad@");
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }

    // ej4
    static void Ej4()
    {
        Console.Write("Introduce un número del 1 al 9: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 1 || numero > 9)
        {
            Console.WriteLine("El número está fuera del rango");
            return;
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

    // ej5
    static void Ej5()
    {
        Console.Write("Introduce una cadena de texto: ");
        string texto = Console.ReadLine();

        Console.WriteLine($"Longitud: {texto.Length}");

        Console.Write("Introduce una subcadena a buscar: ");
        string subcadena = Console.ReadLine();
        Console.WriteLine($"Contiene la subcadena: {texto.Contains(subcadena)}");

        Console.Write("Introduce la letra a reemplazar: ");
        char antigua = Convert.ToChar(Console.ReadLine());
        Console.Write("Introduce la letra nueva: ");
        char nueva = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"Reemplazo: {texto.Replace(antigua, nueva)}");

        Console.WriteLine($"Mayúsculas: {texto.ToUpper()}");
        Console.WriteLine($"Minúsculas: {texto.ToLower()}");

        Console.Write("Introduce la posición del carácter a eliminar: ");
        int posicion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Sin el carácter: {texto.Remove(posicion, 1)}");

        Console.Write("Introduce la posición de inicio de la subcadena: ");
        int inicio = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce la posición de fin de la subcadena: ");
        int fin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Subcadena: {texto.Substring(inicio, fin - inicio + 1)}");
    }

    // ej6
    static void Ej6()
    {
        Console.Write("Introduce un número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        long factorial = 1;
        for (int i = 2; i <= numero; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"El factorial de {numero} es {factorial}");
    }

    // ej7
    static void Ej7()
    {
        for (int codigo = 90; codigo >= 65; codigo--)
        {
            Console.WriteLine(Convert.ToString((char)codigo));
        }
    }

    // ej8
    static void Ej8()
    {
        Random random = new Random();
        Console.WriteLine(random.Next(10, 31));
    }

    // ej9
    static void Ej9()
    {
        Console.Write("Introduce el tamaño del array: ");
        int tamano = Convert.ToInt32(Console.ReadLine());

        int[] valores = new int[tamano];
        for (int i = 0; i < valores.Length; i++)
        {
            Console.Write($"Introduce el valor {i + 1}: ");
            valores[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Valores pares:");
        foreach (int valor in valores)
        {
            if (valor % 2 == 0)
            {
                Console.WriteLine(valor);
            }
        }

        Console.WriteLine("Valores impares:");
        foreach (int valor in valores)
        {
            if (valor % 2 != 0)
            {
                Console.WriteLine(valor);
            }
        }
    }

    // ej10
    static void Ej10()
    {
        int[] numeros = { 42, 7, 19, 3, 88, 25, 61, 1, 54, 30 };

        Array.Sort(numeros);

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }

    // ej11
    static void Ej11()
    {
        Stack pila = new Stack();

        Console.Write("Introduce cuántos valores quieres meter en la pila: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Introduce el valor {i + 1}: ");
            pila.Push(Convert.ToInt32(Console.ReadLine()));
        }

        Console.WriteLine("Valores de la pila:");
        foreach (int valor in pila)
        {
            Console.WriteLine(valor);
        }

        pila.Pop();
        pila.Pop();

        Console.WriteLine("Valores de la pila tras sacar dos elementos:");
        foreach (int valor in pila)
        {
            Console.WriteLine(valor);
        }
    }

    static void Main()
    {
        Ej1();
        Ej2();
        Ej3();
        Ej4();
        Ej5();
        Ej6();
        Ej7();
        Ej8();
        Ej9();
        Ej10();
        Ej11();
    }
}
