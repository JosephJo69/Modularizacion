
int calculadora()
{
    int suma()
    {
        Console.WriteLine("SUMA");
        Console.WriteLine("Ingrese el primer numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int resultado = num1 + num2;
        Console.WriteLine("El resultado de la suma es: " + resultado);
        return resultado;
    }

    int resta()
    {
        Console.WriteLine("RESTA");
        Console.WriteLine("Ingrese el primer numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int resultado = num1 - num2;
        Console.WriteLine("El resultado de la resta es: " + resultado);
        return resultado;
    }

    int multiplicacion()
    {
        Console.WriteLine("MULTIPLICACION");
        Console.WriteLine("Ingrese el primer numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int resultado = num1 * num2;
        Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
        return resultado;
    }

    double division()
    {
        Console.WriteLine("DIVISION");
        Console.WriteLine("Ingrese el primer numero: ");
        double num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double resultado = num1 / num2;
        Console.WriteLine("El resultado de la division es: " + resultado);
        return resultado;
    }

    Console.WriteLine("CALCULADORA");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicacion");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Ingrese una opcion: ");
    int opcion = Convert.ToInt32(Console.ReadLine());
    
    switch(opcion)
    {
        case 1:
            suma();
            break;
        case 2:
            resta();
            break;
        case 3:
            multiplicacion();
            break;
        case 4:
            division();
            break;
        case 5:
            return 0;
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
    return opcion;
}

int contraseña()
{ 
    string incontraseña;
    string contraseña = "1234";

    Console.WriteLine("Ingrese la contraseña");
    incontraseña = Console.ReadLine();
    if (incontraseña == contraseña)
    {
        Console.WriteLine("Contraseña Correcta");
    }
    else
    {
        do
        {
            Console.WriteLine("Contraseña Incorrecta, Intente de nuevo");
            incontraseña = Console.ReadLine();
        } while (incontraseña != contraseña);
    }
    return 0;
}

int numerosprimos()
{
    Console.WriteLine("NUMEROS PRIMOS");
    Console.WriteLine("Ingrese un numero: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int contador = 0;
    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            contador++;
        }
    }
    if (contador == 2)
    {
        Console.WriteLine("El numero " + num + " es primo");
    }
    else
    {
        Console.WriteLine("El numero " + num + " no es primo");
    }
    return 0;
}

int sumanumeros()
{
    int suma = 0;
    int numero;

    Console.WriteLine("Ingrese un numero: ");

    while (true)
    {
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero == 0)
        {
            break;
        }
        suma += numero;
    }
    Console.WriteLine("La suma de los numeros es: " + suma);
    return 0;
}

int grados()
{
    double celsiusafarenheit()
    {
        Console.WriteLine("Ingrese los grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Los grados Fahrenheit son: " + fahrenheit);
        return fahrenheit;
    }

    double farenheitacelsius()
    {
        Console.WriteLine("Ingrese los grados Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine("Los grados Celsius son: " + celsius);
        return celsius;
    }

    Console.WriteLine("Conversor de grados");
    Console.WriteLine("1. Celsius a Fahrenheit");
    Console.WriteLine("2. Fahrenheit a Celsius");
    Console.WriteLine("3. Salir");
    Console.WriteLine("Ingrese una opcion: ");
    int opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            celsiusafarenheit();
            break;
        case 2:
            farenheitacelsius();
            break;
        case 3:
            return 0;
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
    return 0;
}

int vocales()
{
    Console.WriteLine("Contador de vocales");   
    Console.WriteLine("Ingrese una palabra: ");
    string palabra = Console.ReadLine();
    int contador = 0;
    for (int i = 0; i < palabra.Length; i++)
    {
        if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
        {
            contador++;
        }
    }
    Console.WriteLine("La palabra " + palabra + " tiene " + contador + " vocales");
    return 0;
}

int factorial()
{
    Console.WriteLine("Calculo de Factorial");
    Console.WriteLine("Ingrese un numero: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    Console.WriteLine("El factorial de " + num + " es: " + factorial);
    return 0;
}

int adivinanza()
{
    Console.WriteLine("Adivina el numero");
    Random random = new Random();
    int numero = random.Next(1, 100);
    int intentos = 0;
    int adivina;
    do
    {
        Console.WriteLine("Ingrese un numero: ");
        adivina = Convert.ToInt32(Console.ReadLine());
        intentos++;
        if (adivina > numero)
        {
            Console.WriteLine("El numero es menor");
        }
        else if (adivina < numero)
        {
            Console.WriteLine("El numero es mayor");
        }
    } while (adivina != numero);
    Console.WriteLine("Felicidades, adivinaste el numero en " + intentos + " intentos");
    return 0;
}

void Intercambiar(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

void IntercambiarNumeros()


{
    Console.WriteLine("Intercambiar Números");
    Console.WriteLine("Ingrese el primer número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Valores originales: num1 = {num1}, num2 = {num2}");

    Intercambiar(ref num1, ref num2);

    Console.WriteLine($"Valores intercambiados: num1 = {num1}, num2 = {num2}");
}

int tablamultiplicar()
{
    Console.WriteLine("TABLA DE MULTIPLICAR");
    Console.WriteLine("Ingrese un numero: ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(num + " x " + i + " = " + num * i);
    }
    return 0;
}



while (true)
    {
        Console.Clear();
        Console.WriteLine("MODULARIZACION");
        Console.WriteLine("----------------");
        Console.WriteLine("Seleccione un numero para ir al ejercicio:");
        Console.WriteLine("EJERCICIO 1: CALCULADORA");
        Console.WriteLine("EJERCICIO 2: CONTRASEÑA");
        Console.WriteLine("EJERCICIO 3: NUMEROS PRIMOS");
        Console.WriteLine("EJERCICIO 4: SUMA DE NUMEROS");
        Console.WriteLine("EJERCICIO 5: CONVERSOR DE GRADOS");
        Console.WriteLine("EJERCICIO 6: CONTADOR DE VOCALES");
        Console.WriteLine("EJERCICIO 7: CALCULO DE FACTORIAL");
        Console.WriteLine("EJERCICIO 8: ADIVINANZA");
        Console.WriteLine("EJERCICIO 9: INTERCAMBIO DE NUMEROS");
        Console.WriteLine("EJERCICIO 10: TABLA DE MULTIPLICAR");
        Console.WriteLine("11: SALIR");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                calculadora();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            break;

            case 2:
                contraseña();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            break;

            case 3:
                numerosprimos();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            break;

            case 4:
                sumanumeros();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            break;

            case 5:
                grados();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            break;

            case 6:
                vocales();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            break;

            case 7:
                factorial();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            break;
                
            case 8:
                adivinanza();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            break;

            case 9:
                IntercambiarNumeros();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            break;

            case 10:
                tablamultiplicar();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            break;

            case 11:
                Console.WriteLine("Saliendo del programa...");
                return 0;

                break;

            default:
                Console.WriteLine("Opcion no valida");

                break;
        }
    }
