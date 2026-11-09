public static class Ejercicio1
{
    // ej1
    static void Ej1()
    {
        Console.Write("Introduce el primer número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"La suma es {numero1 + numero2}");
        Console.WriteLine($"La resta es: {numero1} - {numero2} = {numero1 - numero2}");
        Console.WriteLine($"La multiplicación es: {numero1 * numero2}");
        Console.WriteLine($"La división es: {numero1 / numero2}");
        Console.WriteLine($"El módulo es: {numero1 % numero2}");
    }

    // ej2
    static void Ej2()
    {
        const double PrecioHamburguesa = 4.00;
        const double PrecioPapas = 1.75;
        const double PrecioBebida = 1.90;

        Console.Write("Cantidad de hamburguesas: ");
        int hamburguesas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cantidad de papas: ");
        int papas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cantidad de bebidas: ");
        int bebidas = Convert.ToInt32(Console.ReadLine());

        double total = hamburguesas * PrecioHamburguesa + papas * PrecioPapas + bebidas * PrecioBebida;
        Console.WriteLine($"Cantidad a pagar: {total:F2}€");
    }

    // ej3
    static void Ej3()
    {
        const double OtroNumero = 10;

        Console.Write("Introduce un número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
        Console.WriteLine($"Potencia al cubo: {Math.Pow(numero, 3)}");
        Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}");
        Console.WriteLine($"Seno: {Math.Sin(numero)}");
        Console.WriteLine($"Coseno: {Math.Cos(numero)}");
        Console.WriteLine($"Número máximo entre {numero} y {OtroNumero}: {Math.Max(numero, OtroNumero)}");
        Console.WriteLine($"Número mínimo entre {numero} y {OtroNumero}: {Math.Min(numero, OtroNumero)}");
    }

    // ej4
    static void Ej4()
    {
        Console.Write("Introduce el valor de un lado: ");
        double lado = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"El perímetro del cuadrado es {4 * lado}");
    }

    // ej5
    static void Ej5()
    {
        Console.Write("Introduce el primer número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el tercer número: ");
        double n3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el cuarto número: ");
        double n4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"La suma de los dos primeros es {n1 + n2}");
        Console.WriteLine($"El producto del tercero y el cuarto es {n3 * n4}");
    }

    // ej6
    static void Ej6()
    {
        Console.Write("Introduce el primer valor: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el segundo valor: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el tercer valor: ");
        double n3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el cuarto valor: ");
        double n4 = Convert.ToDouble(Console.ReadLine());

        double suma = n1 + n2 + n3 + n4;
        Console.WriteLine($"La suma es {suma}");
        Console.WriteLine($"El promedio es {suma / 4}");
    }

    // ej7
    static void Ej7()
    {
        Console.Write("Introduce el precio del artículo: ");
        double precio = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce la cantidad que lleva el cliente: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"El coste total es {precio * cantidad}");
    }

    // ej8
    static void Ej8()
    {
        Console.Write("Introduce la nota del primer parcial: ");
        double parcial1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce la nota del segundo parcial: ");
        double parcial2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce la nota del examen: ");
        double examen = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce la nota del trabajo final: ");
        double trabajo = Convert.ToDouble(Console.ReadLine());

        double notaFinal = (parcial1 + parcial2) / 2 * 0.5 + examen * 0.3 + trabajo * 0.2;
        Console.WriteLine($"La nota final es {notaFinal}");
    }

    // ej9
    static void Ej9()
    {
        Console.Write("Introduce la cantidad que aporta el socio 1: ");
        double aporte1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce la cantidad que aporta el socio 2: ");
        double aporte2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce la cantidad que aporta el socio 3: ");
        double aporte3 = Convert.ToDouble(Console.ReadLine());

        double total = aporte1 + aporte2 + aporte3;

        Console.WriteLine("El porcentaje del socio 1 es {0}%, del socio 2 es {1}% y del socio 3 es {2}%",
            aporte1 * 100 / total, aporte2 * 100 / total, aporte3 * 100 / total);
    }

    // ej10
    static void Ej10()
    {
        Console.Write("Introduce un texto: ");
        string texto = Console.ReadLine();

        Console.WriteLine(texto.StartsWith("www").ToString().ToLower());
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
    }
}
