public static class Ejercicio3
{
    // ej1
    static void Ej1()
    {
        Console.Write("Introduce el tamaño del array: ");
        int tamano = Convert.ToInt32(Console.ReadLine());

        int[] valores = new int[tamano];
        for (int i = 0; i < valores.Length; i++)
        {
            Console.Write($"Introduce el valor {i + 1}: ");
            valores[i] = Convert.ToInt32(Console.ReadLine());
        }

        int suma = 0;
        foreach (int valor in valores)
        {
            suma += valor;
        }

        Console.WriteLine($"La suma es {suma}");
        Console.WriteLine($"La media es {(double)suma / valores.Length}");
    }

    // ej2
    static int ContarEspacios(string texto)
    {
        int contador = 0;
        foreach (char c in texto)
        {
            if (c == ' ')
            {
                contador++;
            }
        }
        return contador;
    }

    // ej3
    static long Factorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    // ej4
    static bool EsPrimo(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    // ej5
    static double PotenciaIterativa(double baseNum, int exponente)
    {
        double resultado = 1;
        for (int i = 0; i < exponente; i++)
        {
            resultado *= baseNum;
        }
        return resultado;
    }

    // ej5
    static double PotenciaRecursiva(double baseNum, int exponente)
    {
        if (exponente == 0)
        {
            return 1;
        }
        return baseNum * PotenciaRecursiva(baseNum, exponente - 1);
    }

    // ej6
    static bool Login(string usuario, string password)
    {
        return usuario == "usuario2DAM" && password == "pass2DAM";
    }

    // ej7
    static bool EsMultiplo(int primero, int segundo)
    {
        return primero % segundo == 0;
    }

    // ej8
    static int SumaDigitos(int numero)
    {
        int suma = 0;
        while (numero > 0)
        {
            suma += numero % 10;
            numero /= 10;
        }
        return suma;
    }

    // ej9
    static int PosicionMenor(int[] valores)
    {
        int posicion = 0;
        for (int i = 1; i < valores.Length; i++)
        {
            if (valores[i] < valores[posicion])
            {
                posicion = i;
            }
        }
        return posicion;
    }

    static void Main()
    {
        // ej1
        Ej1();

        // ej2
        Console.Write("Introduce una cadena de texto: ");
        string texto = Console.ReadLine();
        Console.WriteLine($"Espacios en blanco: {ContarEspacios(texto)}");

        // ej3
        Console.Write("Introduce un número: ");
        int numeroFactorial = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{numeroFactorial}! = {Factorial(numeroFactorial)}");

        // ej4
        Console.Write("Introduce un número: ");
        int numeroPrimo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(EsPrimo(numeroPrimo) ? "Es primo" : "No es primo");

        // ej5
        Console.Write("Introduce la base: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el exponente: ");
        int exponente = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Potencia iterativa: {PotenciaIterativa(baseNum, exponente)}");
        Console.WriteLine($"Potencia recursiva: {PotenciaRecursiva(baseNum, exponente)}");

        // ej6
        bool acceso = false;
        for (int intento = 1; intento <= 3 && !acceso; intento++)
        {
            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Contraseña: ");
            string password = Console.ReadLine();
            acceso = Login(usuario, password);
        }
        Console.WriteLine(acceso);

        // ej7
        Console.Write("Introduce el primer número: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{a} es múltiplo de {b}: {EsMultiplo(a, b)}");
        Console.WriteLine($"{b} es múltiplo de {a}: {EsMultiplo(b, a)}");

        // ej8
        Console.Write("Introduce un número: ");
        int numeroDigitos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"La suma de los dígitos es {SumaDigitos(numeroDigitos)}");

        // ej9
        int[] valores = { 15, 8, 42, 3, 27, 19, 56 };
        Console.WriteLine($"La posición del menor es {PosicionMenor(valores)}");

        // ej10
        Banco banco = new Banco();
        banco.Operar();
        banco.ObtenerEstado();
    }
}

// ej10
public class Cliente
{
    private string nombre;
    private double cantidadTotal;

    public Cliente(string nombre)
    {
        this.nombre = nombre;
    }

    public void Ingresar(double cantidad)
    {
        cantidadTotal += cantidad;
    }

    public void Sacar(double cantidad)
    {
        cantidadTotal -= cantidad;
    }

    public double GetCantidadTotal()
    {
        return cantidadTotal;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"{nombre} tiene {cantidadTotal} en su cuenta");
    }
}

// ej10
public class Banco
{
    private Cliente cliente1;
    private Cliente cliente2;
    private Cliente cliente3;

    public Banco()
    {
        cliente1 = new Cliente("Ana");
        cliente2 = new Cliente("Luis");
        cliente3 = new Cliente("Marta");
    }

    public void Operar()
    {
        cliente1.Ingresar(1000);
        cliente2.Ingresar(250);
        cliente3.Ingresar(780);
    }

    public void ObtenerEstado()
    {
        double total = cliente1.GetCantidadTotal() + cliente2.GetCantidadTotal() + cliente3.GetCantidadTotal();
        Console.WriteLine($"Dinero total ingresado en el banco: {total}");
        Console.WriteLine($"Ana ha ingresado {cliente1.GetCantidadTotal()}");
        Console.WriteLine($"Luis ha ingresado {cliente2.GetCantidadTotal()}");
        Console.WriteLine($"Marta ha ingresado {cliente3.GetCantidadTotal()}");
    }
}
